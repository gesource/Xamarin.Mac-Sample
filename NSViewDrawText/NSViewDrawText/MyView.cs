// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;

namespace NSViewDrawText
{
    public partial class MyView : NSView
    {
        public MyView(IntPtr handle) : base(handle)
        {
        }

        public override void DrawRect(CoreGraphics.CGRect dirtyRect)
        {
            NSMutableAttributedString attributes = new NSMutableAttributedString("Hello, World.");
            attributes.AddAttribute(NSStringAttributeKey.Font, NSFont.FromFontName("Helvetica", 96), new NSRange(0, 13));
            attributes.AddAttribute(NSStringAttributeKey.ForegroundColor, NSColor.Brown, new NSRange(0, 13));
            attributes.DrawAtPoint(new CoreGraphics.CGPoint(0, 0));
        }
    }
}
