using System;
using AppKit;
using Foundation;

namespace NSBezierPathBoundsProperty
{
    public partial class RectangleView : BaseView
    {
        #region Constructors

        // Called when created from unmanaged code
        public RectangleView(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public RectangleView(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion

        public override void DrawRect(CoreGraphics.CGRect dirtyRect)
        {
            NSBezierPath path = NSBezierPath.FromRect(new CoreGraphics.CGRect(-200, -200, 200, 200));

            var rotation = new NSAffineTransform();
            rotation.RotateByDegrees((System.nfloat)30);

            var transtation = new NSAffineTransform();
            transtation.Translate(250, 300);
            rotation.AppendTransform(transtation);

            path.TransformUsingAffineTransform(rotation);

            DrawPath(path);
        }
    }
}
