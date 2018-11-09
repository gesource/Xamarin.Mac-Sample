// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MouseStateSample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField LabelMouseLeftButton { get; set; }

		[Outlet]
		AppKit.NSTextField LabelMouseLocation { get; set; }

		[Outlet]
		AppKit.NSTextField LabelMouseRightButton { get; set; }

		[Action ("ButtonClick:")]
		partial void ButtonClick (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (LabelMouseLeftButton != null) {
				LabelMouseLeftButton.Dispose ();
				LabelMouseLeftButton = null;
			}

			if (LabelMouseRightButton != null) {
				LabelMouseRightButton.Dispose ();
				LabelMouseRightButton = null;
			}

			if (LabelMouseLocation != null) {
				LabelMouseLocation.Dispose ();
				LabelMouseLocation = null;
			}
		}
	}
}
