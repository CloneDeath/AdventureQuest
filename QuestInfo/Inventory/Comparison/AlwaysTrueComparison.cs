using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestInfo
{
	public class AlwaysTrueComparison : IInventoryComparison
	{
		public bool Evaluate(Inventory inv)
		{
			return true;
		}

		public override string ToString()
		{
			return "Always True";
		}
	}
}
