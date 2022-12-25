using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLabs.Classes
{
    public class Lab5 : Ilabs
    {
        public  void Demo()
        {
            var mass = new Matrix();
            mass.print();
        }
        public string Description()
        {
            
            return "Задания:\n№1 Заполнить матрицу случайными числами\n№2 Вывести главную диагональ.\n№3 Вывести побочную диагональ.\n№4 Вывести сумму всех элементов матрицы.\n" +
                "\nЗадания повыешнной сложности:\n№1 Задания №1…4 выполнить с использованием функций и процедур.\n№2 Весь функционал выполнить в отдельном классе.\n";
        }
        public  int Id()
        {
            return 5;
        }
        public  string Name() 
        {
          
            return "Заголовок - Двумерные массивы\n";
        }
    }
}

