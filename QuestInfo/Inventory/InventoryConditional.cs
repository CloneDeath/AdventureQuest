using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestInfo
{
	public enum Conditional
	{
		EqualTo,
		NotEqualTo,
		GreaterThan,
		GreaterThanOrEqualTo,
		LessThan,
		LessThanOrEqualTo,
	}

	public class InventoryConditional
	{
		public string InventoryItem = "Item";
		public Conditional ComparisonOperator = Conditional.EqualTo;
		public int Value = 0;

		public bool Evaluate(Inventory inv)
		{
			Item item = inv.GetItem(InventoryItem);

			switch (ComparisonOperator) {
				case Conditional.EqualTo:
					return item.Value == Value;
				case Conditional.NotEqualTo:
					return item.Value != Value;
				case Conditional.GreaterThan:
					return item.Value > Value;
				case Conditional.GreaterThanOrEqualTo:
					return item.Value >= Value;
				case Conditional.LessThan:
					return item.Value < Value;
				case Conditional.LessThanOrEqualTo:
					return item.Value <= Value;
			}

			throw new NotImplementedException("The comparison operation '" + ComparisonOperator + "' has not been implemented.");
		}

		public override string ToString()
		{
			string ConditionalString = "ERROR";

			switch (ComparisonOperator) {
				case Conditional.EqualTo:
					ConditionalString = "==";
					break;
				case Conditional.NotEqualTo:
					ConditionalString = "!=";
					break;
				case Conditional.GreaterThan:
					ConditionalString = ">";
					break;
				case Conditional.GreaterThanOrEqualTo:
					ConditionalString = ">=";
					break;
				case Conditional.LessThan:
					ConditionalString = "<";
					break;
				case Conditional.LessThanOrEqualTo:
					ConditionalString = "<=";
					break;
			}
			return InventoryItem + " " + ConditionalString + " " + Value.ToString();
		}
	}
}
