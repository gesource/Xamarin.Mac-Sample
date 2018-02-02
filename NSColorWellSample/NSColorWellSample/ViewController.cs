using System;

using AppKit;
using Foundation;

namespace NSColorWellSample
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            ColorWell.Activated += (sender, e) =>
            {
                ColorView.Color = ColorWell.Color;
                PrintColor(ColorWell.Color);
            };
            ColorWell.Color = NSColor.White;
            PrintColor(ColorWell.Color);
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        private void PrintColor(NSColor color)
        {
            color = color.UsingColorSpace(NSColorSpace.GenericRGBColorSpace);
            TextFieldR.IntValue = (int)(color.RedComponent * 255);
            TextFieldG.IntValue = (int)(color.GreenComponent * 255);
            TextFieldB.IntValue = (int)(color.BlueComponent * 255);
        }
    }
}
