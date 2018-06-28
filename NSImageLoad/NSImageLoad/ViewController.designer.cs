// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NSImageLoad
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSImageView ImageView { get; set; }

		[Action ("Button1Click:")]
		partial void Button1Click (Foundation.NSObject sender);

		[Action ("Button2Click:")]
		partial void Button2Click (Foundation.NSObject sender);

		[Action ("Button3Click:")]
		partial void Button3Click (Foundation.NSObject sender);

		[Action ("Button4Click:")]
		partial void Button4Click (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ImageView != null) {
				ImageView.Dispose ();
				ImageView = null;
			}
		}
	}
}
