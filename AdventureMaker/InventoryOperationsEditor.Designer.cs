namespace AdventureMaker
{
	partial class InventoryOperationsEditor
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.lblItemName = new System.Windows.Forms.Label();
			this.tbItemName = new System.Windows.Forms.TextBox();
			this.lblOperationType = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.Value = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(4, 4);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 251);
			this.listBox1.TabIndex = 0;
			// 
			// lblItemName
			// 
			this.lblItemName.AutoSize = true;
			this.lblItemName.Location = new System.Drawing.Point(130, 7);
			this.lblItemName.Name = "lblItemName";
			this.lblItemName.Size = new System.Drawing.Size(61, 13);
			this.lblItemName.TabIndex = 2;
			this.lblItemName.Text = "Item Name:";
			// 
			// tbItemName
			// 
			this.tbItemName.Location = new System.Drawing.Point(197, 4);
			this.tbItemName.Name = "tbItemName";
			this.tbItemName.Size = new System.Drawing.Size(126, 20);
			this.tbItemName.TabIndex = 3;
			// 
			// lblOperationType
			// 
			this.lblOperationType.AutoSize = true;
			this.lblOperationType.Location = new System.Drawing.Point(130, 33);
			this.lblOperationType.Name = "lblOperationType";
			this.lblOperationType.Size = new System.Drawing.Size(56, 13);
			this.lblOperationType.TabIndex = 4;
			this.lblOperationType.Text = "Operation:";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(197, 30);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(126, 21);
			this.comboBox1.TabIndex = 5;
			// 
			// Value
			// 
			this.Value.AutoSize = true;
			this.Value.Location = new System.Drawing.Point(130, 60);
			this.Value.Name = "Value";
			this.Value.Size = new System.Drawing.Size(56, 13);
			this.Value.TabIndex = 6;
			this.Value.Text = "Operation:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(198, 58);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(125, 20);
			this.numericUpDown1.TabIndex = 7;
			// 
			// InventoryOperationsEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.Value);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.lblOperationType);
			this.Controls.Add(this.tbItemName);
			this.Controls.Add(this.lblItemName);
			this.Controls.Add(this.listBox1);
			this.Name = "InventoryOperationsEditor";
			this.Size = new System.Drawing.Size(326, 259);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label lblItemName;
		private System.Windows.Forms.TextBox tbItemName;
		private System.Windows.Forms.Label lblOperationType;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label Value;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}
