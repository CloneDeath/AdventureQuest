using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdventureMaker {
	class RefreshListBox : ListBox {
		public override void Refresh() {
			base.RefreshItems();
			base.Refresh();
		}

		protected override void OnSelectedValueChanged(EventArgs e) {
			base.OnSelectedValueChanged(e);
		}
	}
}
