namespace AdventureMaker
{
	partial class ConditionalEditor
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.cbConditionalType = new System.Windows.Forms.ComboBox();
			this.btnRemove = new System.Windows.Forms.Button();
			this.lblComparison = new System.Windows.Forms.Label();
			this.lblItemName = new System.Windows.Forms.Label();
			this.nudValue = new System.Windows.Forms.NumericUpDown();
			this.lblValue = new System.Windows.Forms.Label();
			this.lbConditionals = new AdventureMaker.RefreshListBox();
			this.cbItemName = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(4, 4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// cbConditionalType
			// 
			this.cbConditionalType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cbConditionalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbConditionalType.FormattingEnabled = true;
			this.cbConditionalType.Location = new System.Drawing.Point(302, 59);
			this.cbConditionalType.Name = "cbConditionalType";
			this.cbConditionalType.Size = new System.Drawing.Size(152, 21);
			this.cbConditionalType.TabIndex = 2;
			this.cbConditionalType.SelectedIndexChanged += new System.EventHandler(this.cbConditionalType_SelectedIndexChanged);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(150, 4);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 3;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// lblComparison
			// 
			this.lblComparison.AutoSize = true;
			this.lblComparison.Location = new System.Drawing.Point(231, 62);
			this.lblComparison.Name = "lblComparison";
			this.lblComparison.Size = new System.Drawing.Size(65, 13);
			this.lblComparison.TabIndex = 4;
			this.lblComparison.Text = "Comparison:";
			// 
			// lblItemName
			// 
			this.lblItemName.AutoSize = true;
			this.lblItemName.Location = new System.Drawing.Point(231, 36);
			this.lblItemName.Name = "lblItemName";
			this.lblItemName.Size = new System.Drawing.Size(61, 13);
			this.lblItemName.TabIndex = 6;
			this.lblItemName.Text = "Item Name:";
			// 
			// nudValue
			// 
			this.nudValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.nudValue.Location = new System.Drawing.Point(302, 86);
			this.nudValue.Name = "nudValue";
			this.nudValue.Size = new System.Drawing.Size(152, 20);
			this.nudValue.TabIndex = 8;
			this.nudValue.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
			// 
			// lblValue
			// 
			this.lblValue.AutoSize = true;
			this.lblValue.Location = new System.Drawing.Point(231, 88);
			this.lblValue.Name = "lblValue";
			this.lblValue.Size = new System.Drawing.Size(37, 13);
			this.lblValue.TabIndex = 9;
			this.lblValue.Text = "Value:";
			// 
			// lbConditionals
			// 
			this.lbConditionals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.lbConditionals.FormattingEnabled = true;
			this.lbConditionals.Location = new System.Drawing.Point(3, 33);
			this.lbConditionals.Name = "lbConditionals";
			this.lbConditionals.Size = new System.Drawing.Size(222, 329);
			this.lbConditionals.TabIndex = 5;
			this.lbConditionals.SelectedIndexChanged += new System.EventHandler(this.lbConditionals_SelectedIndexChanged);
			// 
			// cbItemName
			// 
			this.cbItemName.FormattingEnabled = true;
			this.cbItemName.Location = new System.Drawing.Point(302, 32);
			this.cbItemName.Name = "cbItemName";
			this.cbItemName.Size = new System.Drawing.Size(152, 21);
			this.cbItemName.TabIndex = 10;
			this.cbItemName.DropDown += new System.EventHandler(this.cbItemName_DropDown);
			this.cbItemName.TextChanged += new System.EventHandler(this.cbItemName_TextChanged);
			// 
			// ConditionalEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cbItemName);
			this.Controls.Add(this.lblValue);
			this.Controls.Add(this.nudValue);
			this.Controls.Add(this.lblItemName);
			this.Controls.Add(this.lbConditionals);
			this.Controls.Add(this.lblComparison);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.cbConditionalType);
			this.Controls.Add(this.btnAdd);
			this.Name = "ConditionalEditor";
			this.Size = new System.Drawing.Size(457, 365);
			((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox cbConditionalType;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Label lblComparison;
		private RefreshListBox lbConditionals;
		private System.Windows.Forms.Label lblItemName;
		private System.Windows.Forms.NumericUpDown nudValue;
		private System.Windows.Forms.Label lblValue;
		private System.Windows.Forms.ComboBox cbItemName;
	}
}
