using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace ProperShadowAndArrow
{
    public class WidthHeightExtender : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                string[] str = (parameter as string).Split(',');
                if (str[0].Equals("+"))
                    return System.Convert.ToDouble(value) + System.Convert.ToDouble(str[1]);
                else if (str[0].Equals("-"))
                    return System.Convert.ToDouble(value) - System.Convert.ToDouble(str[1]);
                else
                    return System.Convert.ToDouble(value);
            }
            catch (Exception ex)
            {
                return System.Convert.ToDouble(value);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion

    }

    public class CenterToolTipConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.FirstOrDefault(v => v == DependencyProperty.UnsetValue) != null)
            {
                return double.NaN;
            }
            double placementTargetWidth = (double)values[0];
            double toolTipWidth = (double)values[1];
            return (placementTargetWidth / 2.0) - (toolTipWidth / 2.0) + 6;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }

    public class GetPathGeometryConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double width = (double)values[0];
            double height = (double)values[1];
            double r = 6;
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

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
