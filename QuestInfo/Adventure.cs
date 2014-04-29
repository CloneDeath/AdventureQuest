using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;

namespace QuestInfo {
	[DataContract]
	public class Adventure {
		[DataMember]
		public StoryNode StartingPoint = null;

		[DataMember]
		public List<StoryNode> RootStoryNodes = new List<StoryNode>();

		[IgnoreDataMember]
		private static DataContractSerializer serializer = new DataContractSerializer(typeof(Adventure),
				new List<Type>() {
					typeof(ReferenceNode),
				},
				0x7FFF /*maxItemsInObjectGraph*/,
				false /*ignoreExtensionDataObject*/,
				true /*preserveObjectReferences : this is where the magic happens */,
				null /*dataContractSurrogate*/);

		public static Adventure Load(string filename) {
			using (FileStream file = File.OpenRead(filename)){
				return (Adventure)serializer.ReadObject(file);
			}
		}

		public void Save(string filename)
		{
			using(FileStream file = File.Create(filename)) {
				serializer.WriteObject(file, this);
			}
		}
	}
}
