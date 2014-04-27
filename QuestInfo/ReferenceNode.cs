using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace QuestInfo {
	public class ReferenceNode : StoryNode {
		public StoryNode Reference;
		public ReferenceNode(StoryNode reference) {
			this.Reference = reference;
		}

		[IgnoreDataMember]
		public override string Name {
			get {
				if (Reference == null) return null;
				return Reference.Name;
			}
			set {
				if (Reference == null) return;
				Reference.Name = value;
			}
		}

		[IgnoreDataMember]
		public override string Text {
			get {
				if (Reference == null) return null;
				return Reference.Text;
			}
			set {
				if (Reference == null) return;
				Reference.Text = value;
			}
		}

		[IgnoreDataMember]
		public override List<Option> Options {
			get {
				if (Reference == null) return null;
				return Reference.Options;
			}
			set {
				if (Reference == null) return;
				Reference.Options = value;
			}
		}
	}
}
