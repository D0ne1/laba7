    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9laba_lms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money m = new Money(0,0);
            m.Show();
            m.Addkop(50);
            m.Show();
            m.rub = 10;
            m.Show();

            Money m2 = new Money(5,10);
            m2.Show();

            Money m3 = new Money(m2);
            m3.Show();
        }
    }
}
