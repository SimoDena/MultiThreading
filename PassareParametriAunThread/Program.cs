using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PassareParametriAunThread
{
    class Program
    {
        static void Main(string[] args)
        {
            string variabile = "MyValore1";
            Thread threadLavoratore = new Thread((variabile_parametro) =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(variabile_parametro);
                });

            threadLavoratore.Start(variabile);
            variabile = "MyValore2";

            Console.WriteLine(variabile);
            Console.ReadKey();
        }
    }
}
