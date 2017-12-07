using DevsDNA;
using DevsDNA.GradientBoxViewAndroid;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(GradientBoxView), typeof(GradientBoxViewRenderer))]
namespace DevsDNA.GradientBoxViewAndroid
{
    using Android.Content;
    using Android.Graphics;
    using Xamarin.Forms.Platform.Android;

    public class GradientBoxViewRenderer : VisualElementRenderer<GradientBoxView>
    {
        public GradientBoxViewRenderer(Context context) : base(context)
        { }

        protected override void DispatchDraw(Canvas canvas)
        {
            var gradient = new LinearGradient(0, 0, 0, Height, 
                                              Element.TopColor.ToAndroid(),
                                              Element.BottomColor.ToAndroid(),
                                              Shader.TileMode.Mirror);
            var paint = new Paint
            {
                Dither = true,
            };
            paint.SetShader(gradient);
            canvas.DrawPaint(paint);

            base.DispatchDraw(canvas);
        }
    }
}