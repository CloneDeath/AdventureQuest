using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace QuestInfo
{
	public class Inventory
	{
		public Inventory()
		{
			Items = new Dictionary<string, Item>();
		}

		public Dictionary<string, Item> Items
		{
			get;
			set;
		}

		public Item GetItem(string ItemName)
		{
			if (!Items.ContainsKey(ItemName)) {
				Item temp = new Item();
				temp.Name = ItemName;
				temp.Value = 0;
				temp.Visible = false;
				temp.ValueVisible = false;
				Items.Add(ItemName, temp);
			}
			return Items[ItemName];
		}

		public Item[] GetAll()
		{
			List<Item> ret = new List<Item>();
			foreach (Item item in Items.Values) {
				if (item.Visible) {
					ret.Add(item);
				}
			}
			return ret.ToArray();
		}
	}
}
