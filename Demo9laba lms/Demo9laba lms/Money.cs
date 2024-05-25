using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9laba_lms
{
    internal class Money
    {
        public int rub;
        public int kop;
        public Money(int rub, int kop) //конструктор с параметрами
        {
            this.rub = rub;
            this.kop = kop;
        }
        public Money() { rub = 0; kop = 0; } //конструктор без параметров

        public Money(Money m) { rub = m.rub; kop = m.kop; }
        public void Show()
        {
            Console.WriteLine($"{rub} рублей, {kop} копеек.");
        }
        public void Addkop(int kop)
        {
            this.kop += kop;
        }
    }
}
