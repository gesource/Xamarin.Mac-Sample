// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ImageResize
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton CheckBoxAspectRatio { get; set; }

		[Outlet]
		AppKit.NSImageView ImageView { get; set; }

		[Outlet]
		AppKit.NSTextField TextFieldHeight { get; set; }

		[Outlet]
		AppKit.NSTextField TextFieldWidth { get; set; }

		[Action ("OpenImageFileButtonClick:")]
		partial void OpenImageFileButtonClick (Foundation.NSObject sender);

		[Action ("SaveImageButtonClick:")]
		partial void SaveImageButtonClick (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (CheckBoxAspectRatio != null) {
				CheckBoxAspectRatio.Dispose ();
				CheckBoxAspectRatio = null;
			}

			if (ImageView != null) {
				ImageView.Dispose ();
				ImageView = null;
			}

			if (TextFieldHeight != null) {
				TextFieldHeight.Dispose ();
				TextFieldHeight = null;
			}

			if (TextFieldWidth != null) {
				TextFieldWidth.Dispose ();
				TextFieldWidth = null;
			}
		}
	}
}
