using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestInfo
{
	public enum ComparisonGroup
	{
		And,
		Or
	}

	public class InventoryComparisonGroup : IInventoryComparison
	{
		public ComparisonGroup GroupType = ComparisonGroup.And;
		public List<IInventoryComparison> Children = new List<IInventoryComparison>();

		public bool Evaluate(Inventory inv)
		{
			switch (GroupType) {
				case ComparisonGroup.And:
					foreach (IInventoryComparison child in Children) {
						if (child.Evaluate(inv) == false) {
							return false;
						}
					}
					return true;
				case ComparisonGroup.Or:
					foreach (IInventoryComparison child in Children) {
						if (child.Evaluate(inv) == true) {
							return true;
						}
					}
					return false;
			}

			throw new NotImplementedException("Group type '" + GroupType + "' is not implemented");
		}

		public override string ToString()
		{
			return Enum.GetName(typeof(ComparisonGroup), GroupType);
		}
	}
}
