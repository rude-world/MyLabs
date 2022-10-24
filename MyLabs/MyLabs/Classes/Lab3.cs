using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLabs.Classes
{
    internal class Lab3 : ilabs
    {
        public static void Demo()
        {
            Console.WriteLine("№1\n");
            Console.WriteLine("С предусловием:\n");
            var i = 0;
            while (i<=100)
            {
                if (i % 22 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            i = 0;
            Console.WriteLine("\nС постусловием:\n");
            do
            {
                if (i % 22 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            while (i <= 100) ;
            Console.WriteLine("\nСчетчик:\n");
            for (int b =0; b <= 100; b++)
            {
                if (b % 22 == 0)
                {
                    Console.WriteLine(b);
                }
            }
            Console.WriteLine("№2\n");
            int a = 0;
            for (int c=0; c <= 30; c++)
            {
                if (c%2!=0)
                {
                    a += c;
                }
            }
            Console.WriteLine(a);
            Console.WriteLine("№1, Повышенной сложности\n");
            Console.WriteLine("С предусловием:\n");
            i = 100;
            while (i >= 0)
            {
                if (i % 22 == 0)
                {
                    Console.WriteLine(i);
                }
                i--;
            }
            Console.WriteLine("С постусловием\n");
            i = 100;
            do
            {
                if (i % 22 == 0)
                {
                    Console.WriteLine(i);
                }
                i--;
            }
            while (i >= 0);
            Console.WriteLine("Счетчик\n");
            for (int b = 100; b >= 0; b--)
            {
                if (b % 22 == 0)
                {
                    Console.WriteLine(b);
                }
            }
            Console.WriteLine("№2, Повышенной сложности:\n");
            Console.WriteLine("Введите строку:");
            string s = Console.ReadLine();
            foreach (char d in s.ToCharArray())
            {
                Console.WriteLine(d);
            }
        }
        public static void Description()
        {
            Console.WriteLine("Задания:\n№1 Для всех чисел в диапазоне [0; 100] вывести все числа, которые делятся нацело на число равное номеру по списку группы. Для первого варианта взять «–5». Решить, используя три цикла («с предусловием», «с постусловием» и «счетчик»).\n" +
             "№2 Определить сумму всех нечетных чисел в диапазоне [0; 30]\n\nЗадания повышенной сложности:\n" +
             "1№ Выполнить задание №1 рекурсивно.\n№2 Ввести строку с клавиатуры. Вывести ее посимвольно в столбик с помощью цикла foreach.\n");
        }
        public static void Id()
        {
            Console.WriteLine("\nLab3\n");
        }
        public static void Name() 
        {
            Console.WriteLine("Заголовок - Циклы\n");
        }
    }
}

    

