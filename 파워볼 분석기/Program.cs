using System;
using System.Windows.Forms;

namespace 파워볼_분석기
{
	// Token: 0x02000008 RID: 8
	internal static class Program
	{
		// Token: 0x0600001F RID: 31 RVA: 0x000031A1 File Offset: 0x000013A1
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
