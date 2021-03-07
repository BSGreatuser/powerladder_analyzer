using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000002 RID: 2
public class IniFile
{
	// Token: 0x06000001 RID: 1
	[DllImport("kernel32.dll")]
	private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int Size, string filePat);

	// Token: 0x06000002 RID: 2
	[DllImport("Kernel32.dll")]
	private static extern long WritePrivateProfileString(string Section, string Key, string val, string filePath);

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	public void IniWriteValue(string Section, string Key, string Value, string avaPath)
	{
		IniFile.WritePrivateProfileString(Section, Key, Value, avaPath);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002060 File Offset: 0x00000260
	public string IniReadValue(string Section, string Key, string avsPath)
	{
		StringBuilder stringBuilder = new StringBuilder(2000);
		IniFile.GetPrivateProfileString(Section, Key, "", stringBuilder, 2000, avsPath);
		return stringBuilder.ToString();
	}
}
