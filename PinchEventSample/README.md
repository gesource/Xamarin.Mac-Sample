# PinchEventSample

二本指で縮小(ピンチイン/pinch-in)や拡大(ピンチアウト/pinch-out)したときのイベントを受け取るサンプルアプリケーションです。

NSView上でピンチイン・ピンチアウトすると、倍率を表示します。

![](PinchEventSample.png)

## 説明

ピンチイン・ピンチアウトの操作が行われると、MagnifyWithEventメソッドが呼ばれます。

引数NSEventのMagnificationプロパティで倍率を取得できます。

        public override void MagnifyWithEvent(NSEvent theEvent)
        {
            value = theEvent.Magnification;
            NeedsDisplay = true;
        }
