namespace Resizer
{
	partial class MainForm
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
			this.btnDoIt = new System.Windows.Forms.Button();
			this.gbxSize = new System.Windows.Forms.GroupBox();
			this.rbnLarge = new System.Windows.Forms.RadioButton();
			this.rbnScreen = new System.Windows.Forms.RadioButton();
			this.rbnMiddle = new System.Windows.Forms.RadioButton();
			this.rbnTiny = new System.Windows.Forms.RadioButton();
			this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
			this.gbxSize.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnDoIt
			// 
			this.btnDoIt.Location = new System.Drawing.Point(12, 94);
			this.btnDoIt.Name = "btnDoIt";
			this.btnDoIt.Size = new System.Drawing.Size(268, 37);
			this.btnDoIt.TabIndex = 0;
			this.btnDoIt.Text = "Choose photo!";
			this.btnDoIt.UseVisualStyleBackColor = true;
			this.btnDoIt.Click += new System.EventHandler(this.btnDoIt_Click);
			// 
			// gbxSize
			// 
			this.gbxSize.Controls.Add(this.rbnLarge);
			this.gbxSize.Controls.Add(this.rbnScreen);
			this.gbxSize.Controls.Add(this.rbnMiddle);
			this.gbxSize.Controls.Add(this.rbnTiny);
			this.gbxSize.Location = new System.Drawing.Point(12, 12);
			this.gbxSize.Name = "gbxSize";
			this.gbxSize.Size = new System.Drawing.Size(268, 76);
			this.gbxSize.TabIndex = 1;
			this.gbxSize.TabStop = false;
			this.gbxSize.Text = "Size";
			// 
			// rbnLarge
			// 
			this.rbnLarge.AutoSize = true;
			this.rbnLarge.Location = new System.Drawing.Point(142, 44);
			this.rbnLarge.Name = "rbnLarge";
			this.rbnLarge.Size = new System.Drawing.Size(52, 17);
			this.rbnLarge.TabIndex = 3;
			this.rbnLarge.TabStop = true;
			this.rbnLarge.Text = "Large";
			this.rbnLarge.UseVisualStyleBackColor = true;
			// 
			// rbnScreen
			// 
			this.rbnScreen.AutoSize = true;
			this.rbnScreen.Checked = true;
			this.rbnScreen.Location = new System.Drawing.Point(24, 44);
			this.rbnScreen.Name = "rbnScreen";
			this.rbnScreen.Size = new System.Drawing.Size(58, 17);
			this.rbnScreen.TabIndex = 2;
			this.rbnScreen.TabStop = true;
			this.rbnScreen.Text = "Screen";
			this.rbnScreen.UseVisualStyleBackColor = true;
			// 
			// rbnMiddle
			// 
			this.rbnMiddle.AutoSize = true;
			this.rbnMiddle.Location = new System.Drawing.Point(142, 21);
			this.rbnMiddle.Name = "rbnMiddle";
			this.rbnMiddle.Size = new System.Drawing.Size(61, 17);
			this.rbnMiddle.TabIndex = 1;
			this.rbnMiddle.Text = "Medium";
			this.rbnMiddle.UseVisualStyleBackColor = true;
			// 
			// rbnTiny
			// 
			this.rbnTiny.AutoSize = true;
			this.rbnTiny.Location = new System.Drawing.Point(24, 21);
			this.rbnTiny.Name = "rbnTiny";
			this.rbnTiny.Size = new System.Drawing.Size(49, 17);
			this.rbnTiny.TabIndex = 0;
			this.rbnTiny.Text = "Small";
			this.rbnTiny.UseVisualStyleBackColor = true;
			// 
			// dlgOpen
			// 
			this.dlgOpen.Filter = "Photos and pictures|*.jpg;*.jpeg;*.bmp;*.png;*.gif;*.tif;*.tiff;";
			this.dlgOpen.ShowReadOnly = true;
			this.dlgOpen.Title = "Choose file";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 143);
			this.Controls.Add(this.gbxSize);
			this.Controls.Add(this.btnDoIt);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Photo Resizer";
			this.gbxSize.ResumeLayout(false);
			this.gbxSize.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnDoIt;
		private System.Windows.Forms.GroupBox gbxSize;
		private System.Windows.Forms.RadioButton rbnScreen;
		private System.Windows.Forms.RadioButton rbnMiddle;
		private System.Windows.Forms.RadioButton rbnTiny;
		private System.Windows.Forms.OpenFileDialog dlgOpen;
		private System.Windows.Forms.RadioButton rbnLarge;
	}
}

