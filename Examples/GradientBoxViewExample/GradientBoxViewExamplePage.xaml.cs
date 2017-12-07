using System;
using DevsDNA;
using Xamarin.Forms;

namespace GradientBoxViewExample
{
    public partial class GradientBoxViewExamplePage : ContentPage
    {
        public GradientBoxViewExamplePage()
        {
            InitializeComponent();

            CreateGradientMatrix();
        }

        void CreateGradientMatrix()
        {
            var rows = 16;
            var columns = 16;

            for (int i = 0; i < rows; i++)
            {
                var rowDefinition = new RowDefinition();
                grid.RowDefinitions.Add(rowDefinition);

                var columnDefinition = new ColumnDefinition { Width = GridLength.Star };
                grid.ColumnDefinitions.Add(columnDefinition);

                for (int j = 0; j < columns; j++)
                {
                    var hue = (1d / columns) * j;
                    var saturation = (1d / rows) * i;
                    var gradientBoxView = new GradientBoxView
                    {
                        TopColor = Color.White,
                        BottomColor = Color.FromHsla(hue, 0.5d, 0.5d)
                    };
                    grid.Children.Add(gradientBoxView, i, j);
                }
            }
        }
    }
}
