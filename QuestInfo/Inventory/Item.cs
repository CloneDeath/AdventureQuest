using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestInfo
{
	public class Item
	{
		public string Name
		{
			get;
			internal set;
		}

		public int Value
		{
			get;
			set;
		}

		public bool Visible { get; set; }
		public bool ValueVisible { get; set; }
	}
}
