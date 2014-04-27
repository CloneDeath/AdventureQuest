namespace AdventureMaker {
	partial class SelectNodeForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tvAdventure = new AdventureMaker.AdventureTreeView();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnExpandAll = new System.Windows.Forms.Button();
			this.btnCollapseAll = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tvAdventure
			// 
			this.tvAdventure.Adventure = null;
			this.tvAdventure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tvAdventure.Location = new System.Drawing.Point(12, 42);
			this.tvAdventure.Name = "tvAdventure";
			this.tvAdventure.SelectedStoryNode = null;
			this.tvAdventure.Size = new System.Drawing.Size(246, 313);
			this.tvAdventure.TabIndex = 0;
			this.tvAdventure.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAdventure_AfterSelect);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(183, 367);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(102, 367);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnExpandAll
			// 
			this.btnExpandAll.Location = new System.Drawing.Point(13, 13);
			this.btnExpandAll.Name = "btnExpandAll";
			this.btnExpandAll.Size = new System.Drawing.Size(75, 23);
			this.btnExpandAll.TabIndex = 3;
			this.btnExpandAll.Text = "Expand All";
			this.btnExpandAll.UseVisualStyleBackColor = true;
			this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
			// 
			// btnCollapseAll
			// 
			this.btnCollapseAll.Location = new System.Drawing.Point(183, 12);
			this.btnCollapseAll.Name = "btnCollapseAll";
			this.btnCollapseAll.Size = new System.Drawing.Size(75, 23);
			this.btnCollapseAll.TabIndex = 4;
			this.btnCollapseAll.Text = "Collapse All";
			this.btnCollapseAll.UseVisualStyleBackColor = true;
			this.btnCollapseAll.Click += new System.EventHandler(this.btnCollapseAll_Click);
			// 
			// SelectNodeForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(270, 402);
			this.Controls.Add(this.btnCollapseAll);
			this.Controls.Add(this.btnExpandAll);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.tvAdventure);
			this.Name = "SelectNodeForm";
			this.Text = "Select Node Form";
			this.ResumeLayout(false);

		}

		#endregion

		private AdventureTreeView tvAdventure;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnExpandAll;
		private System.Windows.Forms.Button btnCollapseAll;
	}
}