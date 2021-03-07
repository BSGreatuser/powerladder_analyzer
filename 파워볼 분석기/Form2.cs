using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace 파워볼_분석기
{
	// Token: 0x02000004 RID: 4
	public partial class Form2 : Form
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002DCC File Offset: 0x00000FCC
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002DE4 File Offset: 0x00000FE4
		private void button1_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string b = webClient.DownloadString("https://pastebin.com/raw/YqWhtXw0");
			bool flag = this.Code.Text == b;
			if (flag)
			{
				MessageBox.Show("정보확인 완료");
				base.Hide();
				Form1 form = new Form1();
				form.Show();
			}
			else
			{
				MessageBox.Show("정보확인 불가");
				Application.Exit();
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002241 File Offset: 0x00000441
		private void Code_TextChanged(object sender, EventArgs e)
		{
		}
	}
}
