namespace OOP3
{
	partial class Main
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
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._cbxShape = new System.Windows.Forms.ComboBox();
			this._pPanel = new System.Windows.Forms.Panel();
			this._lblMode = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _cbxShape
			// 
			this._cbxShape.AccessibleName = "";
			this._cbxShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cbxShape.FormattingEnabled = true;
			this._cbxShape.Location = new System.Drawing.Point(12, 12);
			this._cbxShape.Name = "_cbxShape";
			this._cbxShape.Size = new System.Drawing.Size(109, 21);
			this._cbxShape.TabIndex = 0;
			// 
			// _pPanel
			// 
			this._pPanel.AccessibleName = "";
			this._pPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._pPanel.BackColor = System.Drawing.Color.White;
			this._pPanel.Cursor = System.Windows.Forms.Cursors.Cross;
			this._pPanel.Location = new System.Drawing.Point(12, 39);
			this._pPanel.Name = "_pPanel";
			this._pPanel.Size = new System.Drawing.Size(776, 424);
			this._pPanel.TabIndex = 1;
			this._pPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint_pPanel);
			this._pPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClick_pPanel);
			this._pPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown_pPanel);
			this._pPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove_pPanel);
			// 
			// _lblMode
			// 
			this._lblMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._lblMode.AutoSize = true;
			this._lblMode.Location = new System.Drawing.Point(12, 466);
			this._lblMode.Name = "_lblMode";
			this._lblMode.Size = new System.Drawing.Size(33, 13);
			this._lblMode.TabIndex = 2;
			this._lblMode.Text = "mode";
			// 
			// Main
			// 
			this.AccessibleName = "";
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 488);
			this.Controls.Add(this._lblMode);
			this.Controls.Add(this._pPanel);
			this.Controls.Add(this._cbxShape);
			this.Name = "Main";
			this.ShowIcon = false;
			this.Text = "OOP3";
			this.Load += new System.EventHandler(this.OnLoad_frmMain);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox _cbxShape;
		private System.Windows.Forms.Panel _pPanel;
		private System.Windows.Forms.Label _lblMode;
	}
}