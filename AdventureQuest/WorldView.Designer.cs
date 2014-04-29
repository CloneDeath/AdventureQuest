namespace AdventureQuest {
	partial class WorldView {
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.adventureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tbText = new System.Windows.Forms.TextBox();
			this.flpOptions = new System.Windows.Forms.FlowLayoutPanel();
			this.lbInventory = new System.Windows.Forms.ListBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adventureToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(698, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// adventureToolStripMenuItem
			// 
			this.adventureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewToolStripMenuItem});
			this.adventureToolStripMenuItem.Name = "adventureToolStripMenuItem";
			this.adventureToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
			this.adventureToolStripMenuItem.Text = "Adventure";
			// 
			// startNewToolStripMenuItem
			// 
			this.startNewToolStripMenuItem.Name = "startNewToolStripMenuItem";
			this.startNewToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.startNewToolStripMenuItem.Text = "Start New...";
			this.startNewToolStripMenuItem.Click += new System.EventHandler(this.startNewToolStripMenuItem_Click);
			// 
			// tbText
			// 
			this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbText.Location = new System.Drawing.Point(13, 27);
			this.tbText.Multiline = true;
			this.tbText.Name = "tbText";
			this.tbText.ReadOnly = true;
			this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbText.Size = new System.Drawing.Size(514, 396);
			this.tbText.TabIndex = 2;
			// 
			// flpOptions
			// 
			this.flpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.flpOptions.Location = new System.Drawing.Point(13, 430);
			this.flpOptions.Name = "flpOptions";
			this.flpOptions.Size = new System.Drawing.Size(673, 77);
			this.flpOptions.TabIndex = 3;
			// 
			// lbInventory
			// 
			this.lbInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lbInventory.FormattingEnabled = true;
			this.lbInventory.Location = new System.Drawing.Point(534, 28);
			this.lbInventory.Name = "lbInventory";
			this.lbInventory.Size = new System.Drawing.Size(152, 394);
			this.lbInventory.TabIndex = 4;
			// 
			// WorldView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(698, 519);
			this.Controls.Add(this.lbInventory);
			this.Controls.Add(this.flpOptions);
			this.Controls.Add(this.tbText);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "WorldView";
			this.Text = "Adventure Quest";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem adventureToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startNewToolStripMenuItem;
		private System.Windows.Forms.TextBox tbText;
		private System.Windows.Forms.FlowLayoutPanel flpOptions;
		private System.Windows.Forms.ListBox lbInventory;
	}
}

