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
		}

		IInventoryComparison _comparison;
		public IInventoryComparison Comparison
		{
			get
			{
				return _comparison;
			}
			set
			{
				_comparison = value;
				UpdateUI();
			}
		}

		private void UpdateUI()
		{
			tvComparisonTree.Comparison = Comparison;

			if (Comparison == null) {
				btnAdd.Enabled = false;
				btnRemove.Enabled = false;
			} else {
				btnAdd.Enabled = true;
				btnRemove.Enabled = true;
			}
		}
	}
}
