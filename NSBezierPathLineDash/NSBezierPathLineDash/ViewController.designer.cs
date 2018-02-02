// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NSBezierPathLineDash
{
    [Register("ViewController")]
    partial class ViewController
    {
        [Outlet]
        Foundation.NSObject MainView { get; set; }

        [Outlet]
        AppKit.NSSlider Slider { get; set; }

        [Outlet]
        AppKit.NSSlider SliderSpace { get; set; }

        [Outlet]
        AppKit.NSSlider SliderWidth { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (MainView != null)
            {
                MainView.Dispose();
                MainView = null;
            }

            if (Slider != null)
            {
                Slider.Dispose();
                Slider = null;
            }

            if (SliderSpace != null)
            {
                SliderSpace.Dispose();
                SliderSpace = null;
            }

            if (SliderWidth != null)
            {
                SliderWidth.Dispose();
                SliderWidth = null;
            }
        }
    }
}
