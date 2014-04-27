using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestInfo
{
	public enum Comparison
	{
		Equals,
		NotEqualTo,
		GreaterThan,
		GreaterThanOrEqualTo,
		LessThan,
		LessThanOrEqualTo,
	}

	public class InventoryValueComparison
	{
		public string InventoryItem;
		public Comparison ComparisonOperator;
		public int Value;

		public bool Evaluate(Inventory inv)
		{
			Item item = inv.GetItem(InventoryItem);

			switch (ComparisonOperator) {
				case Comparison.Equals:
					return item.Value == Value;
				case Comparison.NotEqualTo:
					return item.Value != Value;
				case Comparison.GreaterThan:
					return item.Value > Value;
				case Comparison.GreaterThanOrEqualTo:
					return item.Value >= Value;
				case Comparison.LessThan:
					return item.Value < Value;
				case Comparison.LessThanOrEqualTo:
					return item.Value <= Value;
			}

			throw new NotImplementedException("The comparison operation '" + ComparisonOperator + "' has not been implemented.");
		}

		public override string ToString()
		{
			return InventoryItem + " " + Enum.GetName(typeof(Comparison), ComparisonOperator) + " " + Value.ToString();
		}
	}
}
