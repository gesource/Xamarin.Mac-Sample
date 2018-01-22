// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NSViewFrameOriginSample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		Foundation.NSObject MainView { get; set; }

		[Outlet]
		AppKit.NSSlider SliderX { get; set; }

		[Outlet]
		AppKit.NSSlider SliderY { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (SliderX != null) {
				SliderX.Dispose ();
				SliderX = null;
			}

			if (SliderY != null) {
				SliderY.Dispose ();
				SliderY = null;
			}

			if (MainView != null) {
				MainView.Dispose ();
				MainView = null;
			}
		}
	}
}
