using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Abort
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread threadLavoratore = new Thread(() =>
                {
                    Console.WriteLine("Partenza di un codice molto lungo...");
                    Thread.Sleep(8000);
                    Console.WriteLine("Fine Thread Lungo");
                });

            threadLavoratore.Start();
            threadLavoratore.Join(3000);

            if (threadLavoratore.ThreadState != ThreadState.Stopped)
            {
                int scelta = 0;
                Console.WriteLine("Il thread sta impiegando molto tempo, premere 1 per annullare l'operazione, altro tasto per continuare.");
                scelta = Convert.ToInt32(Console.ReadLine());
                if (scelta == 1)
                {
                    threadLavoratore.Abort();
                    Console.WriteLine("Thread Lavoratore abortito!");
                    Console.WriteLine("Termine applicazione!");
                }
            }

            Console.ReadKey();
        }
    }
}
