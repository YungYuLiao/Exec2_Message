namespace Exec2_Message
{
	partial class frmGreet
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnTimeGreet = new System.Windows.Forms.Button();
			this.lblGreetTime = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnTimeGreet
			// 
			this.btnTimeGreet.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnTimeGreet.Location = new System.Drawing.Point(118, 142);
			this.btnTimeGreet.Name = "btnTimeGreet";
			this.btnTimeGreet.Size = new System.Drawing.Size(75, 30);
			this.btnTimeGreet.TabIndex = 0;
			this.btnTimeGreet.Text = "問候!";
			this.btnTimeGreet.UseVisualStyleBackColor = true;
			this.btnTimeGreet.Click += new System.EventHandler(this.btnTimeGreet_Click);
			// 
			// lblGreetTime
			// 
			this.lblGreetTime.AutoSize = true;
			this.lblGreetTime.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblGreetTime.Location = new System.Drawing.Point(102, 40);
			this.lblGreetTime.Name = "lblGreetTime";
			this.lblGreetTime.Size = new System.Drawing.Size(0, 44);
			this.lblGreetTime.TabIndex = 2;
			this.lblGreetTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblGreetTime.UseMnemonic = false;
			// 
			// frmGreet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 197);
			this.Controls.Add(this.lblGreetTime);
			this.Controls.Add(this.btnTimeGreet);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmGreet";
			this.Text = "問候小精靈";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnTimeGreet;
		private System.Windows.Forms.Label lblGreetTime;
	}
}

