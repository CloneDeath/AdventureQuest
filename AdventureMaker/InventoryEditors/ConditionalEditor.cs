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
	public partial class ConditionalEditor : UserControl
	{
		public ConditionalEditor()
		{
			InitializeComponent();

			this.cbConditionalType.DisplayMember = "Text";
			this.cbConditionalType.ValueMember = "Value";

			object[] items = new[] {
				new { Text="Equal To", Value=Conditional.EqualTo },
				new { Text="Not Equal To", Value=Conditional.NotEqualTo },
				new { Text="Greater Than", Value=Conditional.GreaterThan },
				new { Text="Greater Than or Equal To", Value=Conditional.GreaterThanOrEqualTo },
				new { Text="Less Than", Value=Conditional.LessThan },
				new { Text="Less Than or Equal To", Value=Conditional.LessThanOrEqualTo },
			};
			cbConditionalType.DataSource = items;
		}

		public Adventure Adventure { get; set; }

		List<InventoryConditional> _conditionals;
		public List<InventoryConditional> Conditionals
		{
			get
			{
				return _conditionals;
			}
			set
			{
				_conditionals = value;
				UpdateUI();
			}
		}

		private InventoryConditional SelectedConditional
		{
			get
			{
				return (InventoryConditional)lbConditionals.SelectedItem;
			}
			set
			{
				lbConditionals.SelectedItem = value;
			}
		}

		bool Updating = false;
		private void UpdateUI()
		{
			Updating = true;

			InventoryConditional previous = SelectedConditional;
			lbConditionals.Items.Clear();
			if (Conditionals == null) {
				btnAdd.Enabled = false;
				btnRemove.Enabled = false;
			} else {
				btnAdd.Enabled = true;
				btnRemove.Enabled = true;

				lbConditionals.Items.AddRange(Conditionals.ToArray());

				if (previous != null && lbConditionals.Items.Contains(previous)) {
					lbConditionals.SelectedItem = previous;
				}
			}

			if (SelectedConditional == null) {
				cbItemName.Text = "";
				cbItemName.Enabled = false;

				cbConditionalType.SelectedItem = null;
				cbConditionalType.Enabled = false;

				nudValue.Value = 0;
				nudValue.Enabled = false;
			} else {
				cbItemName.Text = SelectedConditional.InventoryItem;
				cbItemName.Enabled = true;

				cbConditionalType.SelectedValue = SelectedConditional.ComparisonOperator;
				cbConditionalType.Enabled = true;

				nudValue.Value = SelectedConditional.Value;
				nudValue.Enabled = true;
			}

			Updating = false;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (Conditionals == null) return;

			InventoryConditional cond = new InventoryConditional();
			Conditionals.Add(cond);
			UpdateUI();
			SelectedConditional = cond;
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (Conditionals == null || SelectedConditional == null) return;

			Conditionals.Remove(SelectedConditional);
			UpdateUI();
		}

		private void lbConditionals_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Updating) return;

			UpdateUI();
		}

		private void cbItemName_TextChanged(object sender, EventArgs e)
		{
			if (SelectedConditional == null || Updating) return;

			SelectedConditional.InventoryItem = cbItemName.Text;
			lbConditionals.Refresh();
		}

		private void cbConditionalType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (SelectedConditional == null || Updating) return;

			SelectedConditional.ComparisonOperator = (Conditional)cbConditionalType.SelectedValue;
			lbConditionals.Refresh();
		}

		private void nudValue_ValueChanged(object sender, EventArgs e)
		{
			if (SelectedConditional == null || Updating) return;

			SelectedConditional.Value = (int)nudValue.Value;
			lbConditionals.Refresh();
		}

		private void cbItemName_DropDown(object sender, EventArgs e)
		{
			cbItemName.Items.Clear();
			cbItemName.Items.AddRange(Adventure.GetItemNames());
		}

		
	}
}
