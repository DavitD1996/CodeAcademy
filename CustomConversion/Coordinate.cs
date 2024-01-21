using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.CustomConversion
{
    public class Coordinate
    {
        public Double x { get; set; }
        public Double y { get; set; }
        public Coordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static implicit operator Vector(Coordinate c)
        {
            return new Vector(c.x, c.y);
        }
    }
}
