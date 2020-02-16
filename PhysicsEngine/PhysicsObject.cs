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
    abstract class PhysicsObject
    {
        protected List<Tuple<Joint, Point>> joints;
        protected Point center;
        protected double angle;
        protected double weight;

        public PhysicsObject(Point center, double weight, double angle)
        {
            this.center = center;
            this.weight = weight;
            this.angle = angle;
        }

        public void AddJoint(Joint joint, Point point)
        {
            joints.Add(Tuple.Create(joint, point));
        }

        public abstract void SetCanvas(Canvas canvas);

        public abstract void Draw();
    }
}
