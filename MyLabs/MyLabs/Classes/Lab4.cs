using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLabs.Classes
{
    public class Lab4 : ilabs
    {
        public static void Demo()
        {
            Console.WriteLine("№1\n");

            int[] mass = new int[5];
            Random random = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(0,100);
                Console.Write(mass[i]+"\t");
            }

            Console.WriteLine("№2\n");

            string str = "awd 23 f 4 rg3 3";
            string[] strArr=str.Split(' ');
            foreach (string el in strArr)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("№3\n");

            Console.WriteLine("Сколько чисел будем сортировать?");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа для сортировки:");
            int[] mas = new int[N];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            Console.WriteLine("После сортировки:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }

            Console.WriteLine("№1, Повышенной сложности\n");

            string strt = "Мальчик не пошёл в поход, потому что пошёл дождь. Девочка пошла в магазин, но он был закрыт.";
            Console.WriteLine(strt+"\n");
            string[] strtArr = strt.Split(' ',',','.');
           
            foreach (string el in strtArr)
            {
                Console.WriteLine(el);
            }

        }
        public static void Description()
        {
            Console.WriteLine("Задания:\n№1 Сгенерировать массив размером n (указывается в коде). Заполнить его случайными целыми числами в диапазоне [0; 100] и вывести через знаки табуляции в строку\n" +
                "№2 Ввести строку, содержащую пробелы. Разделить строку с использованием метода Split\n№3 Написать метод пузырьковой сортировки одномерного целочисленного массива. Оценить асимптотическую сложность алгоритма пузырьковой сортировки.\n" +
                "\nЗадания повышенной сложности:\nВвести строку из двух предложений со знаками препинания. Создать список List<string> wordsList, в который записать все слова из предложения. Вывести список на экран в столбик.\n");
        }
        public static void Id()
        {
            Console.WriteLine("\nLab4\n");
        }
        public static void Name() 
        {
            Console.WriteLine("Заголовок - Массивы. Строки\n");
        }
    }
}

