using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuestInfo;
using System.Windows.Forms;

namespace AdventureMaker.ConditionalEditors
{
	class ComparisonTreeView : TreeView
	{
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
			if (Comparison == null) {
				this.Nodes.Clear();
				return;
			}

			if (this.Nodes.Count == 0) {
				this.Nodes.Add(CreateComparisonTreeNode(Comparison));
			} else {
				BindData(this.Nodes[0], Comparison);
			}
			this.ExpandAll();
		}

		private TreeNode CreateComparisonTreeNode(IInventoryComparison Comparison)
		{
			TreeNode node = new TreeNode();
			BindData(node, Comparison);
			return node;
		}

		private void BindData(TreeNode node, IInventoryComparison Comparison)
		{
			node.Tag = Comparison;
			node.Text = Comparison.ToString();

			if (Comparison is InventoryComparisonGroup) {
				InventoryComparisonGroup group = Comparison as InventoryComparisonGroup;

				node.Nodes.Clear();
				foreach (IInventoryComparison child in group.Children) {
					node.Nodes.Add(CreateComparisonTreeNode(child));
				}
			}
		}
	}
}
