// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NSViewConvertPoint
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField Label1 { get; set; }

		[Outlet]
		AppKit.NSTextField Label2 { get; set; }

		[Outlet]
		AppKit.NSTextField Label3 { get; set; }

		[Outlet]
		NSViewConvertPoint.MainView MainView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (MainView != null) {
				MainView.Dispose ();
				MainView = null;
			}

			if (Label1 != null) {
				Label1.Dispose ();
				Label1 = null;
			}

			if (Label2 != null) {
				Label2.Dispose ();
				Label2 = null;
			}

			if (Label3 != null) {
				Label3.Dispose ();
				Label3 = null;
			}
		}
	}
}
