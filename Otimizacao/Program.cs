using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otimizacao
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeImplementation.runWithDelegate();
            CodeImplementation.runWithoutDelegate();
            Console.Read();
        }
    }
}
