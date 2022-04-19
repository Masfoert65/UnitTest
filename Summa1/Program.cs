using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyMath.MyFunc;
namespace Summa1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b;
            Console.WriteLine("Введите a:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            b=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Otv(a, b));

            Console.ReadKey();
        }
    }
}
