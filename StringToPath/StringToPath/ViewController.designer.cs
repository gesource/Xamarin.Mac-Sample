// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace StringToPath
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton ButtonDraw { get; set; }

		[Outlet]
		AppKit.NSButton ButtonFont { get; set; }

		[Outlet]
		AppKit.NSTextField LabelFont { get; set; }

		[Outlet]
		AppKit.NSTextField LabelString { get; set; }

		[Outlet]
		Foundation.NSObject PathView { get; set; }

		[Outlet]
		AppKit.NSTextField TextFieldString { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ButtonFont != null) {
				ButtonFont.Dispose ();
				ButtonFont = null;
			}

			if (LabelFont != null) {
				LabelFont.Dispose ();
				LabelFont = null;
			}

			if (TextFieldString != null) {
				TextFieldString.Dispose ();
				TextFieldString = null;
			}

			if (ButtonDraw != null) {
				ButtonDraw.Dispose ();
				ButtonDraw = null;
			}

			if (LabelString != null) {
				LabelString.Dispose ();
				LabelString = null;
			}

			if (PathView != null) {
				PathView.Dispose ();
				PathView = null;
			}
		}
	}
}
