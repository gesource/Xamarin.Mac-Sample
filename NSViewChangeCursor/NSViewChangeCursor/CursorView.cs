// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;

namespace NSViewChangeCursor
{
    public partial class CursorView : NSView
    {
        private NSTrackingArea trackingArea;

        public CursorView(IntPtr handle) : base(handle)
        {
            InitTracking();
        }

        /// <summary>
        /// トラッキングの設定を行います
        /// </summary>
        private void InitTracking()
        {
            trackingArea = new NSTrackingArea(
                            Bounds,
                            NSTrackingAreaOptions.ActiveAlways | NSTrackingAreaOptions.MouseEnteredAndExited | NSTrackingAreaOptions.MouseMoved,
                            this,
                            null);
            AddTrackingArea(trackingArea);
        }

        public override void MouseEntered(NSEvent theEvent)
        {
            base.MouseEntered(theEvent);
            NSCursor.CrosshairCursor.Set();
        }

        public override void MouseExited(NSEvent theEvent)
        {
            base.MouseExited(theEvent);
            NSCursor.ArrowCursor.Set();
        }

        public override void DrawRect(CoreGraphics.CGRect dirtyRect)
        {
            NSColor.Green.Set();
            NSGraphics.RectFill(this.Bounds);
        }
    }
}
