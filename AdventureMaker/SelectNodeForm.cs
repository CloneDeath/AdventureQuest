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
	public partial class SelectNodeForm : Form {
		public SelectNodeForm() {
			InitializeComponent();
		}

		public Adventure Adventure {
			get {
				return tvAdventure.Adventure;
			}
			set {
				tvAdventure.Adventure = value;
			}
		}

		public StoryNode SelectedNode {
			get {
				return tvAdventure.SelectedStoryNode;
			}
			set {
				tvAdventure.SelectedStoryNode = value;
			}
		}

		private void btnOK_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void tvAdventure_AfterSelect(object sender, TreeViewEventArgs e) {
			if(SelectedNode == null || SelectedNode is ReferenceNode) {
				btnOK.Enabled = false;
			} else {
				btnOK.Enabled = true;
			}
		}
	}
}
