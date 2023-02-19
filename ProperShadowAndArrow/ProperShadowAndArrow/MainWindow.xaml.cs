using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProperShadowAndArrow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            TestPopup.IsOpen = true;
            Path.Data = GetPathGeometry(Grid.ActualWidth, Grid.ActualHeight, 6);
            TestPopup.HorizontalOffset = (Grid.ActualWidth + 3 * 6 - Button1.ActualWidth) / (-2);
        }

        private PathGeometry GetPathGeometry(double width, double height, double r)
        {
            width += 2 * r;
            height += 2 * r;
            PathGeometry geometry = new PathGeometry();
            PathFigure pathfigure = new PathFigure();
            pathfigure.IsClosed = true;
            pathfigure.StartPoint = new Point(r, 0);
            pathfigure.Segments.Add(new ArcSegment(new Point(0, r), new Size(r, r), 0, false, SweepDirection.Counterclockwise, true));
            pathfigure.Segments.Add(new LineSegment(new Point(0, height + r), true));
            pathfigure.Segments.Add(new ArcSegment(new Point(r, height + 2 * r), new Size(r, r), 0, false, SweepDirection.Counterclockwise, true));
            pathfigure.Segments.Add(new LineSegment(new Point(width / 2, height + 2 * r), true));
            pathfigure.Segments.Add(new LineSegment(new Point(width / 2 + r, height + 3 * r), true));
            pathfigure.Segments.Add(new LineSegment(new Point(width / 2 + 2 * r, height + 2 * r), true));
            pathfigure.Segments.Add(new LineSegment(new Point(width + r, height + 2 * r), true));
            pathfigure.Segments.Add(new ArcSegment(new Point(width + 2 * r, height + r), new Size(r, r), 0, false, SweepDirection.Counterclockwise, true));
            pathfigure.Segments.Add(new LineSegment(new Point(width + 2 * r, r), true));
            pathfigure.Segments.Add(new ArcSegment(new Point(width + r, 0), new Size(r, r), 0, false, SweepDirection.Counterclockwise, true));
            geometry.Figures.Add(pathfigure);
            return geometry;
        }

    }
}
