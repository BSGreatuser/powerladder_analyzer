namespace 파워볼_분석기
{
	// Token: 0x02000004 RID: 4
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002E50 File Offset: 0x00001050
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002E88 File Offset: 0x00001088
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::파워볼_분석기.Form2));
			this.button1 = new global::System.Windows.Forms.Button();
			this.Code = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(44, 231);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(179, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "로그인";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.Code.Location = new global::System.Drawing.Point(85, 185);
			this.Code.Name = "Code";
			this.Code.Size = new global::System.Drawing.Size(138, 21);
			this.Code.TabIndex = 1;
			this.Code.TextChanged += new global::System.EventHandler(this.Code_TextChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(42, 188);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(37, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "코드 :";
			this.groupBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.Code);
			this.groupBox1.Location = new global::System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(266, 310);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(269, 316);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "Form2";
			this.Text = "EVLT LOGIN";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000013 RID: 19
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.TextBox Code;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.GroupBox groupBox1;
	}
}
