using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace UniversalUnlockTool.Properties
{
	// Token: 0x02000015 RID: 21
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000085 RID: 133 RVA: 0x000020C7 File Offset: 0x000002C7
		internal Resources()
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00008AE0 File Offset: 0x00006CE0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager resourceManager = new ResourceManager("UniversalUnlockTool.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00008B20 File Offset: 0x00006D20
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0000233D File Offset: 0x0000053D
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

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00008B34 File Offset: 0x00006D34
		internal static string Auth
		{
			get
			{
				return Resources.ResourceManager.GetString("Auth", Resources.resourceCulture);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00008B58 File Offset: 0x00006D58
		internal static string errorlogs
		{
			get
			{
				return Resources.ResourceManager.GetString("errorlogs", Resources.resourceCulture);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00008B7C File Offset: 0x00006D7C
		internal static string logs
		{
			get
			{
				return Resources.ResourceManager.GetString("logs", Resources.resourceCulture);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00008BA0 File Offset: 0x00006DA0
		internal static string logs1
		{
			get
			{
				return Resources.ResourceManager.GetString("logs1", Resources.resourceCulture);
			}
		}

		// Token: 0x04000080 RID: 128
		private static ResourceManager resourceMan;

		// Token: 0x04000081 RID: 129
		private static CultureInfo resourceCulture;
	}
}
