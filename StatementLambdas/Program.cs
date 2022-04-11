using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementLambdas
{
    public delegate void HelloDelegte(string s);
    class Program
    {
        static void Main(string[] args)
        {
            HelloDelegte hD = (x) => { Console.WriteLine("Привет, " + x); };
            hD("Вася");
            Console.ReadKey();
        }
    }
}
