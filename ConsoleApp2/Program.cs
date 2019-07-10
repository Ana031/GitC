using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            string[] nameList = new string[2] { "    DATE   -   TIME", "'  '  '  ' - '  '  '  '" };

            foreach (var item in nameList)
                Console.WriteLine(item);

            string[] dateList = new string[1000];
            DateTime firstTime = DateTime.Now;

            for (int i = 0; i < dateList.Length; i++)
            {
                dateList[i] = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss.fff");
                Console.WriteLine(dateList[i]);
            }

            Console.WriteLine((DateTime.Now - firstTime).ToString());


             Console.ReadKey();

        }

        #endregion

        private static void ThreadSleep(int v)
        {
            throw new NotImplementedException();
        }
    }
}
