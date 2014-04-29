using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuestInfo;

namespace AdventureMaker
{
	public partial class OperationsEditor : UserControl
	{
		public OperationsEditor()
		{
			InitializeComponent();

			this.cbOperationType.DisplayMember = "Text";
			this.cbOperationType.ValueMember = "Value";

			object[] items = new[] {
				new { Text="Set", Value=Operation.Set },
				new { Text="Add", Value=Operation.Add },
				new { Text="Subtract", Value=Operation.Subtract },
				new { Text="Make Visible", Value=Operation.MakeVisible },
				new { Text="Make Invisible", Value=Operation.MakeInvisible },
				new { Text="Make Amount Visible", Value=Operation.MakeValueVisible },
				new { Text="Make Amount Invisible", Value=Operation.MakeValueInvisible },
			};
			cbOperationType.DataSource = items;
		}

		List<InventoryOperation> _operations;
		public List<InventoryOperation> Operations
		{
			get
			{
				return _operations;
			}
			set
			{
				_operations = value;
				UpdateUI();
			}
		}

		private InventoryOperation SelectedOperation
		{
			get
			{
				return (InventoryOperation)lbOperations.SelectedItem;
			}
		}

		bool Updating = false;
		private void UpdateUI()
		{
			Updating = true;

			InventoryOperation previous = SelectedOperation;
			lbOperations.Items.Clear();
			if (Operations == null) {
				btnAdd.Enabled = false;
				btnRemove.Enabled = false;
			} else {
				btnAdd.Enabled = true;
				btnRemove.Enabled = true;

				lbOperations.Items.AddRange(Operations.ToArray());

				if (previous != null && lbOperations.Items.Contains(previous)) {
					lbOperations.SelectedItem = previous;
				}
			}

			if (SelectedOperation == null) {
				tbItemName.Text = "";
				tbItemName.Enabled = false;

				cbOperationType.SelectedItem = null;
				cbOperationType.Enabled = false;

				nudValue.Value = 0;
				nudValue.Enabled = false;
			} else {
				tbItemName.Text = SelectedOperation.ItemName;
				tbItemName.Enabled = true;

				cbOperationType.SelectedValue = SelectedOperation.Operation;
				cbOperationType.Enabled = true;

				nudValue.Value = SelectedOperation.Value;
				if (SelectedOperation.Operation == Operation.Add ||
					SelectedOperation.Operation == Operation.Set ||
					SelectedOperation.Operation == Operation.Subtract) {

					nudValue.Enabled = true;
				} else {
					nudValue.Enabled = false;
				}

				
			}

			Updating = false;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (Operations == null) return;

			Operations.Add(new InventoryOperation());
			UpdateUI();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (Operations == null || SelectedOperation == null) return;

			Operations.Remove(SelectedOperation);
			UpdateUI();
		}

		private void lbOperations_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Updating) return;

			UpdateUI();
		}

		private void tbItemName_TextChanged(object sender, EventArgs e)
		{
			if (SelectedOperation == null || Updating) return;

			SelectedOperation.ItemName = tbItemName.Text;
			lbOperations.Refresh();
		}

		private void cbOperationType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (SelectedOperation == null || Updating) return;

			SelectedOperation.Operation = (Operation)cbOperationType.SelectedValue;
			lbOperations.Refresh();
		}

		private void nudValue_ValueChanged(object sender, EventArgs e)
		{
			if (SelectedOperation == null || Updating) return;

			SelectedOperation.Value = (int)nudValue.Value;
			lbOperations.Refresh();
		}
	}
}
