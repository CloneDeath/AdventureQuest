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

				if(Adventure != null) {
					this.SelectedNode = ReverseNodeMapping[Adventure.StartingPoint];
				}
			}
		}

		private TreeNode CreateTreeNode(StoryNode storyNode) {
			TreeNode node = new TreeNode(storyNode.Name);
			this.BindData(node, storyNode);

			if(!(storyNode is ReferenceNode)) {
				foreach(Option option in storyNode.Options) {
					node.Nodes.Add(CreateTreeNode(option.Node));
				}
			}
			return node;
		}

		private void BindData(TreeNode node, StoryNode data) {
			node.Text = data.Name;
			node.Tag = data;

			if(!ReverseNodeMapping.ContainsKey(data)) {
				ReverseNodeMapping.Add(data, node);
			} else {
				ReverseNodeMapping[data] = node;
			}

			if(data is ReferenceNode) {
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

			this.Nodes.Clear();
			ReverseNodeMapping.Clear();
			if (Adventure == null) return;

			this.Nodes.Clear();
			this.Nodes.Add(CreateTreeNode(Adventure.StartingPoint));

			if(selectednode != null) {
				this.SelectedStoryNode = selectednode;
			}
		}

		public void Refresh(StoryNode storyNode) {
			TreeNode node = GetNode(storyNode);
			BindData(node, storyNode);
			node.Nodes.Clear();
		}

		public StoryNode SelectedStoryNode {
			get {
				if (this.SelectedNode == null) return null;
				return (StoryNode)this.SelectedNode.Tag;
			}
			set {
				this.SelectedNode = ReverseNodeMapping[value];
			}
		}
	}
}
