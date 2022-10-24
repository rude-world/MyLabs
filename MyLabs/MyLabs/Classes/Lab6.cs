using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLabs.Classes
{
    public class Lab6 : ilabs
    {
        public static void Demo()
        {
            Console.WriteLine("№1\n");
            Console.WriteLine("Факториал какого числа нужно посчитать?: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int Fact(int n)
            {
                if (n == 1) return 1;

                return n * Fact(n - 1);
            }

            int factorial = Fact(n); 
            Console.WriteLine($"Факториал числа {n} = {factorial}\n");

            Console.WriteLine("№2\n");

            Console.WriteLine("Фибоначчи?: \n");
            int f = Convert.ToInt32(Console.ReadLine());
            int Fibonachi(int f)
            {
                if (f == 0 || f == 1) return f;

                return Fibonachi(f - 1) + Fibonachi(f - 2);
            }

            int fib = Fibonachi(f);
           

            Console.WriteLine($"число Фибоначчи {f} = {fib}\n");
           
        }
        public static void Description()
        {
            Console.WriteLine("Задания:\n№1 Написать рекурсивную функцию вычисления факториала.\n№2 Написать рекурсивную процедуру вывода чисел Фибоначчи.\n\nЗадание повышенной сложности:\n" +
                "1№ Вывести дерево файловой системы по указанной директории. Примечание: используйте класс DirectoryInfo и методы GetDirectories(path), GetFiles(path). Просмотр файловой структуры осуществляется рекурсивно!\n");
        }
        public static void Id()
        {
            Console.WriteLine("\nLab6\n");
        }
        public static void Name() 
        {
            Console.WriteLine("Заголовок - Функции и процедуры\n");
        }
    }
}
