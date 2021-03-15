using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace MTKUnlock.Properties
{
	// Token: 0x0200000B RID: 11
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00008A88 File Offset: 0x00008A88
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000060 RID: 96
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
