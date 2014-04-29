using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuestInfo;
using System.Runtime.InteropServices;

namespace AdventureQuest {
	public partial class WorldView : Form {
		Adventure Adventure;

		StoryNode CurrentNode;

		public Inventory Items;

		public WorldView() {
			InitializeComponent();
			Items = new Inventory();
		}

		private void startNewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "QuestInfo (*.qi)|*.qi|All Files (*.*)|*.*";
			ofd.Multiselect = false;
			if (ofd.ShowDialog() == DialogResult.OK) {
				Adventure adv = Adventure.Load(ofd.FileName);
				StartAdventure(adv);
			}
		}

		public void StartAdventure(Adventure adventure)
		{
			Items = new Inventory();
			Adventure = adventure;
			EnterStoryNode(Adventure.StartingPoint);
			RefreshUI();
		}

		public void EnterStoryNode(StoryNode node)
		{
			CurrentNode = node;
			node.Selected(Items);
		}

		public void RefreshUI()
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
			tbText.Select(0, 0);
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
