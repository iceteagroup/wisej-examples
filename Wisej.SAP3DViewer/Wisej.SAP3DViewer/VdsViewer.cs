using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Wisej.Web;

namespace Wisej.SAP3DViewer
{
	public class VdsViewer : Widget
	{

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override string InitScript
		{
			// disable inlining or we lose the calling assembly in GetResourceString().
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return GetResourceString("Wisej.SAP3DViewer.JavaScript.Init.js");
			}
			set { }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override List<Package> Packages
		{
			get
			{
				if (base.Packages.Count == 0)
				{
					base.Packages.Add(new Package() { 
						Name = "Polyfill",
						Source= "https://cdn.jsdelivr.net/npm/promise-polyfill@8/dist/polyfill.min.js"
					});
					base.Packages.Add(new Package()
					{
						Name = "Loco.js",
						Source = "JavaScript\\Loco.js"
					});
					base.Packages.Add(new Package()
					{
						Name = "DVL.js",
						Source = "JavaScript\\lib\\dvl_asm.js"
					});
				}
				return base.Packages;
			}
		}
	}
}