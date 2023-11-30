using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLExample
{
    public class Rectangle
    {
        private int shortSide;
        private int longSide;

        public int ShortSide { get => shortSide; set => shortSide = value; }
        public int LongSide { get => longSide; set => longSide = value; }


        public Rectangle(int shortSide, int longSide)
        {
            this.shortSide = shortSide;
            this.longSide = longSide;
        }

        public int primeterCalculate()
        {
            return (2 * (shortSide * longSide));
        }

        public int areaCalculate()
        {
            return (shortSide * longSide);
        }
    }
}
