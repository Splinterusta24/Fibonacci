using System;
using System.Collections.Generic;
using System.Linq;

namespace Fibonnacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Decimal> fibo = new List<Decimal>();
            Hesap x = new Hesap();

            decimal ort = 0;
            decimal sonuc = 0;
            decimal eleman;

            Console.WriteLine("Derinlik ne kadar olsun?");
            int sayi = int.Parse(Console.ReadLine());

            for (int i = 0; i < sayi; i++)
            {
                fibo.Add(x.hesaplama());
            }
            Console.Write("1,");
            Console.Write(string.Join(',', fibo.ToArray()));
            for (int i = 0; i < sayi; i++)
            {
                ort += fibo[i];
                sonuc = Queryable.Average(fibo.AsQueryable());
            }

            Console.WriteLine("");
            Console.WriteLine("ortalama: " + sonuc);


        }
    }
}
