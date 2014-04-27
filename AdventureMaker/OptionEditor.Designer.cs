namespace AdventureMaker {
	partial class OptionEditor {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lblDescription = new System.Windows.Forms.Label();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.lblStoryNode = new System.Windows.Forms.Label();
			this.tbStoryNode = new System.Windows.Forms.TextBox();
			this.btnGoToNode = new System.Windows.Forms.Button();
			this.btnSelectNode = new System.Windows.Forms.Button();
			this.uiConditionalEditor = new AdventureMaker.ConditionalEditor();
			this.uiInventoryOperationsEditor = new AdventureMaker.InventoryOperationsEditor();
			this.lblCanChoose = new System.Windows.Forms.Label();
			this.lblOnOptionChosen = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(3, 7);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(63, 13);
			this.lblDescription.TabIndex = 0;
			this.lblDescription.Text = "Description:";
			// 
			// tbDescription
			// 
			this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbDescription.Location = new System.Drawing.Point(72, 4);
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(806, 20);
			this.tbDescription.TabIndex = 1;
			this.tbDescription.TextChanged += new System.EventHandler(this.tbDescription_TextChanged);
			// 
			// lblStoryNode
			// 
			this.lblStoryNode.AutoSize = true;
			this.lblStoryNode.Location = new System.Drawing.Point(3, 34);
			this.lblStoryNode.Name = "lblStoryNode";
			this.lblStoryNode.Size = new System.Drawing.Size(63, 13);
			this.lblStoryNode.TabIndex = 2;
			this.lblStoryNode.Text = "Story Node:";
			// 
			// tbStoryNode
			// 
			this.tbStoryNode.Location = new System.Drawing.Point(72, 31);
			this.tbStoryNode.Name = "tbStoryNode";
			this.tbStoryNode.Size = new System.Drawing.Size(199, 20);
			this.tbStoryNode.TabIndex = 3;
			this.tbStoryNode.TextChanged += new System.EventHandler(this.tbStoryNode_TextChanged);
			this.tbStoryNode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStoryNode_KeyPress);
			// 
			// btnGoToNode
			// 
			this.btnGoToNode.Location = new System.Drawing.Point(277, 29);
			this.btnGoToNode.Name = "btnGoToNode";
			this.btnGoToNode.Size = new System.Drawing.Size(89, 23);
			this.btnGoToNode.TabIndex = 4;
			this.btnGoToNode.Text = "Go To Node";
			this.btnGoToNode.UseVisualStyleBackColor = true;
			this.btnGoToNode.Click += new System.EventHandler(this.btnGoToNode_Click);
			// 
			// btnSelectNode
			// 
			this.btnSelectNode.Location = new System.Drawing.Point(372, 28);
			this.btnSelectNode.Name = "btnSelectNode";
			this.btnSelectNode.Size = new System.Drawing.Size(89, 23);
			this.btnSelectNode.TabIndex = 5;
			this.btnSelectNode.Text = "Select Node...";
			this.btnSelectNode.UseVisualStyleBackColor = true;
			this.btnSelectNode.Click += new System.EventHandler(this.btnSelectNode_Click);
			// 
			// uiConditionalEditor
			// 
			this.uiConditionalEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.uiConditionalEditor.Comparison = null;
			this.uiConditionalEditor.Location = new System.Drawing.Point(6, 77);
			this.uiConditionalEditor.Name = "uiConditionalEditor";
			this.uiConditionalEditor.Size = new System.Drawing.Size(455, 377);
			this.uiConditionalEditor.TabIndex = 6;
			// 
			// uiInventoryOperationsEditor
			// 
			this.uiInventoryOperationsEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.uiInventoryOperationsEditor.Location = new System.Drawing.Point(467, 77);
			this.uiInventoryOperationsEditor.Name = "uiInventoryOperationsEditor";
			this.uiInventoryOperationsEditor.Size = new System.Drawing.Size(411, 377);
			this.uiInventoryOperationsEditor.TabIndex = 7;
			// 
			// lblCanChoose
			// 
			this.lblCanChoose.AutoSize = true;
			this.lblCanChoose.Location = new System.Drawing.Point(3, 61);
			this.lblCanChoose.Name = "lblCanChoose";
			this.lblCanChoose.Size = new System.Drawing.Size(68, 13);
			this.lblCanChoose.TabIndex = 8;
			this.lblCanChoose.Text = "Can Choose:";
			// 
			// lblOnOptionChosen
			// 
			this.lblOnOptionChosen.AutoSize = true;
			this.lblOnOptionChosen.Location = new System.Drawing.Point(464, 61);
			this.lblOnOptionChosen.Name = "lblOnOptionChosen";
			this.lblOnOptionChosen.Size = new System.Drawing.Size(103, 13);
			this.lblOnOptionChosen.TabIndex = 9;
			this.lblOnOptionChosen.Text = "On Option Choosen:";
			// 
			// OptionEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblOnOptionChosen);
			this.Controls.Add(this.lblCanChoose);
			this.Controls.Add(this.uiInventoryOperationsEditor);
			this.Controls.Add(this.uiConditionalEditor);
			this.Controls.Add(this.btnSelectNode);
			this.Controls.Add(this.btnGoToNode);
			this.Controls.Add(this.tbStoryNode);
			this.Controls.Add(this.lblStoryNode);
			this.Controls.Add(this.tbDescription);
			this.Controls.Add(this.lblDescription);
			this.Name = "OptionEditor";
			this.Size = new System.Drawing.Size(881, 457);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox tbDescription;
		private System.Windows.Forms.Label lblStoryNode;
		private System.Windows.Forms.TextBox tbStoryNode;
		private System.Windows.Forms.Button btnGoToNode;
		private System.Windows.Forms.Button btnSelectNode;
		private ConditionalEditor uiConditionalEditor;
		private InventoryOperationsEditor uiInventoryOperationsEditor;
		private System.Windows.Forms.Label lblCanChoose;
		private System.Windows.Forms.Label lblOnOptionChosen;
	}
}
