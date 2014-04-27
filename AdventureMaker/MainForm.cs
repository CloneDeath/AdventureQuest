using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuestInfo;

namespace AdventureMaker {
	public partial class MainForm : Form {
		public Adventure CurrentAdventure;

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
			newToolStripMenuItem_Click(this, null);
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e) {
			CurrentAdventure = new Adventure();
			CurrentAdventureChanged();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "QuestInfo (*.qi)|*.qi|All Files (*.*)|*.*";
			if(sfd.ShowDialog() == DialogResult.OK) {
				CurrentAdventure.Save(sfd.FileName);
			}
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "QuestInfo (*.qi)|*.qi|All Files (*.*)|*.*";
			ofd.Multiselect = false;
			if(ofd.ShowDialog() == DialogResult.OK) {
				CurrentAdventure = Adventure.Load(ofd.FileName);
				CurrentAdventureChanged();
			}
		}

		private void CurrentAdventureChanged() {
			tvAdventureNodes.Adventure = this.CurrentAdventure;
			uiOptionEditor.Adventure = this.CurrentAdventure;
			RefreshUI();
		}

		

		private void tvAdventureNodes_AfterSelect(object sender, TreeViewEventArgs e) {
			if(tvAdventureNodes.SelectedStoryNode is ReferenceNode) {
				tvAdventureNodes.SelectedStoryNode = ((ReferenceNode)tvAdventureNodes.SelectedStoryNode).Reference;
			}

			uiOptionEditor.StoryNode = tvAdventureNodes.SelectedStoryNode;
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
			CurrentNode.Options.Remove(selectednode);

			tvAdventureNodes.Refresh();
			RefreshUI();
		}

		private void RefreshUI() {
			if(CurrentNode == null) {
				tbName.Text = "";
				tbName.Enabled = false;

				tbText.Text = "";
				tbText.Enabled = false;

				lbOptions.Items.Clear();
				uiOptionEditor.Option = null;
			} else {
				tbName.Text = CurrentNode.Name;
				tbName.Enabled = true;

				tbText.Text = CurrentNode.Text;
				tbText.Enabled = true;

				lbOptions.Items.Clear();
				foreach(Option option in CurrentNode.Options) {
					lbOptions.Items.Add(option);
				}
				uiOptionEditor.Option = null;
			}
		}

		private void lbOptions_SelectedIndexChanged(object sender, EventArgs e) {
			if(uiOptionEditor.Option != lbOptions.SelectedItem) {
				uiOptionEditor.Option = (Option)lbOptions.SelectedItem;
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
	}
}
