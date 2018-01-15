using System;

using AppKit;
using Foundation;

namespace ViewScaleSample
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
            Slider.Activated += (sender, e) => Button.Title = String.Format("{0:F2}", Slider.DoubleValue);
            Button.Activated += (sender, e) => MainView.Scale = Slider.DoubleValue;
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
