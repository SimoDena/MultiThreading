using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multthreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(() =>
                {
                    Console.WriteLine("MyThread Started!");
                    Thread.Sleep(1000);
                    Console.WriteLine("Thread Terminato!");
                });

            myThread.Start();

            Thread.Sleep(500);
            Console.WriteLine("Thread Principale");
            Console.ReadKey();
        }
    }
}
