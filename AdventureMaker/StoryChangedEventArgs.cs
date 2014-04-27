using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuestInfo;

namespace AdventureMaker {
	public class StoryChangedEventArgs : EventArgs {
		public StoryNode NewStoryNode {
			get;
			private set;
		}

		public StoryChangedEventArgs(StoryNode node) {
			this.NewStoryNode = node;
		}
	}
}
