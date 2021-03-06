// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;

namespace NSBezierPathLineDash
{
    public partial class MainView : NSView
    {
        public double LineWidth { get => lineWidth; set { lineWidth = value; NeedsDisplay = true; } }
        public double DashWidth { get => dashWidth; set { dashWidth = value; NeedsDisplay = true; } }
        public double DashSpace { get => dashSpace; set { dashSpace = value; NeedsDisplay = true; } }
        private double lineWidth = 10;
        private double dashWidth = 2;
        private double dashSpace = 1;

        public MainView(IntPtr handle) : base(handle)
        {
        }

        public override void DrawRect(CoreGraphics.CGRect dirtyRect)
        {
            DrawLine();

            NSColor.Gray.Set();
            DrawText($"Line Width = {LineWidth}", 64);
            DrawText($"Dash Width = {DashWidth}", 32);
            DrawText($"Dash Space = {DashSpace}", 0);
        }

        private void DrawText(string text, double top)
        {
            NSMutableAttributedString attributes = new NSMutableAttributedString(text);
            attributes.AddAttribute(NSStringAttributeKey.Font, NSFont.FromFontName("Helvetica", 32), new NSRange(0, text.Length));
            attributes.AddAttribute(NSStringAttributeKey.ForegroundColor, NSColor.Brown, new NSRange(0, text.Length));
            attributes.DrawAtPoint(new CoreGraphics.CGPoint(0, top));
        }

        private void DrawLine()
        {
            NSColor.Blue.Set();
            NSBezierPath path = NSBezierPath.FromRect(Bounds);
            path.LineWidth = (nfloat)LineWidth;

            nfloat[] pattern = { (nfloat)DashWidth, (nfloat)DashSpace };
            nfloat phase = 0;
            path.SetLineDash(pattern, phase);

            path.Stroke();
        }
    }
}
