using System;

using AppKit;
using Foundation;

namespace CustomFont
{
    public partial class ViewController : NSViewController, INSWindowDelegate
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            Button.Activated += (sender, e) => 
            {
                // NSFontPanelのオブジェクトを取得する
                NSFontPanel fontPanel = NSFontManager.SharedFontManager.FontPanel(true);
                // 選択されているフォントを設定する
                fontPanel.SetPanelFont(TextField.Font, false);
                fontPanel.Delegate = this;
                // キーウィンドウにして前面に表示する
                fontPanel.MakeKeyAndOrderFront(this);
            };
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

        /// <summary>
        /// フォントが選択されたときに呼ばれる
        /// </summary>
        [Export("changeFont:")]
        public void ChangeFont(NSFontManager sender)
        {
            // 選択されたフォントを取得する
            TextField.Font = sender.ConvertFont(TextField.Font);
            TextField.StringValue = TextField.Font.FamilyName;
        }
    }
}
