using System;

using AppKit;
using Foundation;

namespace NSScrollViewContentCentered
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
            ButtonScaleUp.Activated += (sender, e) => { ScrollView.Magnification += (System.nfloat)0.1; };
            ButtonScaleDown.Activated += (sender, e) => { ScrollView.Magnification -= (System.nfloat)0.1; };
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
