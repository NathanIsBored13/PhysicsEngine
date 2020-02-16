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

namespace PhysicsEngine
{
    class PhysicsLine : PhysicsObject
    {
        private double length;
        private Line line;
        public PhysicsLine(Point center, double angle, int weight, int length) : base(center, weight, angle)
        {
            this.length = length / 2;
            line = new Line()
            {
                Stroke = Brushes.Red,
                StrokeThickness = 10
            };
        }

        public override void SetCanvas(Canvas canvas)
        {
            canvas.Children.Add(line);
        }

        public override void Draw()
        {
            Console.WriteLine($"{angle}");
            line.X1 = center.x - length * Math.Cos(angle);
            line.Y1 = center.y - length * Math.Sin(angle);
            line.X2 = center.x + length * Math.Cos(angle);
            line.Y2 = center.y + length * Math.Sin(angle);
        }
    }
}
