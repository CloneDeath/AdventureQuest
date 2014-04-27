using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestInfo
{
	public enum Operation
	{
		Add,
		Subtract,
		Set,
		MakeVisible,
		MakeValueVisible,
	}

	public class InventoryOperation : IInventoryOperation
	{
		public string ItemName;
		public Operation Operation;
		public int Value;

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
				case Operation.MakeValueVisible:
					item.ValueVisible = true;
					item.Visible = true;
					break;
			}
		}
	}
}
