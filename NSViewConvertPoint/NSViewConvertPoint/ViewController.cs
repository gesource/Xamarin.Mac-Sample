using System;

using AppKit;
using Foundation;

namespace NSViewConvertPoint
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
            var mainView = MainView;
            mainView.OnMouseMoved += (sender, e) =>
            {
                Label1.StringValue = $"LocationInWindow = ({e.LocationInWindow.X}, {e.LocationInWindow.Y})";
                Label2.StringValue = $"MouseLocation = ({e.MouseLocation.X}, {e.MouseLocation.Y})";
                Label3.StringValue = $"LocationInView = ({e.LocationInView.X}, {e.LocationInView.Y})";
            };
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
    }
}
