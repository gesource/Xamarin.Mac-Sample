using System;

using AppKit;
using Foundation;

namespace NSViewFrameOriginSample
{
    public partial class ViewController : NSViewController
    {
        private SubView subView;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            var mainView = MainView as MainView;
            subView = new SubView
            {
                Frame = new CoreGraphics.CGRect(0, 0, 100, 100),
            };
            mainView.AddSubview(subView);

            SliderX.MinValue = 0;
            SliderX.MaxValue = mainView.Frame.Width;
            SliderY.MinValue = 0;
            SliderY.MaxValue = mainView.Frame.Height;
            SliderX.DoubleValue = 0;
            SliderY.DoubleValue = 0;
            SliderX.Activated += (sender, e) => UpdateOrigin();
            SliderY.Activated += (sender, e) => UpdateOrigin();

            NSNotificationCenter.DefaultCenter.AddObserver(
                NSWindow.DidResizeNotification,
                (obj) =>
                {
                    SliderX.MaxValue = mainView.Frame.Width;
                    SliderY.MaxValue = mainView.Frame.Height;
                });
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

        private void UpdateOrigin()
        {
            subView.SetFrameOrigin(
                new CoreGraphics.CGPoint(
                    SliderX.DoubleValue,
                    SliderY.DoubleValue));
        }
    }
}
