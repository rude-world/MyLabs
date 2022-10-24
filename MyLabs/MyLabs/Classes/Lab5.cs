using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLabs.Classes
{
    public class Lab5 : ilabs
    {
        public static void Demo()
        {
            var mass = new Matrix();
            mass.print();
        }
        public static void Description()
        {
            Console.WriteLine("Задания:\n№1 Заполнить матрицу случайными числами\n№2 Вывести главную диагональ.\n№3 Вывести побочную диагональ.\n№4 Вывести сумму всех элементов матрицы.\n" +
                "\nЗадания повыешнной сложности:\n№1 Задания №1…4 выполнить с использованием функций и процедур.\n№2 Весь функционал выполнить в отдельном классе.\n");
        }
        public static void Id()
        {
            Console.WriteLine("\nLab5\n");
        }
        public static void Name() 
        {
            Console.WriteLine("Заголовок - Двумерные массивы\n");
        }
    }
}

