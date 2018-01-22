using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;

namespace NSViewFrameOriginSample
{
    public partial class SubView : AppKit.NSView
    {
        public SubView() : base()
        {
        }

        public override void DrawRect(CoreGraphics.CGRect dirtyRect)
        {
            NSColor.Blue.Set();
            NSBezierPath.StrokeRect(this.Bounds);
        }
    }
}
