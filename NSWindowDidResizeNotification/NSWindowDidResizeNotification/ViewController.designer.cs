// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NSWindowDidResizeNotification
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField LabelHeight { get; set; }

		[Outlet]
		AppKit.NSTextField LabelLeft { get; set; }

		[Outlet]
		AppKit.NSTextField LabelTop { get; set; }

		[Outlet]
		AppKit.NSTextField LabelWidth { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (LabelLeft != null) {
				LabelLeft.Dispose ();
				LabelLeft = null;
			}

			if (LabelTop != null) {
				LabelTop.Dispose ();
				LabelTop = null;
			}

			if (LabelWidth != null) {
				LabelWidth.Dispose ();
				LabelWidth = null;
			}

			if (LabelHeight != null) {
				LabelHeight.Dispose ();
				LabelHeight = null;
			}
		}
	}
}
