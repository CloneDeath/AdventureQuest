using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestInfo {
	public class StoryNode {
		public StoryNode() {
			this.Name = "Story Node";
			this.Text = "";
			this.Options = new List<Option>();
		}

		public virtual string Name {
			get;
			set;
		}
		public virtual string Text {
			get;
			set;
		}
		public virtual List<Option> Options {
			get;
			set;
		}
	}
}
