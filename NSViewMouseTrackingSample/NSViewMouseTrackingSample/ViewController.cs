using System;
using System.Diagnostics;
using AppKit;
using Foundation;

namespace NSViewMouseTrackingSample
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
            TrackingView.OnDragChange += (sender, e) =>
            {
                Debug.WriteLine(e);
            };

            Checkbox.Activated += (sender, e) =>
            {
                TrackingView.IsTracking = (Checkbox.State == NSCellStateValue.On);
            };
            Checkbox.State = NSCellStateValue.Off;
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
