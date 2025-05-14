using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var z = new Zadanie5();
            int[] array = { 1, 2, 3, 4 };
            int [] reversed = z.Reverse(array);

            Console.WriteLine($"Odwrócona tablica: " + string.Join(", ", reversed));
            Console.WriteLine($"Kliknij dowolny przycisk by zakończyć proces..... ");
            Console.ReadKey();
        }
    }
}
