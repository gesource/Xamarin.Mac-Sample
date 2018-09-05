// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace GlobalMonitorSample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButtonCell CheckBoxMonitoring { get; set; }

		[Outlet]
		AppKit.NSTextField LabelMonitor { get; set; }

		[Outlet]
		AppKit.NSTextField LabelScreen { get; set; }

		[Outlet]
		AppKit.NSTextField LabelWindow { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (LabelMonitor != null) {
				LabelMonitor.Dispose ();
				LabelMonitor = null;
			}

			if (CheckBoxMonitoring != null) {
				CheckBoxMonitoring.Dispose ();
				CheckBoxMonitoring = null;
			}

			if (LabelScreen != null) {
				LabelScreen.Dispose ();
				LabelScreen = null;
			}

			if (LabelWindow != null) {
				LabelWindow.Dispose ();
				LabelWindow = null;
			}
		}
	}
}
