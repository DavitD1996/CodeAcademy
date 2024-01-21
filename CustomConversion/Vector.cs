using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.CustomConversion
{
    public class Vector
    {
        public Double x { get; set; }
        public Double y { get; set; }
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static explicit operator Coordinate(Vector c)
        {
            return new Coordinate(c.x, c.y);
        }
    }
}
