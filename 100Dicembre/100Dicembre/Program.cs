using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100Dicembre
{
    class Program
    {
        static void Main(string[] args)
        {
            Task countdown = Task.Factory.StartNew(() =>
            {
                for (int i = 100; i > 0; i--)
                    Console.Write(i);
            });

            Task dicembre = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; i++)
                    Console.Write("Dicembre");
            });
            Task.WaitAll(countdown, dicembre);
            Console.Write("Hello World!");
            Console.ReadLine();
        }
    }
}
