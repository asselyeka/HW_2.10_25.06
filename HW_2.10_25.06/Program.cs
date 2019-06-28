using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 10.	 Напечатать "столбиком": 
a.	все целые числа от 20 до 35;
b.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
c.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).

 */


namespace HW_2._10_25._06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напечатать \"столбиком\" все целые числа от 20 до 35:");
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Напечатать \"столбиком\" квадраты всех целых чисел от 10 до b:");
            Console.WriteLine("Введите число b:");
            var b = Convert.ToInt32(Console.ReadLine());
            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine(i*i);
            }
            Console.WriteLine("Напечатать \"столбиком\" третьи степени всех целых чисел от a до 50:");
            Console.WriteLine("Введите число a:");
            var a = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= 50; i++)
            {
                Console.WriteLine(i * i * i);
            }
            Console.WriteLine("Напечатать \"столбиком\" все целые числа от a до b:");
            Console.WriteLine("Введите число a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
