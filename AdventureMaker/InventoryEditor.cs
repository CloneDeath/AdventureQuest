using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuestInfo;

namespace AdventureMaker
{
	public partial class InventoryEditor : Form
	{
		public InventoryEditor()
		{
			InitializeComponent();
		}

		public Inventory Inventory
		{
			get;
			set;
		}

		Adventure _adventure;
		public Adventure Adventure
		{
			get
			{
				return _adventure;
			}
			set
			{
				_adventure = value;

				Inventory = new QuestInfo.Inventory();

				foreach (string itemname in _adventure.GetItemNames()) {
					Inventory.GetItem(itemname).Value = 0;
				}

				pgItems.SelectedObject = Inventory.Items;
				pgItems.Refresh();
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
