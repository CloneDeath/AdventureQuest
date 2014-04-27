using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;

namespace QuestInfo {
	public class Adventure {
		public StoryNode StartingPoint = new StoryNode();

		public static Adventure Load(string filename) {
			var serializer = new DataContractSerializer(typeof(Adventure), null, 
				0x7FFF /*maxItemsInObjectGraph*/, 
				false /*ignoreExtensionDataObject*/, 
				true /*preserveObjectReferences : this is where the magic happens */, 
				null /*dataContractSurrogate*/);

			using (FileStream file = File.OpenRead(filename)){
				return (Adventure)serializer.ReadObject(file);
			}
		}

		public void Save(string filename)
		{
			var serializer = new DataContractSerializer(this.GetType(), null, 
				0x7FFF /*maxItemsInObjectGraph*/, 
				false /*ignoreExtensionDataObject*/, 
				true /*preserveObjectReferences : this is where the magic happens */, 
				null /*dataContractSurrogate*/);

			using(FileStream file = File.Create(filename)) {
				serializer.WriteObject(file, this);
			}
		}
	}
}
