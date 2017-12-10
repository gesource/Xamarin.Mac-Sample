// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NSViewMouseTrackingSample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButtonCell Checkbox { get; set; }

		[Outlet]
		NSViewMouseTrackingSample.TrackingView TrackingView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Checkbox != null) {
				Checkbox.Dispose ();
				Checkbox = null;
			}

			if (TrackingView != null) {
				TrackingView.Dispose ();
				TrackingView = null;
			}
		}
	}
}
