using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace QuestInfo {
	[DataContract]
	public class Option {
		[DataMember]
		public string Description = "Choice";

		[DataMember]
		public StoryNode Node = new StoryNode();

		[DataMember]
		public IInventoryComparison Comparison = new AlwaysTrueComparison();

		[DataMember]
		public List<IInventoryOperation> OnSelect = new List<IInventoryOperation>();

		public override string ToString() {
			return "'" + Description + "' - " + Node.Name;
		}
	}
}
