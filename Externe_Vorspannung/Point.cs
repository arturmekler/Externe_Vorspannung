using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Externe_Vorspannung.Model
{
    public class Point : IEquatable<Point>
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public bool Equals(Point other)
        {
            if (other is null)
                return false;

            return this.X == other.X
                && this.Y == other.Y
                && this.Z == other.Z;
        }
    }

}
