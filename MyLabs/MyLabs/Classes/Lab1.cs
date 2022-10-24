using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLabs.Classes
{

    public class Lab1 : ilabs
    {
        public static void Demo()
        {
            Console.WriteLine("№1\n");
            double x = Math.Pow(2, 2) - Math.Pow(3, 3);
            double y = Math.Sqrt(Math.Pow(3, 4) - Math.Pow(2, 4));
            double c = (Math.Pow(3, 5) - Math.Pow(15, 2.5)) * -1;
            double d = Math.Sqrt(x / y + c);
            Console.WriteLine(d + "\n");
            Console.WriteLine("№2\n");
            Random Rnd = new Random();
            int a = Rnd.Next();
            int b = Rnd.Next();
            Console.WriteLine((Math.Pow(a, 2) + Math.Pow(b, 1 / 3)) / a + b + "\n");
            Console.WriteLine("№3\n");
            double i = 5.93576;
            int b1 = (int)i;
            double c1 = Math.Round(i);
            double d1 = Math.Floor(i);
            double v1 = Math.Round(i, 1);
            int f = 5;
            int g = f++;
            int f1 = 5;
            int g1 = ++f1;
            Console.WriteLine("int b=(int)a = " + b1 + "\ndouble c=Math.Round(a)  =" + c1 + "\ndouble d=Math.Floor =" + d1 + "\ndouble e=Math.Round(a,1) =" + v1);
            Console.WriteLine("f++ = " + g + "\n++f = " + g1 + "\n");
            Console.WriteLine("№4\n");
            double a11 = Rnd.NextDouble();
            Console.WriteLine(a11);

        }
        public static void Description()
        {
            Console.WriteLine("Задания:\n№1 Вычислить\n№2 Сгенерировать 2 случайных целых числа a, b. Вычислить\n№3 Заполнить таблицу\n№4 Сгенерировать случайное десятичное число.\n");
        }
        public static void Id()
        {
            Console.WriteLine("\nLab1\n");
        }
        public static void Name() 
        {
            Console.WriteLine("Заголовок - Арифметические операции. Классы Random и Math. Приведение числовых типов данных. Округление. Суффиксы и префиксы\n");
        }
    }
}
