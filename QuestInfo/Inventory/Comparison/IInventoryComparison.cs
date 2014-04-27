using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestInfo
{
	public interface IInventoryComparison
	{
		bool Evaluate(Inventory inv);
	}
}
