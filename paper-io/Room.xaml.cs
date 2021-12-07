using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace paper_io
{
    /// <summary>
    /// Логика взаимодействия для Start.xaml
    /// </summary>
    public partial class Room : Window
    {
        Game game;
        public Room(byte n)
        {
            InitializeComponent();
            game = new Game(n);
            Drawing();
            //canvas.Source = Im
        }

        public void Drawing()
        {
            GeometryGroup gg = new GeometryGroup();
            gg.Children.Add(
                new RectangleGeometry(
                    new Rect() { X = 10, Y = 20, Height = 30, Width = 40 },
                    0, 0));
            GeometryDrawing gd = new GeometryDrawing();
            gd.Geometry = gg;
            //gd.Brush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            gd.Pen = new Pen(Brushes.Black, 0.05);
            DrawingImage gi = new DrawingImage(gd);
            gi.Freeze();


            canvas.Source = gi;

        }
    }
}
