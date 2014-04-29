using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestInfo
{
	public enum Operation
	{
		Set,
		Add,
		Subtract,
		MakeVisible,
		MakeInvisible,
		MakeValueVisible,
		MakeValueInvisible,
	}

	public class InventoryOperation
	{
		public string ItemName = "Item";
		public Operation Operation = Operation.Set;
		public int Value = 0;

		public void Resolve(Inventory inventory)
		{
			Item item = inventory.GetItem(ItemName);

			switch (Operation) {
				case Operation.Add:
					item.Value += Value;
					break;
				case Operation.Subtract:
					item.Value -= Value;
					break;
				case Operation.Set:
					item.Value = Value;
					break;
				case Operation.MakeVisible:
					item.Visible = true;
					break;
				case Operation.MakeInvisible:
					item.Visible = false;
					break;
				case Operation.MakeValueVisible:
					item.ValueVisible = true;
					break;
				case Operation.MakeValueInvisible:
					item.ValueVisible = false;
					break;
			}
		}

		public override string ToString()
		{
			switch (Operation) {
				case Operation.Add:
					return ItemName + " += " + Value;
				case Operation.Subtract:
					return ItemName + " -= " + Value;
				case Operation.Set:
					return ItemName + " = " + Value;
				case Operation.MakeVisible:
					return "Make " + ItemName + " Visible";
				case Operation.MakeInvisible:
					return "Make " + ItemName + " Invisible";
				case Operation.MakeValueVisible:
					return "Make " + ItemName + " Amount Visible";
				case Operation.MakeValueInvisible:
					return "Make " + ItemName + " Amount Invisible";
			}

			throw new NotImplementedException();
		}
	}
}
