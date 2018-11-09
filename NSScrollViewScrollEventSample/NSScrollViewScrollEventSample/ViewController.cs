using System;
using System.Diagnostics;
using AppKit;
using Foundation;

namespace NSScrollViewScrollEventSample
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
            //var contentView = ScrollView.ContentView;
            NSNotificationCenter.DefaultCenter.AddObserver(
                new NSString("NSViewBoundsDidChangeNotification"),
                (NSNotification notification) =>
                {
                    var contentView = notification.Object as NSClipView;
                    var location = contentView.Bounds.Location;
                    Label.StringValue = new NSString($"location X:{location.X} Y:{location.Y}");
                },
                ScrollView.ContentView);
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
