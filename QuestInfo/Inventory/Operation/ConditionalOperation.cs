using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestInfo
{
	public class ConditionalOperation : IInventoryOperation
	{
		public IInventoryComparison Conditional = new AlwaysTrueComparison();
		public List<IInventoryOperation> Operations = new List<IInventoryOperation>();

		public void Resolve(Inventory inv)
		{
			if (Conditional.Evaluate(inv)) {
				foreach (InventoryOperation op in Operations) {
					op.Resolve(inv);
				}
			}
		}
	}
}
