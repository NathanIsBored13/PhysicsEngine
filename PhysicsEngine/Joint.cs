using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsEngine
{
    class Joint
    {
        protected List<PhysicsObject> objects;
        public void AddObject(PhysicsObject physicsObject)
        {
            objects.Add(physicsObject);
        }
    }
}
