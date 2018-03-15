// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MacVersion
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton ButtonCheckVersioni { get; set; }

		[Outlet]
		AppKit.NSTextField TextFieldMajor { get; set; }

		[Outlet]
		AppKit.NSTextField TextFieldMinor { get; set; }

		[Outlet]
		AppKit.NSTextField TextFieldPatchVersion { get; set; }

		[Outlet]
		AppKit.NSTextView TextView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TextFieldMajor != null) {
				TextFieldMajor.Dispose ();
				TextFieldMajor = null;
			}

			if (TextFieldMinor != null) {
				TextFieldMinor.Dispose ();
				TextFieldMinor = null;
			}

			if (TextFieldPatchVersion != null) {
				TextFieldPatchVersion.Dispose ();
				TextFieldPatchVersion = null;
			}

			if (ButtonCheckVersioni != null) {
				ButtonCheckVersioni.Dispose ();
				ButtonCheckVersioni = null;
			}

			if (TextView != null) {
				TextView.Dispose ();
				TextView = null;
			}
		}
	}
}
