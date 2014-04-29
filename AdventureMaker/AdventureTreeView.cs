using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuestInfo;
using System.Drawing;

namespace AdventureMaker {
	class AdventureTreeView : TreeView {
		Dictionary<StoryNode, TreeNode> ReverseNodeMapping = new Dictionary<StoryNode, TreeNode>();

		

		private Adventure _adventure;
		public Adventure Adventure {
			get {
				return _adventure;
			}
			set {
				_adventure = value;
				Refresh();

				if(Adventure != null && Adventure.StartingPoint != null) {
					this.SelectedNode = ReverseNodeMapping[Adventure.StartingPoint];
				}
			}
		}

		private TreeNode CreateTreeNode(StoryNode storyNode) {
			TreeNode node = new TreeNode(storyNode.Name);
			this.BindData(node, storyNode);

			/* Context Menu Strip */
			ContextMenuStrip NodeOptions = new ContextMenuStrip();
			NodeOptions.Tag = node;
			ToolStripItem ExpandAll = NodeOptions.Items.Add("Expand All");
			ExpandAll.Tag = node;
			ExpandAll.Click += new EventHandler(ExpandAll_Click);

			ToolStripItem CollapseAll = NodeOptions.Items.Add("Collapse All");
			CollapseAll.Tag = node;
			CollapseAll.Click += new EventHandler(CollapseAll_Click);

			node.ContextMenuStrip = NodeOptions;

			/* Children */
			if(!(storyNode is ReferenceNode)) {
				foreach(Option option in storyNode.Options) {
					node.Nodes.Add(CreateTreeNode(option.Node));
				}
			}
			return node;
		}

		static void ExpandAll_Click(object sender, EventArgs e)
		{
			((TreeNode)((ToolStripItem)sender).Tag).ExpandAll();
		}

		static void CollapseAll_Click(object sender, EventArgs e)
		{
			TreeNode target = ((TreeNode)((ToolStripItem)sender).Tag);
			RecursiveCollapse(target);
		}

		static void RecursiveCollapse(TreeNode node)
		{
			node.Collapse();

			foreach (TreeNode child in node.Nodes) {
				RecursiveCollapse(child);
			}
		}

		private void BindData(TreeNode node, StoryNode data) {
			node.Text = data.Name;
			node.Tag = data;

			if(!ReverseNodeMapping.ContainsKey(data)) {
				ReverseNodeMapping.Add(data, node);
			} else {
				ReverseNodeMapping[data] = node;
			}

			if(data == Adventure.StartingPoint) {
				node.ForeColor = Color.Green;
			} else if(data is ReferenceNode) {
				node.ForeColor = Color.Blue;
			} else {
				node.ForeColor = Color.Black;
			}
		}

		public TreeNode GetNode(StoryNode node) {
			if (node is ReferenceNode) return GetNode(((ReferenceNode)node).Reference);

			if(ReverseNodeMapping.ContainsKey(node)) {
				return ReverseNodeMapping[node];
			} else {
				throw new Exception("Failed to find Storynode in Reverse Node Mapping");
			}
		}

		public override void Refresh() {
			StoryNode selectednode = this.SelectedStoryNode;

			ReverseNodeMapping.Clear();
			if (Adventure == null) return;

			/* Remove Old Nodes */
			List<TreeNode> ToRemove = new List<TreeNode>();
			foreach(TreeNode node in this.Nodes) {
				bool Found = false;
				foreach(StoryNode storynode in Adventure.RootStoryNodes) {
					if(node.Tag == storynode) {
						Found = true;
						break;
					}
					if(!Found) {
						ToRemove.Add(node);
					}
				}
			}
			foreach(TreeNode node in ToRemove) {
				this.Nodes.Remove(node);
			}

			/* Add/Update Existing Nodes */
			foreach(StoryNode storyNode in Adventure.RootStoryNodes) {
				TreeNode child = null;
				foreach(TreeNode node in this.Nodes) {
					if(node.Tag == storyNode) {
						child = node;
						break;
					}
				}

				if (child == null){
					this.Nodes.Add(CreateTreeNode(storyNode));
				} else {
					this.BindData(child, storyNode);
					UpdateNode(child);
				}
			}

			if(selectednode != null && ReverseNodeMapping.ContainsKey(selectednode)) {
				this.SelectedStoryNode = selectednode;
			}

			/* Lastly, ensure all reference nodes reference an existing node */
			List<KeyValuePair<StoryNode, TreeNode>> ToUpdate = new List<KeyValuePair<StoryNode, TreeNode>>();
			foreach (KeyValuePair<StoryNode, TreeNode> kvp in ReverseNodeMapping) {
				if (kvp.Key is ReferenceNode) {
					ReferenceNode node = kvp.Key as ReferenceNode;
					if (!ReverseNodeMapping.ContainsKey(node.Reference)) {
						ToUpdate.Add(kvp);
					}
				}
			}
			if (ToUpdate.Count > 0) {
				foreach (KeyValuePair<StoryNode, TreeNode> node in ToUpdate) {
					ReferenceNode refNode = node.Key as ReferenceNode;

					if (ReverseNodeMapping.ContainsKey(refNode.Reference)) {
						continue; // Already updated...
					}
					StoryNode parentNode = (StoryNode)node.Value.Parent.Tag;

					bool FoundOne = false;
					foreach (Option opt in parentNode.Options) {
						if (opt.Node == refNode) {
							opt.Node = refNode.Reference;
							node.Value.Tag = opt.Node;
							ReverseNodeMapping[opt.Node] = node.Value;
							FoundOne = true;
							break;
						}
					}

					if (!FoundOne) {
						throw new Exception("Failed to find reference node to non existant story node");
					}
				}
				Refresh();
			}
		}

		private void UpdateNode(TreeNode treeNode) {
			StoryNode storyNode = (StoryNode)treeNode.Tag;
			this.BindData(treeNode, storyNode);

			if(treeNode.Tag is ReferenceNode) {
				treeNode.Nodes.Clear();
				return;
			}

			/* Remove Old Nodes */
			List<TreeNode> ToRemove = new List<TreeNode>();
			foreach(TreeNode child in treeNode.Nodes) {
				bool Found = false;
				foreach(Option opt in storyNode.Options) {
					if(opt.Node == child.Tag) {
						Found = true;
						break;
					}
				}
				if(!Found) {
					ToRemove.Add(child);
				}
			}
			foreach(TreeNode remove in ToRemove) {
				treeNode.Nodes.Remove(remove);
			}

			/* Add/Update Existing Nodes */
			foreach(Option opt in storyNode.Options) {
				TreeNode Found = null;
				foreach(TreeNode child in treeNode.Nodes) {
					if(child.Tag == opt.Node) {
						Found = child;
						break;
					}
				}
				if(Found != null) {
					UpdateNode(Found);
				} else {
					treeNode.Nodes.Add(this.CreateTreeNode(opt.Node));
				}
			}
		}

		public StoryNode SelectedStoryNode {
			get {
				if (this.SelectedNode == null) return null;
				return (StoryNode)this.SelectedNode.Tag;
			}
			set {
				if (value == null) return;
				this.SelectedNode = ReverseNodeMapping[value];
			}
		}
	}
}
