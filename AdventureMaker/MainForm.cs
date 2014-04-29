using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuestInfo;
using AdventureQuest;

namespace AdventureMaker {
	public partial class MainForm : Form {
		Adventure _adventure;
		public Adventure CurrentAdventure
		{
			get
			{
				return _adventure;
			}
			set
			{
				_adventure = value;
				uiOptionEditor.Adventure = value;
				uiOperationEditor_StoryNode.Adventure = value;
			}
		}
		public string LastFileAccess = null;

		StoryNode CurrentNode {
			get {
				if(tvAdventureNodes.SelectedNode == null) {
					return null;
				}
				return (StoryNode)tvAdventureNodes.SelectedNode.Tag;
			}
		}

		public MainForm() {
			InitializeComponent();
			NewAdventure();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e) {
			if (MessageBox.Show("Are you sure you wish to make a new adventure?\r\n" +
								"All data will be lost.", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {

				NewAdventure();
			}
			
		}

		private void NewAdventure()
		{
			LastFileAccess = null;
			saveToolStripMenuItem.Enabled = false;

			CurrentAdventure = new Adventure();
			StoryNode root = new StoryNode();
			CurrentAdventure.RootStoryNodes.Add(root);
			CurrentAdventure.StartingPoint = root;
			CurrentAdventureChanged();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
			CurrentAdventure.Save(LastFileAccess);
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "QuestInfo (*.qi)|*.qi|All Files (*.*)|*.*";
			if (sfd.ShowDialog() == DialogResult.OK) {
				CurrentAdventure.Save(sfd.FileName);
				saveToolStripMenuItem.Enabled = true;
				LastFileAccess = sfd.FileName;
			}
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "QuestInfo (*.qi)|*.qi|All Files (*.*)|*.*";
			ofd.Multiselect = false;
			if(ofd.ShowDialog() == DialogResult.OK) {
				CurrentAdventure = Adventure.Load(ofd.FileName);
				CurrentAdventureChanged();
				saveToolStripMenuItem.Enabled = true;
				LastFileAccess = ofd.FileName;
				tvAdventureNodes.ExpandAll();
			}
		}

		private void CurrentAdventureChanged() {
			tvAdventureNodes.Adventure = this.CurrentAdventure;
			RefreshUI();
		}

		

		private void tvAdventureNodes_AfterSelect(object sender, TreeViewEventArgs e) {
			if(tvAdventureNodes.SelectedStoryNode is ReferenceNode) {
				tvAdventureNodes.SelectedStoryNode = ((ReferenceNode)tvAdventureNodes.SelectedStoryNode).Reference;
			}

			uiOptionEditor.StoryNode = tvAdventureNodes.SelectedStoryNode;
			if (tvAdventureNodes.SelectedStoryNode != null) {
				uiOperationEditor_StoryNode.Operations = tvAdventureNodes.SelectedStoryNode.OnEnter;
			} else {
				uiOperationEditor_StoryNode.Operations = null;
			}
			RefreshUI();
		}

		private void tbName_TextChanged(object sender, EventArgs e) {
			CurrentNode.Name = tbName.Text;
			tvAdventureNodes.SelectedNode.Text = tbName.Text;
		}

		private void tbText_TextChanged(object sender, EventArgs e) {
			CurrentNode.Text = tbText.Text;
		}

		private void btnAddOption_Click(object sender, EventArgs e) {
			Option newitem = new Option();
			CurrentNode.Options.Add(newitem);

			tvAdventureNodes.Refresh();
			tvAdventureNodes.GetNode(CurrentNode).Expand();

			RefreshUI();
			lbOptions.SelectedItem = newitem;
		}

		private void btnDeleteOption_Click(object sender, EventArgs e) {
			if (CurrentNode.Options.Count == 0) return;

			Option selectednode = (Option)lbOptions.SelectedItem;

			if (selectednode.Node is ReferenceNode) {
				CurrentNode.Options.Remove(selectednode);

				tvAdventureNodes.Refresh();
				RefreshUI();
			} else {
				if (MessageBox.Show("Are you sure you wish to delete this option? The story node and any children will go with it...", "Warning", MessageBoxButtons.YesNoCancel) == DialogResult.Yes) {
					CurrentNode.Options.Remove(selectednode);

					tvAdventureNodes.Refresh();
					RefreshUI();
				}
			}
		}

		private void RefreshUI() {
			if(CurrentNode == null) {
				tbName.Text = "";
				tbName.Enabled = false;
				tbName.ForeColor = Color.Black;

				tbText.Text = "";
				tbText.Enabled = false;

				lbOptions.Items.Clear();
				uiOptionEditor.Option = null;

				btnMoveOptionUp.Enabled = false;
				btnMoveOptionDown.Enabled = false;
			} else {
				tbName.Text = CurrentNode.Name;
				tbName.Enabled = true;
				if (CurrentNode == CurrentAdventure.StartingPoint) {
					tbName.ForeColor = Color.Green;
				} else {
					tbName.ForeColor = Color.Black;
				}

				tbText.Text = CurrentNode.Text;
				tbText.Enabled = true;

				lbOptions.Items.Clear();
				foreach(Option option in CurrentNode.Options) {
					lbOptions.Items.Add(option);
				}
				uiOptionEditor.Option = null;

				btnMoveOptionUp.Enabled = false;
				btnMoveOptionDown.Enabled = false;
			}
		}

		private void lbOptions_SelectedIndexChanged(object sender, EventArgs e) {
			if(uiOptionEditor.Option != lbOptions.SelectedItem) {
				uiOptionEditor.Option = (Option)lbOptions.SelectedItem;

				int Index = lbOptions.Items.IndexOf(lbOptions.SelectedItem);
				if (Index == 0) {
					btnMoveOptionUp.Enabled = false;
				} else {
					btnMoveOptionUp.Enabled = true;
				}

				if (Index == lbOptions.Items.Count - 1) {
					btnMoveOptionDown.Enabled = false;
				} else {
					btnMoveOptionDown.Enabled = true;
				}
			}
		}

		private void uiOptionEditor_OnOptionChanged(object sender, EventArgs e) {
			lbOptions.Refresh();
			tvAdventureNodes.Refresh();
		}

		private void uiOptionEditor_OnStoryNodeChanged(object sender, StoryChangedEventArgs e) {
			tvAdventureNodes.SelectedNode = tvAdventureNodes.GetNode(e.NewStoryNode);
			tvAdventureNodes.SelectedNode.Expand();

			tbText.Focus();
		}

		private void btnStoryNodeAdd_Click(object sender, EventArgs e) {
			CurrentAdventure.RootStoryNodes.Add(new StoryNode());
			tvAdventureNodes.Refresh();
		}

		private void btnStoryNodeRemove_Click(object sender, EventArgs e) {
			if(CurrentAdventure.RootStoryNodes.Contains(tvAdventureNodes.SelectedStoryNode)) {
				CurrentAdventure.RootStoryNodes.Remove(tvAdventureNodes.SelectedStoryNode);
				tvAdventureNodes.Refresh();
			} else {
				MessageBox.Show("Only Root Story Nodes may be Removed");
			}
		}

		private void btnMakeStartingPoint_Click(object sender, EventArgs e) {
			if(tvAdventureNodes.SelectedStoryNode != null) {
				if(tvAdventureNodes.SelectedStoryNode is ReferenceNode) {
					MessageBox.Show("Can not start on a reference node");
				}
				CurrentAdventure.StartingPoint = tvAdventureNodes.SelectedStoryNode;
				tvAdventureNodes.Refresh();
			}
		}

		private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Show all");
		}

		private void btnMoveOptionUp_Click(object sender, EventArgs e)
		{
			if (lbOptions.SelectedItem == null) return;

			int Index = lbOptions.Items.IndexOf(lbOptions.SelectedItem);

			Option higher = CurrentNode.Options[Index - 1];
			Option lower = CurrentNode.Options[Index];

			CurrentNode.Options[Index - 1] = lower;
			CurrentNode.Options[Index] = higher;

			RefreshUI();
			lbOptions.SelectedItem = lower;
		}

		private void btnMoveOptionDown_Click(object sender, EventArgs e)
		{
			if (lbOptions.SelectedItem == null) return;

			int Index = lbOptions.Items.IndexOf(lbOptions.SelectedItem);

			Option higher = CurrentNode.Options[Index];
			Option lower = CurrentNode.Options[Index + 1];

			CurrentNode.Options[Index] = lower;
			CurrentNode.Options[Index + 1] = higher;

			RefreshUI();
			lbOptions.SelectedItem = higher;
		}

		private void adventureToolStripMenuItem_Click(object sender, EventArgs e)
		{
			WorldView view = new WorldView();
			view.StartAdventure(CurrentAdventure);
			view.ShowDialog();
		}
	}
}
