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
		public List<InventoryConditional> Comparison = new List<InventoryConditional>();

		[DataMember]
		public List<InventoryOperation> OnSelect = new List<InventoryOperation>();

		public override string ToString() {
			return "'" + Description + "' - " + Node.Name;
		}
	}
}
