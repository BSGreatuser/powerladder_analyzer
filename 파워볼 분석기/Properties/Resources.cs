using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace 파워볼_분석기.Properties
{
	// Token: 0x02000009 RID: 9
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00003186 File Offset: 0x00001386
		internal Resources()
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000031BC File Offset: 0x000013BC
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				bool flag2 = flag;
				if (flag2)
				{
					Resources.resourceMan = new ResourceManager("파워볼_분석기.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003204 File Offset: 0x00001404
		// (set) Token: 0x06000023 RID: 35 RVA: 0x0000321B File Offset: 0x0000141B
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003224 File Offset: 0x00001424
		internal static Bitmap _123
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("123", Resources.resourceCulture);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00003250 File Offset: 0x00001450
		internal static Bitmap 다운로드
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("다운로드", Resources.resourceCulture);
			}
		}

		// Token: 0x04000019 RID: 25
		private static ResourceManager resourceMan;

		// Token: 0x0400001A RID: 26
		private static CultureInfo resourceCulture;
	}
}
