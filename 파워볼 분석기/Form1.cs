using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace 파워볼_분석기
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : Form
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000020A0 File Offset: 0x000002A0
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002154 File Offset: 0x00000354
		private void Form1_Load(object sender, EventArgs e)
		{
			IniFile iniFile = new IniFile();
			string text = Application.StartupPath + "\\Pick.dat";
			bool flag = File.Exists(text);
			bool flag2 = flag;
			if (flag2)
			{
				this.lastPick = iniFile.IniReadValue("config", "pick", text);
				this.lastDate = iniFile.IniReadValue("config", "time", text);
				this.label3.Text = this.lastPick;
				this.nowDate = Convert.ToDateTime(this.lastDate);
				bool flag3 = DateTime.Compare(DateTime.Now.AddMinutes(-5.0), Convert.ToDateTime(this.lastDate)) > 0;
				bool flag4 = flag3;
				if (flag4)
				{
					this.GetPick();
				}
			}
			else
			{
				this.GetPick();
			}
			new Thread(delegate()
			{
				for (;;)
				{
					try
					{
						using (WebClient webClient = new WebClient())
						{
							webClient.DownloadString("http://ntry.com/public/js/sync_clock.json?_=1565071890368");
							this.nowDate = Convert.ToDateTime(webClient.ResponseHeaders["Date"].ToString());
						}
					}
					catch
					{
					}
					Thread.Sleep(10000);
				}
			})
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002241 File Offset: 0x00000441
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002244 File Offset: 0x00000444
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.nowDate = this.nowDate.AddSeconds(1.0);
			this.label4.Text = this.nowDate.ToString();
			DateTime dateTime = this.nowDate.AddMinutes(-3.0).AddSeconds(5.0);
			int num = 5 - Convert.ToInt32(dateTime.ToString("mm")) % 5 - 1;
			int num2 = 60 - Convert.ToInt32(dateTime.ToString("ss"));
			bool flag = num2 == 60;
			bool flag2 = flag;
			if (flag2)
			{
				this.label5.Text = num.ToString() + ":" + string.Format("{0:D2}", num2 - 1);
			}
			else
			{
				this.label5.Text = num.ToString() + ":" + string.Format("{0:D2}", num2);
			}
			bool flag3 = num != 4 || num2 != 59;
			bool flag4 = !flag3;
			if (flag4)
			{
				this.GetPick();
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000236C File Offset: 0x0000056C
		private void GetPick()
		{
			this.lastPick = this.pickList[this.ran.Next(0, 5)];
			this.lastDate = DateTime.Now.ToString();
			IniFile iniFile = new IniFile();
			string avaPath = Application.StartupPath + "\\Pick.dat";
			iniFile.IniWriteValue("config", "time", this.lastDate, avaPath);
			iniFile.IniWriteValue("config", "pick", this.lastPick, avaPath);
			this.label3.Text = this.lastPick;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002403 File Offset: 0x00000603
		// (set) Token: 0x0600000C RID: 12 RVA: 0x0000240A File Offset: 0x0000060A
		public static string CODE_ { get; internal set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002412 File Offset: 0x00000612
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002419 File Offset: 0x00000619
		public static string CPUID_ { get; internal set; }

		// Token: 0x0600000F RID: 15 RVA: 0x00002241 File Offset: 0x00000441
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002241 File Offset: 0x00000441
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002241 File Offset: 0x00000441
		private void groupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002241 File Offset: 0x00000441
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002241 File Offset: 0x00000441
		private void button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000001 RID: 1
		public DateTime nowDate = default(DateTime);

		// Token: 0x04000002 RID: 2
		public string lastDate = null;

		// Token: 0x04000003 RID: 3
		public string lastPick = null;

		// Token: 0x04000004 RID: 4
		public List<string> pickList = new List<string>
		{
			"홀",
			"짝",
			"좌",
			"우",
			"3줄",
			"4줄"
		};

		// Token: 0x04000005 RID: 5
		public Random ran = new Random();

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
