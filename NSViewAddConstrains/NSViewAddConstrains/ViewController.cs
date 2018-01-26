using System;

using AppKit;
using Foundation;

namespace NSViewAddConstrains
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

            var mainView = MainView as BoxView;

            var blueView = new BoxView(NSColor.Blue);
            mainView.AddSubview(blueView);
            blueView.SetFrameOrigin(new CoreGraphics.CGPoint(0, 0));

            var greenView = new BoxView(NSColor.Green);
            mainView.AddSubview(greenView);

            greenView.TranslatesAutoresizingMaskIntoConstraints = false;
            blueView.TranslatesAutoresizingMaskIntoConstraints = false;

            // 制約を設定するViewとFromVisualFormat()の引数で使用するときの名前
            var viewsDictionary = NSDictionary.FromObjectsAndKeys(
                new NSObject[] { greenView, blueView },
                new NSObject[] { new NSString("green"), new NSString("blue") }
            );

            // 変数を使用する方法
            // blueViewの左paddingは0、右paddingは30
            var metricsDic = NSDictionary.FromObjectsAndKeys(
                new NSObject[] { new NSNumber(0), new NSNumber(30), },
                new NSObject[] { new NSString("leftPadding"), new NSString("rightPadding") }
            );
            mainView.AddConstraints(NSLayoutConstraint.FromVisualFormat(
                "H:|-leftPadding-[blue]-rightPadding-|", 0, metricsDic, viewsDictionary));

            // 値を直接組み込む方法
            // greenViewの左paddingは30、右paddingは100
            mainView.AddConstraints(NSLayoutConstraint.FromVisualFormat("H:|-(==30)-[green]-(==100)-|", 0, new NSDictionary(), viewsDictionary));

            // greenViewのpaddingはblueViewと同じ
            //mainView.AddConstraints(NSLayoutConstraint.FromVisualFormat("|-[green(==blue)]-|", 0, new NSDictionary(), viewsDictionary));

            mainView.AddConstraints(NSLayoutConstraint.FromVisualFormat("V:|-[blue]-(==30)-[green(==blue)]-|", 0, new NSDictionary(), viewsDictionary));
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
