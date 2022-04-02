using System;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Stendinator.Gui
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            var geometryGroup = new GeometryGroup();
            geometryGroup.Children.Add(new EllipseGeometry
            {
                Center = new Point
                {
                    X = 50,
                    Y = 50
                },
                RadiusX = 50,
                RadiusY = 50
            });
            geometryGroup.Children.Add(new RectangleGeometry
            {
                Rect = new Rect 
                {
                    X = 0,
                    Y = 0, 
                    Width = 100,
                    Height = 100
                }
            });

            var o = new Path
            {
                Fill = new SolidColorBrush(Colors.Black),
                Width = 100,
                Height = 100,
                Data = geometryGroup
            };
            Menu.ColumnDefinitions.Add(new ColumnDefinition());
            Menu.ColumnDefinitions.Add(new ColumnDefinition());
            Menu.ColumnDefinitions.Add(new ColumnDefinition());

            MainCanvas.Background = new SolidColorBrush(Colors.White);
            MainCanvas.Children.Add(o);
            Grid.SetColumnSpan(MainCanvas, 3);
            var firstText = new TextBlock
            {
                Text = "Hoi Jordy en Henk!",
                Foreground = new SolidColorBrush(Colors.Blue)
            };

            Menu.Children.Add(firstText);

            Grid.SetColumn(firstText, 0);

            var secondText = new TextBlock
            {
                Text = "Hoi Jordy en Henk!",
                Foreground = new SolidColorBrush(Colors.Blue)
            };

            Menu.Children.Add(secondText);

            Grid.SetColumn(secondText, 1);

            var thirddText = new TextBlock
            {
                Text = "Hoi Jordy en Henk!",
                Foreground = new SolidColorBrush(Colors.Blue)
            };

            Menu.Children.Add(thirddText);

            Grid.SetColumn(thirddText, 2);

            Canvas.SetLeft(o, 100);
            Canvas.SetTop(o, 100);
            Canvas.SetZIndex(o, 1);
        }
    }
}