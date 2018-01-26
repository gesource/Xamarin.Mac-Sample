using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using CoreGraphics;

namespace NSScrollViewContentCentered
{
    public partial class MyClipView : AppKit.NSClipView
    {
        public MyClipView(IntPtr handle) : base(handle)
        {
        }

        public override bool IsFlipped { get => true; }

        public override void DrawRect(CoreGraphics.CGRect dirtyRect)
        {
            NSColor.Gray.SetFill();
            NSGraphics.RectFill(this.Bounds);
        }

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
}
