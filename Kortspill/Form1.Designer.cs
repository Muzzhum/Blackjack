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
			this.hand0SumLbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.surrenderBtn = new System.Windows.Forms.Button();
			this.doubleBtn = new System.Windows.Forms.Button();
			this.splitBtn = new System.Windows.Forms.Button();
			this.standBtn = new System.Windows.Forms.Button();
			this.hitBtn = new System.Windows.Forms.Button();
			this.DealerGB = new System.Windows.Forms.GroupBox();
			this.HolePB = new System.Windows.Forms.PictureBox();
			this.Player1GB.SuspendLayout();
			this.DealerGB.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.HolePB)).BeginInit();
			this.SuspendLayout();
			// 
			// startBtn
			// 
			this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startBtn.Location = new System.Drawing.Point(301, 200);
			this.startBtn.Name = "startBtn";
			this.startBtn.Size = new System.Drawing.Size(200, 75);
			this.startBtn.TabIndex = 0;
			this.startBtn.Text = "Start";
			this.startBtn.UseVisualStyleBackColor = true;
			this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
			// 
			// Player1GB
			// 
			this.Player1GB.Controls.Add(this.hand0SumLbl);
			this.Player1GB.Controls.Add(this.label1);
			this.Player1GB.Controls.Add(this.surrenderBtn);
			this.Player1GB.Controls.Add(this.doubleBtn);
			this.Player1GB.Controls.Add(this.splitBtn);
			this.Player1GB.Controls.Add(this.standBtn);
			this.Player1GB.Controls.Add(this.hitBtn);
			this.Player1GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Player1GB.Location = new System.Drawing.Point(12, 185);
			this.Player1GB.Name = "Player1GB";
			this.Player1GB.Size = new System.Drawing.Size(811, 313);
			this.Player1GB.TabIndex = 1;
			this.Player1GB.TabStop = false;
			this.Player1GB.Text = "Spiller 1";
			this.Player1GB.Visible = false;
			// 
			// hand0SumLbl
			// 
			this.hand0SumLbl.AutoSize = true;
			this.hand0SumLbl.Location = new System.Drawing.Point(626, 47);
			this.hand0SumLbl.Name = "hand0SumLbl";
			this.hand0SumLbl.Size = new System.Drawing.Size(16, 17);
			this.hand0SumLbl.TabIndex = 6;
			this.hand0SumLbl.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(583, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Sum";
			// 
			// surrenderBtn
			// 
			this.surrenderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.surrenderBtn.Location = new System.Drawing.Point(687, 256);
			this.surrenderBtn.Name = "surrenderBtn";
			this.surrenderBtn.Size = new System.Drawing.Size(118, 57);
			this.surrenderBtn.TabIndex = 4;
			this.surrenderBtn.Text = "Surrender";
			this.surrenderBtn.UseVisualStyleBackColor = true;
			this.surrenderBtn.Click += new System.EventHandler(this.surrenderBtn_Click);
			// 
			// doubleBtn
			// 
			this.doubleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.doubleBtn.Location = new System.Drawing.Point(687, 193);
			this.doubleBtn.Name = "doubleBtn";
			this.doubleBtn.Size = new System.Drawing.Size(118, 57);
			this.doubleBtn.TabIndex = 3;
			this.doubleBtn.Text = "Double";
			this.doubleBtn.UseVisualStyleBackColor = true;
			// 
			// splitBtn
			// 
			this.splitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.splitBtn.Location = new System.Drawing.Point(687, 130);
			this.splitBtn.Name = "splitBtn";
			this.splitBtn.Size = new System.Drawing.Size(118, 57);
			this.splitBtn.TabIndex = 2;
			this.splitBtn.Text = "Split";
			this.splitBtn.UseVisualStyleBackColor = true;
			// 
			// standBtn
			// 
			this.standBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.standBtn.Location = new System.Drawing.Point(687, 67);
			this.standBtn.Name = "standBtn";
			this.standBtn.Size = new System.Drawing.Size(118, 57);
			this.standBtn.TabIndex = 1;
			this.standBtn.Text = "Stand";
			this.standBtn.UseVisualStyleBackColor = true;
			this.standBtn.Click += new System.EventHandler(this.standBtn_Click);
			// 
			// hitBtn
			// 
			this.hitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hitBtn.Location = new System.Drawing.Point(687, 4);
			this.hitBtn.Name = "hitBtn";
			this.hitBtn.Size = new System.Drawing.Size(118, 57);
			this.hitBtn.TabIndex = 0;
			this.hitBtn.Text = "Hit";
			this.hitBtn.UseVisualStyleBackColor = true;
			this.hitBtn.Click += new System.EventHandler(this.hitBtn_Click);
			// 
			// DealerGB
			// 
			this.DealerGB.Controls.Add(this.HolePB);
			this.DealerGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DealerGB.Location = new System.Drawing.Point(12, 12);
			this.DealerGB.Name = "DealerGB";
			this.DealerGB.Size = new System.Drawing.Size(811, 167);
			this.DealerGB.TabIndex = 2;
			this.DealerGB.TabStop = false;
			this.DealerGB.Text = "Dealer";
			this.DealerGB.Visible = false;
			// 
			// HolePB
			// 
			this.HolePB.Location = new System.Drawing.Point(7, 20);
			this.HolePB.Name = "HolePB";
			this.HolePB.Size = new System.Drawing.Size(75, 109);
			this.HolePB.TabIndex = 0;
			this.HolePB.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(835, 510);
			this.Controls.Add(this.startBtn);
			this.Controls.Add(this.DealerGB);
			this.Controls.Add(this.Player1GB);
			this.Name = "Form1";
			this.Text = "Blackjack";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Player1GB.ResumeLayout(false);
			this.Player1GB.PerformLayout();
			this.DealerGB.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.HolePB)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button startBtn;
		private System.Windows.Forms.GroupBox Player1GB;
		private System.Windows.Forms.Button hitBtn;
		private System.Windows.Forms.GroupBox DealerGB;
		private System.Windows.Forms.Button standBtn;
		private System.Windows.Forms.Button surrenderBtn;
		private System.Windows.Forms.Button doubleBtn;
		private System.Windows.Forms.Button splitBtn;
		private System.Windows.Forms.Label hand0SumLbl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox HolePB;
	}
}

