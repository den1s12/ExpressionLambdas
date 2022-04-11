using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionLabdas1._1
{
    public delegate bool CompareDelegate(string a, string b);

    class Program
    {
        static void Main(string[] args)
        {
            CompareDelegate cD = (x, y) => x == y;
            bool result = cD("Hello", "hello");
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
