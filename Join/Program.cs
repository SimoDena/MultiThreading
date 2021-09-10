using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Join
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Thread> threads = new List<Thread>();

            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread((indice) =>
                    {
                        Console.WriteLine($"{indice} e' iniziato");
                        Thread.Sleep(1000);
                        Console.WriteLine($"{indice} e' terminato!");
                    });

                thread.Start(i);
                threads.Add(thread);
            }
            foreach (var t in threads)
            {
                t.Join();
            }

            Console.WriteLine("Thread main è arrivato qui!, dopo che tutti i processi della lista sono terminati!");
            Console.ReadKey();

        }
    }
}
