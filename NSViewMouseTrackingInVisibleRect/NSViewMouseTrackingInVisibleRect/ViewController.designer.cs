// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NSViewMouseTrackingInVisibleRect
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton CheckBox { get; set; }

		[Outlet]
		Foundation.NSObject MainView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (MainView != null) {
				MainView.Dispose ();
				MainView = null;
			}

			if (CheckBox != null) {
				CheckBox.Dispose ();
				CheckBox = null;
			}
		}
	}
}
