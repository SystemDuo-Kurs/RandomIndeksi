using System;
using System.Collections.Generic;

namespace RandomIndeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> reci = new();
            reci.Add("Test"); //0
            reci.Add("Bla"); //1
            reci.Add("Trece"); //2
            reci.Add("Qwe"); //3
            reci.Add("Asd"); //4

            Random nasumicno = new();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine
                    (
                        reci[nasumicno.Next(reci.Count)]
                    );
            }

            Console.WriteLine(reci[2]);
            //for (int indeks = 0; indeks < reci.Count; indeks++)
            //{
            //    Console.WriteLine(reci[indeks]);
            //}


            //foreach(string rec in reci)
            //{
            //    Console.WriteLine(rec);
            //}
        }
    }
}
