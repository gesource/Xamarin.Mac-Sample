using System;

using AppKit;
using Foundation;

namespace NSBezierPathLineDash
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
            var mainView = MainView as MainView;
            Slider.DoubleValue = mainView.LineWidth;
            SliderWidth.DoubleValue = mainView.DashWidth;
            SliderSpace.DoubleValue = mainView.DashSpace;
            Slider.Activated += (sender, e) => mainView.LineWidth = (nfloat)Slider.DoubleValue;
            SliderWidth.Activated += (sender, e) => mainView.DashWidth = (nfloat)SliderWidth.DoubleValue;
            SliderSpace.Activated += (sender, e) => mainView.DashSpace = (nfloat)SliderSpace.DoubleValue;
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
