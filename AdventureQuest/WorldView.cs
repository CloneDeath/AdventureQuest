using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuestInfo;

namespace AdventureQuest {
	public partial class WorldView : Form {
		Adventure Adventure;

		StoryNode CurrentNode;

		public WorldView() {
			InitializeComponent();
		}

		private void startNewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "QuestInfo (*.qi)|*.qi|All Files (*.*)|*.*";
			ofd.Multiselect = false;
			if (ofd.ShowDialog() == DialogResult.OK) {
				Adventure = Adventure.Load(ofd.FileName);
				CurrentNode = Adventure.StartingPoint;
				RefreshUI();
			}
		}

		private void RefreshUI()
		{
			lblNodeName.Text = CurrentNode.Name;
			tbText.Text = CurrentNode.Text;

			flpOptions.Controls.Clear();
			foreach (Option option in CurrentNode.Options) {
				Button btn = new Button();
				btn.Text = option.Description;
				btn.Tag = option;
				btn.Click += new EventHandler(OptionButton_Click);
				btn.AutoSize = true;
				if (btn.Width < 100) btn.Width = 100;
				flpOptions.Controls.Add(btn);
			}
		}

		void OptionButton_Click(object sender, EventArgs e)
		{
			CurrentNode = ((Option)((Button)sender).Tag).Node;
			RefreshUI();
		}
	}
}
