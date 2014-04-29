using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuestInfo;

namespace AdventureMaker {
	public partial class OptionEditor : UserControl {
		public OptionEditor() {
			InitializeComponent();
		}

		private Adventure _adventure;
		public Adventure Adventure {
			get
			{
				return _adventure;
			}
			set
			{
				_adventure = value;
				uiOperationsEditor.Adventure = value;
				uiConditionalEditor.Adventure = value;
			}
		}

		public StoryNode StoryNode {
			get;
			set;
		}

		Option _option;
		public Option Option {
			get {
				return _option;
			}
			set {
				_option = value;
				RebindControls();
			}
		}

		public event EventHandler<EventArgs> OnOptionChanged;
		private void TriggerOnOptionChanged() {
			if(OnOptionChanged != null) {
				OnOptionChanged(this, null);
			}
		}

		public event EventHandler<StoryChangedEventArgs> OnStoryNodeChanged;
		private void TriggerStoryNodeChanged(StoryNode newnode) {
			if(OnStoryNodeChanged != null) {
				OnStoryNodeChanged(this, new StoryChangedEventArgs(newnode));
			}
		}

		bool Updating = false;
		private void RebindControls() {
			Updating = true;

			if(Option == null) {
				tbDescription.Text = "";
				tbDescription.Enabled = false;

				tbStoryNode.Text = "";
				tbStoryNode.Enabled = false;
				tbStoryNode.ForeColor = Color.Black;

				btnGoToNode.Enabled = false;
				btnSelectNode.Enabled = false;
				btnCreateNode.Enabled = false;

				uiConditionalEditor.Conditionals = null;
				uiOperationsEditor.Operations = null;
			} else {
				tbDescription.Text = Option.Description;
				tbDescription.Enabled = true;

				tbStoryNode.Text = Option.Node.Name;
				tbStoryNode.Enabled = true;
				if(Option.Node is ReferenceNode) {
					tbStoryNode.ForeColor = Color.Blue;
				} else {
					tbStoryNode.ForeColor = Color.Black;
				}

				btnGoToNode.Enabled = true;
				btnSelectNode.Enabled = true;
				btnCreateNode.Enabled = Option.Node is ReferenceNode;

				uiConditionalEditor.Conditionals = Option.Conditionals;
				uiOperationsEditor.Operations = Option.OnSelect;
			}
			Updating = false;
		}

		private void tbDescription_TextChanged(object sender, EventArgs e) {
			if (Option == null || Updating) return;

			Option.Description = tbDescription.Text;
			TriggerOnOptionChanged();
		}

		private void btnGoToNode_Click(object sender, EventArgs e) {
			TriggerStoryNodeChanged(Option.Node);
		}

		private void btnSelectNode_Click(object sender, EventArgs e)
		{
			SelectNodeForm snf = new SelectNodeForm();
			snf.Adventure = this.Adventure;
			snf.SelectedNode = this.StoryNode;
			if (snf.ShowDialog() == DialogResult.OK) {
				if (snf.SelectedNode == Option.Node) {
					return; // Same node selected
				}

				Option.Node = new ReferenceNode(snf.SelectedNode);
				this.RebindControls();
				TriggerOnOptionChanged();
			}
		}

		private void btnCreateNode_Click(object sender, EventArgs e)
		{
			if (Option.Node is ReferenceNode) {
				string OldName = Option.Node.Name;
				Option.Node = new StoryNode();
				Option.Node.Name = OldName;
				TriggerOnOptionChanged();
			} else {
				MessageBox.Show("Can only create a new node from a reference node");
			}
		}

		private void tbStoryNode_TextChanged(object sender, EventArgs e) {
			if (Option == null || Updating) return;

			Option.Node.Name = tbStoryNode.Text;
			TriggerOnOptionChanged();
		}

		

		private void tbStoryNode_KeyPress(object sender, KeyPressEventArgs e) {
			if(e.KeyChar == '\r') {
				e.Handled = true;
				btnGoToNode_Click(this, null);
			}
		}

		
	}
}
