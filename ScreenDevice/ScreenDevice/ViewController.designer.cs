// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ScreenDevice
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton Button { get; set; }

		[Outlet]
		AppKit.NSTextField TextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Button != null) {
				Button.Dispose ();
				Button = null;
			}

			if (TextField != null) {
				TextField.Dispose ();
				TextField = null;
			}
		}
	}
}
