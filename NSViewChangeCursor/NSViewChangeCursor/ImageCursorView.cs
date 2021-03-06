// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;

namespace NSViewChangeCursor
{
    public partial class ImageCursorView : NSView
    {
        private NSTrackingArea trackingArea;
        private NSCursor imageCursor;

        public ImageCursorView(IntPtr handle) : base(handle)
        {
            imageCursor = new NSCursor(
                NSImage.ImageNamed("cursor.png"),
                new CoreGraphics.CGPoint(7, 7));

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
            imageCursor.Set();
        }

        public override void MouseExited(NSEvent theEvent)
        {
            base.MouseExited(theEvent);
            NSCursor.ArrowCursor.Set();
        }

        public override void DrawRect(CoreGraphics.CGRect dirtyRect)
        {
            NSColor.Yellow.Set();
            NSGraphics.RectFill(this.Bounds);
        }
    }
}
