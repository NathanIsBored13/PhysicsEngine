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
    public struct Point
    {
        public double x;
        public double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Engine
    {
        private double gravity;
        private Canvas canvas;
        private List<PhysicsObject> objects;
        
        public Engine(double gravity, Canvas canvas)
        {
            this.gravity = gravity;
            this.canvas = canvas;
            objects = new List<PhysicsObject>();
        }

        public void Add(PhysicsObject physicsObject)
        {
            objects.Add(physicsObject);
            physicsObject.SetCanvas(canvas);
        }

        public void Draw()
        {
            foreach (PhysicsObject physicsObject in objects)
            {
                physicsObject.Draw();
            }
        }
    }
}
