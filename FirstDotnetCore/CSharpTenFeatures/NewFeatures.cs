using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTenFeatures
{
    internal class NewFeatures
    {
    }

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public readonly double Distance =>
         Math.Sqrt(X * X + Y * Y);


        public readonly override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";
    }
}
