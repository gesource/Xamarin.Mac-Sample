using System;

using AppKit;
using Foundation;

namespace MouseStateSample
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
            (NSApplication.SharedApplication.Delegate as AppDelegate).ViewController = this;
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

        partial void ButtonClick(AppKit.NSButton sender) => ShowMouseState();

        internal void ShowMouseState()
        {
            var location = NSEvent.CurrentMouseLocation;
            LabelMouseLocation.StringValue = $"X:{location.X} Y:{location.Y}";

            var buttons = NSEvent.CurrentPressedMouseButtons;
            var left = ((buttons & (1 << 0)) > 0) ? "on" : "";
            var right = ((buttons & (1 << 1)) > 0) ? "on" : "";
            LabelMouseLeftButton.StringValue = $"Left:{left}";
            LabelMouseRightButton.StringValue = $"Right:{right}";
        }
    }
}
