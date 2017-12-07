using DevsDNA;
using DevsDNA.GradientBoxViewiOS;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(GradientBoxView), typeof(GradientBoxViewRenderer))]
namespace DevsDNA.GradientBoxViewiOS
{
    using CoreAnimation;
    using CoreGraphics;
    using Xamarin.Forms.Platform.iOS;

    public class GradientBoxViewRenderer : VisualElementRenderer<GradientBoxView>
    {
        public override void Draw(CGRect rect)
        {
            base.Draw(rect);

            var topColor = Element.TopColor.ToCGColor();
            var bottomColor = Element.BottomColor.ToCGColor();
            var gradientLayer = new CAGradientLayer
            {
                Frame = rect,
                Colors = new CGColor[] { topColor, bottomColor }
            };
            NativeView.Layer.InsertSublayer(gradientLayer, 0);
        }
    }
}