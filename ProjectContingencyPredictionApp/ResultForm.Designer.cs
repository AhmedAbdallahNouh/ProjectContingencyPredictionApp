namespace ProjectContingencyPredictionApp
{
	partial class ResultForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
			this.lblResult = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResult.Location = new System.Drawing.Point(209, 317);
			this.lblResult.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(76, 25);
			this.lblResult.TabIndex = 0;
			this.lblResult.Text = "label1";
			this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(73, 104);
			this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1275, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Thank You For Using Our Advanced Project Contingency Prediction for Irrigation Ca" +
    "nal Lining Projects (ICLPs) in Egypt ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(825, 357);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 25);
			this.label2.TabIndex = 2;
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(617, 532);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(208, 51);
			this.button1.TabIndex = 3;
			this.button1.Text = "Another Calculation";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label3.Location = new System.Drawing.Point(456, 167);
			this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(503, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "We Wish Our tool Be The First Choice For You";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 422);
			this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(1440, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "((The Value of Project Contingency is Used To Adjust The Original Estimated Proje" +
    "ct Cost For Irrigation Canal Lining Projects in Egypt))";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ResultForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1456, 679);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblResult);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.Name = "ResultForm";
			this.Text = "Project Contingency Prediction for ICLPs";
			this.Load += new System.EventHandler(this.ResultForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}

}