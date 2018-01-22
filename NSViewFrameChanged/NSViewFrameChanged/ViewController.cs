using System;

using AppKit;
using Foundation;

namespace NSViewFrameChanged
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
            (MainView as MainView).OnFrameChagned += (sender, e) => PrintFrameSize();
        }

        private void PrintFrameSize()
        {
            var mainView = (MainView as MainView);
            Label.StringValue = $"Left:{mainView.Frame.Left} Top:{mainView.Frame.Top} Width:{mainView.Frame.Width} Height:{mainView.Frame.Height}";
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
