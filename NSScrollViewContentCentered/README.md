# NSScrollViewContentCentered

NSScrollViewのコンテンツを中央に表示するサンプルアプリケーションです。

![](NSScrollViewContentCentered.gif)

## 参考

下記のプロジェクトをXamarin.Macに移植しました。

* [https://github.com/Nunocky/ImageCenteredInScrollView](https://github.com/Nunocky/ImageCenteredInScrollView)

## 要点

NSScrollViewの中にNSClipView・Scrollerがあり、NSClipViewの中にNSViewがあります。

NSScrollViewのContentViewはNSClipView、NSScrollViewのDocumentViewはNSViewです。

    - NSScrollView
      - NSClipView (ContentView)
        - NSView (DocumentView)
      - Scroller
      - Scroller

NSClipViewのConstrainBoundsRect()でClipViewの範囲を制限することで、DocumentViewを中央に描画します。

    public partial class MyClipView : AppKit.NSClipView
    {
        public override CoreGraphics.CGRect ConstrainBoundsRect(CoreGraphics.CGRect proposedBounds)
        {
            var documentBounds = this.DocumentView.Bounds;
            var delta = new CGPoint(
                documentBounds.Width - proposedBounds.Width,
                documentBounds.Height - proposedBounds.Height);
            var x = (delta.X < 0) ? (delta.X / 2) : Math.Max(0, Math.Min(proposedBounds.X, delta.X));
            var y = (delta.Y < 0) ? (delta.Y / 2) : Math.Max(0, Math.Min(proposedBounds.Y, delta.Y));
            proposedBounds.X = (System.nfloat)x;
            proposedBounds.Y = (System.nfloat)y;
            return proposedBounds;
        }
    }
