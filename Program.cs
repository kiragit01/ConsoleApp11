using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1. Вывести на экран в столбик первые 10 натуральных чисел (циклы с условием, цикл с параметром)

            int x = 1;
            while(x <= 10)
                Console.WriteLine(x++);

            for (x = 1; x <= 10; x++)
                Console.WriteLine(x);

            //Задание 2. Вывести на экран целые числа из интервала от 1 до n (цикл с параметром)

            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);

            //Задание 3. Вывести в столбик 5 раз слово «Привет!» (циклы с условием)
                
            int a = 0;
            while (a < 5)
            {
                Console.WriteLine("Привет!");
                a++;
            }

            //Задание 4.С использованием цветового оформления консоли:

            //а) вывести на экран горизонтальную строку из 18 символов;

            x = 1;
            for (int i = 1; x <= 25; i++)
            {
                Console.ForegroundColor = (ConsoleColor)i;
                Console.Write('_');
                x++;
                if (i == 15)
                    i = 1;
            }

            //б) вывести на экран вертикальную строку из 25 символов.

            x = 1;
            for (int i = 1; x <= 18; i++)
            {
                Console.ForegroundColor = (ConsoleColor)i;
                Console.WriteLine('|');
                x++;
                if (i == 15)
                    i = 1;
            }



            Console.ReadKey();
        }
    }
}
