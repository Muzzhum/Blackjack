namespace Kortspill
{
	partial class Form1
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
			this.startBtn = new System.Windows.Forms.Button();
			this.Player1GB = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.standBtn = new System.Windows.Forms.Button();
			this.hitBtn = new System.Windows.Forms.Button();
			this.DealerGB = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Player1GB.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// startBtn
			// 
			this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startBtn.Location = new System.Drawing.Point(161, 50);
			this.startBtn.Name = "startBtn";
			this.startBtn.Size = new System.Drawing.Size(200, 75);
			this.startBtn.TabIndex = 0;
			this.startBtn.Text = "Start";
			this.startBtn.UseVisualStyleBackColor = true;
			this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
			// 
			// Player1GB
			// 
			this.Player1GB.Controls.Add(this.label1);
			this.Player1GB.Controls.Add(this.pictureBox1);
			this.Player1GB.Controls.Add(this.standBtn);
			this.Player1GB.Controls.Add(this.hitBtn);
			this.Player1GB.Location = new System.Drawing.Point(13, 13);
			this.Player1GB.Name = "Player1GB";
			this.Player1GB.Size = new System.Drawing.Size(250, 156);
			this.Player1GB.TabIndex = 1;
			this.Player1GB.TabStop = false;
			this.Player1GB.Text = "Spiller 1";
			this.Player1GB.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(7, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// standBtn
			// 
			this.standBtn.Location = new System.Drawing.Point(169, 37);
			this.standBtn.Name = "standBtn";
			this.standBtn.Size = new System.Drawing.Size(75, 23);
			this.standBtn.TabIndex = 1;
			this.standBtn.Text = "Stand";
			this.standBtn.UseVisualStyleBackColor = true;
			// 
			// hitBtn
			// 
			this.hitBtn.Location = new System.Drawing.Point(169, 8);
			this.hitBtn.Name = "hitBtn";
			this.hitBtn.Size = new System.Drawing.Size(75, 23);
			this.hitBtn.TabIndex = 0;
			this.hitBtn.Text = "Hit";
			this.hitBtn.UseVisualStyleBackColor = true;
			// 
			// DealerGB
			// 
			this.DealerGB.Location = new System.Drawing.Point(265, 13);
			this.DealerGB.Name = "DealerGB";
			this.DealerGB.Size = new System.Drawing.Size(250, 156);
			this.DealerGB.TabIndex = 2;
			this.DealerGB.TabStop = false;
			this.DealerGB.Text = "Dealer";
			this.DealerGB.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(59, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 181);
			this.Controls.Add(this.startBtn);
			this.Controls.Add(this.Player1GB);
			this.Controls.Add(this.DealerGB);
			this.Name = "Form1";
			this.Text = "Blackjack";
			this.Player1GB.ResumeLayout(false);
			this.Player1GB.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button startBtn;
		private System.Windows.Forms.GroupBox Player1GB;
		private System.Windows.Forms.Button hitBtn;
		private System.Windows.Forms.GroupBox DealerGB;
		private System.Windows.Forms.Button standBtn;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}

