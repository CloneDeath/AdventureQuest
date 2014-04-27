﻿namespace AdventureMaker {
	partial class MainForm {
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
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tvAdventureNodes = new AdventureMaker.AdventureTreeView();
			this.lblName = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.lblText = new System.Windows.Forms.Label();
			this.tbText = new System.Windows.Forms.TextBox();
			this.lblOptions = new System.Windows.Forms.Label();
			this.btnAddOption = new System.Windows.Forms.Button();
			this.btnDeleteOption = new System.Windows.Forms.Button();
			this.lbOptions = new AdventureMaker.RefreshListBox();
			this.uiOptionEditor = new AdventureMaker.OptionEditor();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(822, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.loadToolStripMenuItem.Text = "Load";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// tvAdventureNodes
			// 
			this.tvAdventureNodes.Adventure = null;
			this.tvAdventureNodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.tvAdventureNodes.HideSelection = false;
			this.tvAdventureNodes.Location = new System.Drawing.Point(13, 28);
			this.tvAdventureNodes.Name = "tvAdventureNodes";
			this.tvAdventureNodes.Size = new System.Drawing.Size(264, 426);
			this.tvAdventureNodes.TabIndex = 1;
			this.tvAdventureNodes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAdventureNodes_AfterSelect);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(283, 31);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(38, 13);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "Name:";
			// 
			// tbName
			// 
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbName.Location = new System.Drawing.Point(329, 28);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(481, 20);
			this.tbName.TabIndex = 3;
			this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
			// 
			// lblText
			// 
			this.lblText.AutoSize = true;
			this.lblText.Location = new System.Drawing.Point(283, 51);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(31, 13);
			this.lblText.TabIndex = 4;
			this.lblText.Text = "Text:";
			// 
			// tbText
			// 
			this.tbText.AcceptsReturn = true;
			this.tbText.AcceptsTab = true;
			this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbText.Location = new System.Drawing.Point(286, 67);
			this.tbText.Multiline = true;
			this.tbText.Name = "tbText";
			this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbText.Size = new System.Drawing.Size(524, 215);
			this.tbText.TabIndex = 5;
			this.tbText.TextChanged += new System.EventHandler(this.tbText_TextChanged);
			// 
			// lblOptions
			// 
			this.lblOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblOptions.AutoSize = true;
			this.lblOptions.Location = new System.Drawing.Point(283, 285);
			this.lblOptions.Name = "lblOptions";
			this.lblOptions.Size = new System.Drawing.Size(46, 13);
			this.lblOptions.TabIndex = 6;
			this.lblOptions.Text = "Options:";
			// 
			// btnAddOption
			// 
			this.btnAddOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddOption.Location = new System.Drawing.Point(557, 301);
			this.btnAddOption.Name = "btnAddOption";
			this.btnAddOption.Size = new System.Drawing.Size(88, 23);
			this.btnAddOption.TabIndex = 8;
			this.btnAddOption.Text = "Add New";
			this.btnAddOption.UseVisualStyleBackColor = true;
			this.btnAddOption.Click += new System.EventHandler(this.btnAddOption_Click);
			// 
			// btnDeleteOption
			// 
			this.btnDeleteOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteOption.Location = new System.Drawing.Point(722, 301);
			this.btnDeleteOption.Name = "btnDeleteOption";
			this.btnDeleteOption.Size = new System.Drawing.Size(88, 23);
			this.btnDeleteOption.TabIndex = 9;
			this.btnDeleteOption.Text = "Delete Current";
			this.btnDeleteOption.UseVisualStyleBackColor = true;
			this.btnDeleteOption.Click += new System.EventHandler(this.btnDeleteOption_Click);
			// 
			// lbOptions
			// 
			this.lbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbOptions.FormattingEnabled = true;
			this.lbOptions.Location = new System.Drawing.Point(286, 307);
			this.lbOptions.Name = "lbOptions";
			this.lbOptions.Size = new System.Drawing.Size(265, 147);
			this.lbOptions.TabIndex = 11;
			this.lbOptions.SelectedIndexChanged += new System.EventHandler(this.lbOptions_SelectedIndexChanged);
			// 
			// uiOptionEditor
			// 
			this.uiOptionEditor.Adventure = null;
			this.uiOptionEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.uiOptionEditor.Location = new System.Drawing.Point(557, 330);
			this.uiOptionEditor.Name = "uiOptionEditor";
			this.uiOptionEditor.Option = null;
			this.uiOptionEditor.Size = new System.Drawing.Size(253, 124);
			this.uiOptionEditor.TabIndex = 10;
			this.uiOptionEditor.OnOptionChanged += new System.EventHandler<System.EventArgs>(this.uiOptionEditor_OnOptionChanged);
			this.uiOptionEditor.OnStoryNodeChanged += new System.EventHandler<AdventureMaker.StoryChangedEventArgs>(this.uiOptionEditor_OnStoryNodeChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 466);
			this.Controls.Add(this.lbOptions);
			this.Controls.Add(this.uiOptionEditor);
			this.Controls.Add(this.btnDeleteOption);
			this.Controls.Add(this.btnAddOption);
			this.Controls.Add(this.lblOptions);
			this.Controls.Add(this.tbText);
			this.Controls.Add(this.lblText);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.tvAdventureNodes);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Adventure Maker";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private AdventureTreeView tvAdventureNodes;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.TextBox tbText;
		private System.Windows.Forms.Label lblOptions;
		private System.Windows.Forms.Button btnAddOption;
		private System.Windows.Forms.Button btnDeleteOption;
		private OptionEditor uiOptionEditor;
		private RefreshListBox lbOptions;
	}
}

