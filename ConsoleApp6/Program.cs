using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //one_to_n();
            //one_to_nn();
            //one_to_nnn();
            //summ();
            //summ_ab();
            //mult();
            //summ_nn();
            summ_nn_even();
        }



        //Արտածել 1-ից մինչև n բոլոր ամբողջ թվերը։
        static void one_to_n()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i ++ )
            {
                Console.Write("i = {0}\n", i);

            }
            Console.ReadLine();

        }


        //Արտածել 1-ից մինչև n բոլոր ամբողջ զույգ թվերը։
        static void one_to_nn()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)

                {
                    Console.Write("i = {0}\n", i);
                }
                       

            }
            Console.ReadLine();

        }

        //Արտածել 1-ից մինչև n բոլոր ամբողջ կենտ թվերը։
        static void one_to_nnn()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)

                {
                    Console.Write("i = {0}\n", i);
                }


            }
            Console.ReadLine();

        }

        //Հաշվել 1-ից մինչև n բոլոր ամբողջ թվերի գումարը և արտածել այն։
        static void summ()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int s = (n * (n + 1)) / 2;
            for (int i = 1; i <= n; i++)
            { }
            Console.Write("s = {0}", s);
            Console.ReadLine();

        }
        //Հաշվել a-ից մինչև b բոլոր ամբողջ թվերի գումարը և արտածել այն։

        static void summ_ab()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            int s = (a + b) * (b - a + 1) / 2;

            for (; a <= b; a++)
            { }

            Console.Write("s = {0}", s);
            Console.ReadLine();

        }
        //Հաշվել 1-ից մինչև 15 բոլոր ամբողջ թվերի արտադրյալը և արտածել այն։
        static void mult()
        {
            int i = 1;
            int m = 1;
            do

            {
                // m *= i;
                m = m * i;
                i++;
             }
            
            while (i <= 15);

            Console.Write("m = {0}", m);
            Console.ReadLine();

        }

        //Ներմուծել n քանակությամբ ամբողջ թվեր և հաշվել դրանց գումարը։

        static void summ_nn()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            int s;

            do

            {
                //s = (a + n) * (n - a + 1) / 2;
                s = (n * (n + 1)) / 2;
                a++;
             }
            
            while (a <= n);
            Console.Write("s = {0}", s);

            Console.ReadLine();

        }

        //Ներմուծել n քանակությամբ ամբողջ թվեր և հաշվել դրանցից միայն զույգ թվերի գումարը։
        static void summ_nn_even()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            //int s;
            
            do

            {
                int s;
                if (a % 2 == 0)
                {
                  s = (n * (n + 1)) / 2;
                   Console.Write("s = {0}", s);

                }
                
                a++;
                
            }

            while (a <= n);
            Console.ReadLine();

        }
    }
}
