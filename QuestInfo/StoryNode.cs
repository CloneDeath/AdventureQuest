using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace QuestInfo {
	[DataContract]
	public class StoryNode {
		public StoryNode() {
			this.Name = "Story Node";
			this.Text = "";
			this.Options = new List<Option>();
		}

		[DataMember]
		public virtual string Name {
			get;
			set;
		}

		[DataMember]
		public virtual string Text {
			get;
			set;
		}

		[DataMember]
		public virtual List<Option> Options {
			get;
			set;
		}
	}
}
