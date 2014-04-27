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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnRemove = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tvComparisonTree = new AdventureMaker.ConditionalEditors.ComparisonTreeView();
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
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(326, 33);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(128, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(150, 4);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 3;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(231, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Conditional Type:";
			// 
			// tvComparisonTree
			// 
			this.tvComparisonTree.Comparison = null;
			this.tvComparisonTree.HideSelection = false;
			this.tvComparisonTree.Location = new System.Drawing.Point(4, 34);
			this.tvComparisonTree.Name = "tvComparisonTree";
			this.tvComparisonTree.Size = new System.Drawing.Size(221, 331);
			this.tvComparisonTree.TabIndex = 5;
			// 
			// ConditionalEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tvComparisonTree);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.btnAdd);
			this.Name = "ConditionalEditor";
			this.Size = new System.Drawing.Size(457, 365);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Label label1;
		private ConditionalEditors.ComparisonTreeView tvComparisonTree;
	}
}
