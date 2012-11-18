using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otimizacao
{
    public class CodeImplementation
    {
        //Constant for be find.
        private const string _thisValue = "99999";

        //Runs a list (Find with delegate) with 1,000,000 elements and checks whether the element 99,999
        public static void runWithDelegate()
        {
            List<string> listStr = new List<string>();
            for (int i = 0; i < 1000000; i++)
                listStr.Add((i + 1).ToString());

            DateTime timeStart = DateTime.Now;
            string itemFound = listStr.Find(delegate(String itemAtual) { return itemAtual == _thisValue; });
            DateTime timeEnding = DateTime.Now;
            int timeRun = timeEnding.Millisecond - timeStart.Millisecond;

            if (String.IsNullOrEmpty(itemFound))
                Console.WriteLine(String.Format("\nFind with Delegate - Register not found. :: after {0} milisegundos", timeRun));
            else
                Console.WriteLine(String.Format("\nFind with Delegate - Found value {0:N2} :: after {1} milisegundos", itemFound, timeRun));
        }

        //Runs a list (For) with 1,000,000 elements and checks whether the element 99,999
        public static void runWithoutDelegate()
        {
            List<string> listStr = new List<string>();
            for (int i = 0; i < 1000000; i++)
                listStr.Add((i + 1).ToString());

            string itemFound = "null";
            DateTime timeStart = DateTime.Now;
            foreach (var item in listStr)
            {
                if (item == _thisValue)
                    itemFound = item;
            }
            DateTime timeEnding = DateTime.Now;
            int timeRun = timeEnding.Millisecond - timeStart.Millisecond;
            Console.WriteLine(String.Format("\n\nFor - Found value {0:N2} :: after {1} milisegundos", itemFound, timeRun));
        }
    }
}
