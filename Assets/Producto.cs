using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granaja
{
    [Serializable]
    public struct Producto
    {
        public FruitType fruit;
        public AnimalType animal;

        

        public Producto(AnimalType animal, FruitType fruit)
        {
            this.animal = animal;
            this.fruit = fruit;
        }

        public static bool operator == (Producto p, Producto p1)
        {
            return p.fruit == p1.fruit && p.animal == p1.animal;
        }

        public static bool operator != (Producto p, Producto p1)
        {
            return p.fruit != p1.fruit && p.animal != p1.animal;
        }
    }
}
