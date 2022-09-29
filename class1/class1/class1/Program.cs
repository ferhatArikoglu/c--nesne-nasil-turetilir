using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    class Program
    {
        static void Main(string[] args)
        {
            // sınıfdan nesne nasıl turetilir adlı calışma
            araba a = new araba(); //arabadan nesne turettikı
            a.renk = "mavi";
            a.otomatikmi = "araç otomatik ileri";
            a.km = 1500000;

            Console.WriteLine("arabanın rengi : " + a.renk);
            Console.WriteLine("arabanın r : " + a.otomatikmi);
            Console.WriteLine("arabanın kmsi : " + a.km);
            Console.ReadLine();
        }
    }
}
