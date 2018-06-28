# NSViewMouseEventSample

## 概要

NSViewのマウスイベントの情報を取得するサンプルアプリケーションです。

NSViewのマウスイベントの情報をログに出力します。

![](NSViewMouseEventSample.gif)

## 要点

UpdateTrackingAreas()メソッドでトラッキングエリアの設定を行います。  
NSTrackingArea()の引数で受け取るイベントを設定します。

    public partial class MainView : NSView
    {
        public override void MouseEntered(NSEvent theEvent) => Print(theEvent);
        public override void MouseExited(NSEvent theEvent) => Print(theEvent);
        public override void MouseMoved(NSEvent theEvent) => Print(theEvent);
        public override void MouseDown(NSEvent theEvent) => Print(theEvent);
        public override void MouseUp(NSEvent theEvent) => Print(theEvent);
        public override void MouseDragged(NSEvent theEvent) => Print(theEvent);
        public override void RightMouseDown(NSEvent theEvent) => Print(theEvent);
        public override void RightMouseUp(NSEvent theEvent) => Print(theEvent);
        public override void RightMouseDragged(NSEvent theEvent) => Print(theEvent);
        public override void ScrollWheel(NSEvent theEvent) => Print(theEvent);

        /// <summary>
        /// トラッキングの設定を行います
        /// </summary>
        public override void UpdateTrackingAreas()
        {
            if (trackingArea != null)
                this.RemoveTrackingArea(trackingArea);

            trackingArea = new NSTrackingArea(
                CGRect.Empty,
                NSTrackingAreaOptions.ActiveAlways | NSTrackingAreaOptions.MouseEnteredAndExited | NSTrackingAreaOptions.MouseMoved | NSTrackingAreaOptions.InVisibleRect,
                this,
                null);
            this.AddTrackingArea(trackingArea);
        }

        private void Print(NSEvent theEvent)
        {
            // イベントの種類
            NSEventType eventType = theEvent.Type;

            // ウィンドウ座標
            var windowLocation = theEvent.LocationInWindow;
            // ビュー座標
            var viewLocation = ConvertPointFromView(theEvent.LocationInWindow, null);
            // スクリーン座標
            var screenLocation = NSEvent.CurrentMouseLocation;

            // 押されている修飾キー
            var modifier = "";
            if ((theEvent.ModifierFlags & NSEventModifierMask.ShiftKeyMask) > 0) modifier += "Shift ";
            if ((theEvent.ModifierFlags & NSEventModifierMask.CommandKeyMask) > 0) modifier += "Command ";
            if ((theEvent.ModifierFlags & NSEventModifierMask.ControlKeyMask) > 0) modifier += "Ctrl ";
            if ((theEvent.ModifierFlags & NSEventModifierMask.AlternateKeyMask) > 0) modifier += "Alt ";
            modifier = modifier.Trim();

            // マウスイベントのボタン番号
            var button = theEvent.ButtonNumber;

            // 押されているマウスのボタン
            var buttons = "";
            if ((NSEvent.CurrentPressedMouseButtons & 1) > 0) buttons += "Left ";
            if ((NSEvent.CurrentPressedMouseButtons & 2) > 0) buttons += "Right ";
            buttons = buttons.Trim();

            // マウスホイールのスクロール量
            var scrollX = theEvent.DeltaX;
            var scrollY = theEvent.DeltaY;
            var scrollZ = theEvent.DeltaZ;

            var log = 
                $"EventType={eventType} " + 
                $"View=({Format(viewLocation.X)}, {Format(viewLocation.Y)}) " +
                $"Window=({Format(windowLocation.X)}, {Format(windowLocation.Y)}) " +
                $"Screen=({Format(screenLocation.X)}, {Format(screenLocation.Y)}) " +
                $"modifier={modifier} " +
                $"buttons={buttons} " +
                $"button={button} " +
                $"Wheel=(x:{Format(scrollX)}, y:{Format(scrollY)}, z:{Format(scrollZ)})";

            Debug.WriteLine(log);
        }
    }
