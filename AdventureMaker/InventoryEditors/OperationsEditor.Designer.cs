namespace AdventureMaker
{
	partial class OperationsEditor
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
			this.lblItemName = new System.Windows.Forms.Label();
			this.tbItemName = new System.Windows.Forms.TextBox();
			this.lblOperationType = new System.Windows.Forms.Label();
			this.cbOperationType = new System.Windows.Forms.ComboBox();
			this.lblValue = new System.Windows.Forms.Label();
			this.nudValue = new System.Windows.Forms.NumericUpDown();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lbOperations = new AdventureMaker.RefreshListBox();
			((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
			this.SuspendLayout();
			// 
			// lblItemName
			// 
			this.lblItemName.AutoSize = true;
			this.lblItemName.Location = new System.Drawing.Point(230, 33);
			this.lblItemName.Name = "lblItemName";
			this.lblItemName.Size = new System.Drawing.Size(61, 13);
			this.lblItemName.TabIndex = 2;
			this.lblItemName.Text = "Item Name:";
			// 
			// tbItemName
			// 
			this.tbItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbItemName.Location = new System.Drawing.Point(297, 30);
			this.tbItemName.Name = "tbItemName";
			this.tbItemName.Size = new System.Drawing.Size(132, 20);
			this.tbItemName.TabIndex = 3;
			this.tbItemName.TextChanged += new System.EventHandler(this.tbItemName_TextChanged);
			// 
			// lblOperationType
			// 
			this.lblOperationType.AutoSize = true;
			this.lblOperationType.Location = new System.Drawing.Point(230, 59);
			this.lblOperationType.Name = "lblOperationType";
			this.lblOperationType.Size = new System.Drawing.Size(56, 13);
			this.lblOperationType.TabIndex = 4;
			this.lblOperationType.Text = "Operation:";
			// 
			// cbOperationType
			// 
			this.cbOperationType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cbOperationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOperationType.FormattingEnabled = true;
			this.cbOperationType.Location = new System.Drawing.Point(297, 56);
			this.cbOperationType.Name = "cbOperationType";
			this.cbOperationType.Size = new System.Drawing.Size(132, 21);
			this.cbOperationType.TabIndex = 5;
			this.cbOperationType.SelectedIndexChanged += new System.EventHandler(this.cbOperationType_SelectedIndexChanged);
			// 
			// lblValue
			// 
			this.lblValue.AutoSize = true;
			this.lblValue.Location = new System.Drawing.Point(230, 86);
			this.lblValue.Name = "lblValue";
			this.lblValue.Size = new System.Drawing.Size(37, 13);
			this.lblValue.TabIndex = 6;
			this.lblValue.Text = "Value:";
			// 
			// nudValue
			// 
			this.nudValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.nudValue.Location = new System.Drawing.Point(298, 84);
			this.nudValue.Name = "nudValue";
			this.nudValue.Size = new System.Drawing.Size(131, 20);
			this.nudValue.TabIndex = 7;
			this.nudValue.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(149, 3);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 9;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(3, 3);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lbOperations
			// 
			this.lbOperations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.lbOperations.FormattingEnabled = true;
			this.lbOperations.Location = new System.Drawing.Point(4, 33);
			this.lbOperations.Name = "lbOperations";
			this.lbOperations.Size = new System.Drawing.Size(220, 316);
			this.lbOperations.TabIndex = 10;
			this.lbOperations.SelectedIndexChanged += new System.EventHandler(this.lbOperations_SelectedIndexChanged);
			// 
			// OperationsEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbOperations);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.nudValue);
			this.Controls.Add(this.lblValue);
			this.Controls.Add(this.cbOperationType);
			this.Controls.Add(this.lblOperationType);
			this.Controls.Add(this.tbItemName);
			this.Controls.Add(this.lblItemName);
			this.Name = "OperationsEditor";
			this.Size = new System.Drawing.Size(432, 355);
			((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblItemName;
		private System.Windows.Forms.TextBox tbItemName;
		private System.Windows.Forms.Label lblOperationType;
		private System.Windows.Forms.ComboBox cbOperationType;
		private System.Windows.Forms.Label lblValue;
		private System.Windows.Forms.NumericUpDown nudValue;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAdd;
		private RefreshListBox lbOperations;
	}
}
