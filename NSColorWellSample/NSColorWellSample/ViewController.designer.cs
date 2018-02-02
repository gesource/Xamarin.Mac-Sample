// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NSColorWellSample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		NSColorWellSample.ColorView ColorView { get; set; }

		[Outlet]
		AppKit.NSColorWell ColorWell { get; set; }

		[Outlet]
		AppKit.NSTextField TextFieldB { get; set; }

		[Outlet]
		AppKit.NSTextField TextFieldG { get; set; }

		[Outlet]
		AppKit.NSTextField TextFieldR { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TextFieldR != null) {
				TextFieldR.Dispose ();
				TextFieldR = null;
			}

			if (TextFieldG != null) {
				TextFieldG.Dispose ();
				TextFieldG = null;
			}

			if (TextFieldB != null) {
				TextFieldB.Dispose ();
				TextFieldB = null;
			}

			if (ColorView != null) {
				ColorView.Dispose ();
				ColorView = null;
			}

			if (ColorWell != null) {
				ColorWell.Dispose ();
				ColorWell = null;
			}
		}
	}
}
