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

		Inventory Items = new Inventory();

		public WorldView() {
			InitializeComponent();
		}

		private void startNewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "QuestInfo (*.qi)|*.qi|All Files (*.*)|*.*";
			ofd.Multiselect = false;
			if (ofd.ShowDialog() == DialogResult.OK) {
				Items = new Inventory();
				Adventure = Adventure.Load(ofd.FileName);
				
				EnterStoryNode(Adventure.StartingPoint);
				RefreshUI();
			}
		}

		private void EnterStoryNode(StoryNode node)
		{
			CurrentNode = node;
			node.Selected(Items);
		}

		private void RefreshUI()
		{
			tbText.Text = CurrentNode.Text;

			flpOptions.Controls.Clear();
			foreach (Option option in CurrentNode.Options) {
				if (option.CanChoose(Items)) {
					Button btn = new Button();
					btn.Text = option.Description;
					btn.Tag = option;
					btn.Click += new EventHandler(OptionButton_Click);
					btn.AutoSize = true;
					if (btn.Width < 100) btn.Width = 100;
					flpOptions.Controls.Add(btn);
				}
			}

			lbInventory.Items.Clear();
			lbInventory.Items.AddRange(Items.GetAll());
		}

		void OptionButton_Click(object sender, EventArgs e)
		{
			Option ChosenOption = (Option)((Button)sender).Tag;
			EnterStoryNode(ChosenOption.Node);
			ChosenOption.Selected(Items);
			RefreshUI();
		}
	}
}
