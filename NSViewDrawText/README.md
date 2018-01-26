# NSViewDrawText

NSViewに文字列を描画するサンプルアプリケーションです。

![](NSViewDrawText.png)

## 要点

NSViewのDrawRect()メソッドで、NSMutableAttributedString()に描画する文字の設定を行い、DrawAtPoint()で描画する座標を指定します。

    public partial class MyView : NSView
    {
        public override void DrawRect(CoreGraphics.CGRect dirtyRect)
        {
            NSMutableAttributedString attributes = new NSMutableAttributedString("Hello, World.");
            attributes.AddAttribute(NSStringAttributeKey.Font, NSFont.FromFontName("Helvetica", 96), new NSRange(0, 13));
            attributes.AddAttribute(NSStringAttributeKey.ForegroundColor, NSColor.Brown, new NSRange(0, 13));
            attributes.DrawAtPoint(new CoreGraphics.CGPoint(0, 0));
        }
    }
