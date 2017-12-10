using System;

using AppKit;
using Foundation;

namespace ScrollViewEventSample
{
    public partial class ViewController : NSViewController
    {
        private ScrollViewEventObserver eventObserver;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.

            eventObserver = new ScrollViewEventObserver();
            eventObserver.ScrollChanged += (sender, e) => {
                Label.StringValue = $"{e.X}, {e.Y}";
            };
            StartButton.Activated += (sender, e) => eventObserver.Start(ScrollView);
            StopButton.Activated += (sender, e) => eventObserver.Stop();
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
