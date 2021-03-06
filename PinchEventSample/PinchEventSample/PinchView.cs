// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;

namespace PinchEventSample
{
    public partial class PinchView : NSView
    {
        private nfloat value = 0;

        public PinchView(IntPtr handle) : base(handle)
        {
        }

        public override void DrawRect(CoreGraphics.CGRect dirtyRect)
        {
            NSColor.Brown.Set();
            NSGraphics.FrameRect(Bounds);

            string s = value.ToString();
            NSMutableAttributedString attributes = new NSMutableAttributedString(value.ToString());
            attributes.AddAttribute(NSStringAttributeKey.Font, NSFont.FromFontName("Helvetica", 96), new NSRange(0, s.Length));
            attributes.AddAttribute(NSStringAttributeKey.ForegroundColor, NSColor.Brown, new NSRange(0, s.Length));
            attributes.DrawAtPoint(new CoreGraphics.CGPoint(10, 10));
        }

        public override void MagnifyWithEvent(NSEvent theEvent)
        {
            value = theEvent.Magnification;
            NeedsDisplay = true;
        }
    }
}
