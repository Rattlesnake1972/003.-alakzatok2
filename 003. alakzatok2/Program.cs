using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003.alakzatok2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("*o");

            }
            Console.WriteLine("\n");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("*o");

            }

            Console.ReadKey();
        }
    }
}

/*Ez a kód két sorban egymás alatt kiír egy mintát a konzolra. A minta egy sorban összesen tíz karakterből áll: az összes páros helyen lévő karakter "*" karakter, az összes páratlan helyen lévő karakter "o" karakter.

A program a következőket csinálja:

Létrehoz egy C# konzolalkalmazást.
Az első "for" ciklusban kiír egy sort a konzolra, amelyben egymás után jelennek meg a "*o" karakterek. Ez ötször ismétlődik.
Azután egy sort kiír, amelyben ismét egymás után jelennek meg a "*o" karakterek. Ez is ötször ismétlődik.
Végül a program vár a felhasználó bemenetére a "Console.ReadKey()" parancs segítségével. Amíg a felhasználó nem nyom le egy billentyűt, addig a program nem fejeződik be, és a konzolablak nyitva marad. Amint a felhasználó lenyom egy billentyűt, a program végrehajtása befejeződik.*/
