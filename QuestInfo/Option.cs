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
		public List<InventoryConditional> Conditionals = new List<InventoryConditional>();

		[DataMember]
		public List<InventoryOperation> OnSelect = new List<InventoryOperation>();

		public override string ToString() {
			return "'" + Description + "' - " + Node.Name;
		}

		public bool CanChoose(Inventory current_inventory){
			foreach (InventoryConditional conditional in Conditionals) {
				if (!conditional.Evaluate(current_inventory)) {
					return false;
				}
			}
			return true;
		}

		public void Selected(Inventory current_inventory)
		{
			foreach(InventoryOperation operation in OnSelect) {
				operation.Resolve(current_inventory);
			}
		}
	}
}
