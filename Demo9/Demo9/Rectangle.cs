using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9
{
    internal class Rectangle
    {
        private double length;
        private double wigth;

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                length = value;
            }
        }
    }
}
