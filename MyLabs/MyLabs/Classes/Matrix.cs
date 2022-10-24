using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLabs.Classes
{
    internal class Matrix
    {
        internal int[,] mass;


        public Matrix()
        {
            Random rnd = new Random();
            mass = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    mass[i, j] = rnd.Next(100);


        }
        public void print()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(mass[i, j].ToString() + "\t");
                Console.WriteLine();
            }
            Console.WriteLine("\nГлавная диагональ:\n");
            Console.Write(mass[0, 0].ToString() + "\t"+ mass[1, 1].ToString() + "\t"+mass[2, 2].ToString() + "\t\n");
            Console.WriteLine("\nПобочная диагональ:\n");
            Console.Write(mass[0, 2].ToString() + "\t" + mass[1, 1].ToString() + "\t" + mass[2, 0].ToString() + "\t\n");

            var sum = 0;

            foreach (var sub in mass)
                    sum += sub;
            Console.WriteLine("\nСумма: " +sum);
        }
        }
    }
    


