using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestInfo {
	public class Option {
		public Option(StoryNode parent) {
			this.Parent = parent;
		}
		public string Description = "Choice";
		public StoryNode Node = new StoryNode();
		public StoryNode Parent;

		public override string ToString() {
			return "'" + Description + "' - " + Node.Name;
		}
	}
}
