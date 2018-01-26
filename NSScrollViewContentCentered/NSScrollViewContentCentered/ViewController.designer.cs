// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NSScrollViewContentCentered
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton ButtonScaleDown { get; set; }

		[Outlet]
		AppKit.NSButton ButtonScaleUp { get; set; }

		[Outlet]
		AppKit.NSScrollView ScrollView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ScrollView != null) {
				ScrollView.Dispose ();
				ScrollView = null;
			}

			if (ButtonScaleDown != null) {
				ButtonScaleDown.Dispose ();
				ButtonScaleDown = null;
			}

			if (ButtonScaleUp != null) {
				ButtonScaleUp.Dispose ();
				ButtonScaleUp = null;
			}
		}
	}
}
