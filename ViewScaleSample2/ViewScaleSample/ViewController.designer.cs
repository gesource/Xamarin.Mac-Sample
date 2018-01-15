// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ViewScaleSample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton Button { get; set; }

		[Outlet]
		ViewScaleSample.MainView MainView { get; set; }

		[Outlet]
		AppKit.NSSlider Slider { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (MainView != null) {
				MainView.Dispose ();
				MainView = null;
			}

			if (Button != null) {
				Button.Dispose ();
				Button = null;
			}

			if (Slider != null) {
				Slider.Dispose ();
				Slider = null;
			}
		}
	}
}
