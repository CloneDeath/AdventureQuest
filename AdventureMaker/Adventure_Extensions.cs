using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestInfo
{
	static class Adventure_Extensions
	{
		public static string[] GetItemNames(this Adventure self)
		{
			List<string> ItemNames = new List<string>();

			foreach (StoryNode node in self.RootStoryNodes) {
				GetItemNames(node, ref ItemNames);	
			}

			return ItemNames.OrderBy(n => n).ToArray();
		}

		private static void GetItemNames(StoryNode node, ref List<string> Names)
		{
			foreach (InventoryOperation operation in node.OnEnter) {
				if (!Names.Contains(operation.ItemName)) {
					Names.Add(operation.ItemName);
				}
			}

			foreach (Option opt in node.Options) {
				foreach (InventoryOperation operation in opt.OnSelect) {
					if (!Names.Contains(operation.ItemName)) {
						Names.Add(operation.ItemName);
					}
				}

				foreach (InventoryConditional conditional in opt.Conditionals) {
					if (!Names.Contains(conditional.InventoryItem)) {
						Names.Add(conditional.InventoryItem);
					}
				}

				if (!(opt.Node is ReferenceNode)) {
					GetItemNames(opt.Node, ref Names);
				}
			}
		}
	}
}
