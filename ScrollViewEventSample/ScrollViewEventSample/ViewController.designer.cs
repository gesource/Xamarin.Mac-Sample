// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ScrollViewEventSample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField Label { get; set; }

		[Outlet]
		AppKit.NSScrollView ScrollView { get; set; }

		[Outlet]
		AppKit.NSButton StartButton { get; set; }

		[Outlet]
		AppKit.NSButton StopButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (StartButton != null) {
				StartButton.Dispose ();
				StartButton = null;
			}

			if (StopButton != null) {
				StopButton.Dispose ();
				StopButton = null;
			}

			if (Label != null) {
				Label.Dispose ();
				Label = null;
			}

			if (ScrollView != null) {
				ScrollView.Dispose ();
				ScrollView = null;
			}
		}
	}
}
