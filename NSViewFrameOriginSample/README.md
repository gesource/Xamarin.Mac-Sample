# NSViewFrameOriginSample

NSViewのSetFrameOrigin()を使って、NSViewの位置を更新するサンプルアプリケーションです。

![](NSViewFrameOriginSample.gif)

## 要点

NSViewのSetFrameOrigin()メソッドを使って、subViewを移動しています。

    subView.SetFrameOrigin(
        new CoreGraphics.CGPoint(
            SliderX.DoubleValue,
            SliderY.DoubleValue));

