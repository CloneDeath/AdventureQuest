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
			this.lblOperationType = new System.Windows.Forms.Label();
			this.cbOperationType = new System.Windows.Forms.ComboBox();
			this.lblValue = new System.Windows.Forms.Label();
			this.nudValue = new System.Windows.Forms.NumericUpDown();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnMoveDown = new System.Windows.Forms.Button();
			this.btnMoveUp = new System.Windows.Forms.Button();
			this.cbItemName = new System.Windows.Forms.ComboBox();
			this.lbOperations = new AdventureMaker.RefreshListBox();
			((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
			this.SuspendLayout();
			// 
			// lblItemName
			// 
			this.lblItemName.AutoSize = true;
			this.lblItemName.Location = new System.Drawing.Point(230, 32);
			this.lblItemName.Name = "lblItemName";
			this.lblItemName.Size = new System.Drawing.Size(61, 13);
			this.lblItemName.TabIndex = 2;
			this.lblItemName.Text = "Item Name:";
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
			this.cbOperationType.Location = new System.Drawing.Point(298, 56);
			this.cbOperationType.Name = "cbOperationType";
			this.cbOperationType.Size = new System.Drawing.Size(131, 21);
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
			// btnMoveDown
			// 
			this.btnMoveDown.Location = new System.Drawing.Point(230, 139);
			this.btnMoveDown.Name = "btnMoveDown";
			this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
			this.btnMoveDown.TabIndex = 13;
			this.btnMoveDown.Text = "Move Down";
			this.btnMoveDown.UseVisualStyleBackColor = true;
			this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
			// 
			// btnMoveUp
			// 
			this.btnMoveUp.Location = new System.Drawing.Point(230, 110);
			this.btnMoveUp.Name = "btnMoveUp";
			this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
			this.btnMoveUp.TabIndex = 12;
			this.btnMoveUp.Text = "Move Up";
			this.btnMoveUp.UseVisualStyleBackColor = true;
			this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
			// 
			// cbItemName
			// 
			this.cbItemName.FormattingEnabled = true;
			this.cbItemName.Location = new System.Drawing.Point(298, 29);
			this.cbItemName.Name = "cbItemName";
			this.cbItemName.Size = new System.Drawing.Size(131, 21);
			this.cbItemName.TabIndex = 14;
			this.cbItemName.DropDown += new System.EventHandler(this.cbItemName_DropDown);
			this.cbItemName.TextChanged += new System.EventHandler(this.cbItemName_TextChanged);
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
			this.Controls.Add(this.cbItemName);
			this.Controls.Add(this.btnMoveDown);
			this.Controls.Add(this.btnMoveUp);
			this.Controls.Add(this.lbOperations);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.nudValue);
			this.Controls.Add(this.lblValue);
			this.Controls.Add(this.cbOperationType);
			this.Controls.Add(this.lblOperationType);
			this.Controls.Add(this.lblItemName);
			this.Name = "OperationsEditor";
			this.Size = new System.Drawing.Size(432, 355);
			((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblItemName;
		private System.Windows.Forms.Label lblOperationType;
		private System.Windows.Forms.ComboBox cbOperationType;
		private System.Windows.Forms.Label lblValue;
		private System.Windows.Forms.NumericUpDown nudValue;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAdd;
		private RefreshListBox lbOperations;
		private System.Windows.Forms.Button btnMoveDown;
		private System.Windows.Forms.Button btnMoveUp;
		private System.Windows.Forms.ComboBox cbItemName;
	}
}
