using System;

using AppKit;
using Foundation;

namespace StringToPath
{
    public partial class ViewController : NSViewController, INSWindowDelegate
    {
        NSFont myFont;
        PathView pathView;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            myFont = NSFont.LabelFontOfSize(12);
            pathView = PathView as PathView;
            ButtonFont.Activated += (sender, e) => ShowFontPanel();
            TextFieldString.Changed += (sender, e) => UpdateText();
            ButtonFont.Activated += (sender, e) => UpdateText();
            SetFont(myFont);
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

        void ShowFontPanel()
        {
            NSFontPanel fontPanel = NSFontPanel.SharedFontPanel;
            fontPanel.SetPanelFont(myFont, false);
            fontPanel.MakeKeyAndOrderFront(this);
            fontPanel.Delegate = this;
        }

        [Export("changeFont:")]
        public void ChangeFont(NSFontManager sender)
        {
            SetFont(sender.ConvertFont(myFont));
        }

        void SetFont(NSFont font)
        {
            myFont = font;
            LabelFont.StringValue = $"{myFont.FontName} {myFont.PointSize}pt";
            LabelString.Font = myFont;
            pathView.Font = myFont;
        }

        void UpdateText()
        {
            LabelString.StringValue = TextFieldString.StringValue;
            pathView.StringValue = TextFieldString.StringValue;
        }
    }
}
