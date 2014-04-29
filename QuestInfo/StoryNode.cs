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
			this.OnEnter = new List<InventoryOperation>();
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

		[DataMember]
		public virtual List<InventoryOperation> OnEnter
		{
			get;
			set;
		}

		public void Selected(Inventory current_inventory)
		{
			foreach (InventoryOperation operation in OnEnter) {
				operation.Resolve(current_inventory);
			}
		}
	}
}
