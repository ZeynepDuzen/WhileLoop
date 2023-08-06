using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            // *** faktoriyel hesaplayan while dongusu ***
            //Console.WriteLine("Faktoriyelinin hesaplanmasini istediginiz bir sayi girin : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int carpim = 1;
            //int baslangic = 1;
            //while (baslangic <= sayi)
            //{
            //    //Console.WriteLine(baslangic);
            //    carpim *= baslangic;
            //    baslangic++;
            //}
            //Console.WriteLine("Girmis oldugunuz sayinin faktoriyeli : " + carpim);

            // *** Us alma ***
            Console.WriteLine("Taban degeri olacak pozitif bir tamsayi girin : ");
            int taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Us degeri olacak pozitif bir tam sayi giriniz : ");
            int us = Convert.ToInt32(Console.ReadLine());

            //int carpim = 1;
            //int i = 1;
            //while (i <= us)
            //{
            //    carpim *= taban;
            //    i++;
            //}
            //Console.WriteLine("Girdiginiz uslu sayinin carpim sonucu  :" + carpim);

            int result = UsAlma(taban, us);
            Console.WriteLine("Girilen uslu sayinin carpim sonucu : " + result);

            Console.Read();
                
        }
        static int UsAlma(int taban, int us)
        {
            int carpim = 1;
            int i = 1;

            while (i <= us)
            {
                carpim *= taban;
                i++;
            }
            return carpim;
        }
    }
}
