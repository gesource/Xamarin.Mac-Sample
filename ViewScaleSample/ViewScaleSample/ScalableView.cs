﻿using AppKit;
using CoreGraphics;

namespace ViewScaleSample
{
    /// <summary>
    /// NSViewの倍率を変更する
    /// </summary>
    public class ScalableView
    {
        static CGSize unitSize = new CGSize(1.0, 1.0);
        private NSView view;

        /// <summary>
        /// 表示倍率
        /// </summary>
        public double Scale
        {
            get => view.ConvertSizeToView(unitSize, null).Width;
            set { SetScale(value); }
        }

        public ScalableView(NSView view)
        {
            this.view = view;
        }

        /// <summary>
        /// 表示倍率を等倍にします
        /// </summary>
        private void ResetScaling()
        {
            view.ScaleUnitSquareToSize(view.ConvertSizeFromView(unitSize, null));
        }

        /// <summary>
        /// 表示倍率を設定し、表示を更新します。
        /// </summary>
        private void SetScale(double scale)
        {
            CGSize newScale = new CGSize(scale, scale);
            this.ResetScaling();
            view.ScaleUnitSquareToSize(newScale);
            view.SetNeedsDisplayInRect(view.VisibleRect());
        }
    }
}
