using DevsDNA;
using DevsDNA.GradientBoxViewUWP;
using System;
using Windows.Foundation;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(GradientBoxView), typeof(GradientBoxViewRenderer))]
namespace DevsDNA.GradientBoxViewUWP
{
    public class GradientBoxViewRenderer : VisualElementRenderer<GradientBoxView, Rectangle>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<GradientBoxView> e)
        {
            base.OnElementChanged(e);

            var topColor = Element.TopColor;
            var bottomColor = Element.BottomColor;

            var gradientStops = new GradientStopCollection
            {
                new GradientStop()
                {
                    Color = new Windows.UI.Color()
                    {
                        A = Convert.ToByte(topColor.A * 255),
                        R = Convert.ToByte(topColor.R * 255),
                        G = Convert.ToByte(topColor.G * 255),
                        B = Convert.ToByte(topColor.B * 255)
                    }, Offset = 0
                },
                new GradientStop()
                {
                    Color = new Windows.UI.Color()
                    {
                        A = Convert.ToByte(bottomColor.A * 255),
                        R = Convert.ToByte(bottomColor.R * 255),
                        G = Convert.ToByte(bottomColor.G * 255),
                        B = Convert.ToByte(bottomColor.B * 255)
                    }, Offset = 1
                }
            };
            var linearGradientBrush = new LinearGradientBrush(gradientStops, 90);

            linearGradientBrush.StartPoint = new Point(0, 0);
            linearGradientBrush.EndPoint = new Point(0, 1);

            Background = linearGradientBrush;
        }
    }
}
