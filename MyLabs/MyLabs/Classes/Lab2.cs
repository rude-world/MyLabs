using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLabs.Classes
{
    public class Lab2 : ilabs
    {
        public static void Demo()
        {
            Console.WriteLine("№1\n");

            int number = 0;

            while (true)
            {
                Console.WriteLine("Enter a number from 1 to 7");
                bool isNumber = false;
                isNumber = int.TryParse(Console.ReadLine(), out number);
                if (isNumber == true)
                {
                    break;
                }
            }

            switch (number)
            {
                case 1:
                    Console.WriteLine("ponedelnik");
                    break;
                case 2:
                    Console.WriteLine("vtornik");
                    break;
                case 3:
                    Console.WriteLine("Sreda");
                    break;
                case 4:
                    Console.WriteLine("chetverg");
                    break;
                case 5:
                    Console.WriteLine("Pyatnica");
                    break;
                case 6:
                    Console.WriteLine("subbota");
                    break;
                case 7:
                    Console.WriteLine("voskresene");
                    break;
                default:
                    Console.WriteLine("Error - you entered the wrong number");
                    break;
            }
            Console.WriteLine("\n№2\n");

            int number1 = 0;

            while (true)
            {
                Console.WriteLine("Enter a number");
                bool isNumber1 = false;
                isNumber1 = int.TryParse(Console.ReadLine(), out number1);
                if (isNumber1 == true)
                {
                    break;
                }
            }
            int x1 = number1 % 3;
            int m1 = number1 % 5;
            if ((x1 == 0) && (m1 == 0))
            {
                Console.WriteLine("BuzzFizz");
            }
            else
            {
                if (x1 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    if (m1 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
            }

            Console.WriteLine("\n№3\n");

            double number2 = 0;
            double number3 = 0;
            for (; ; )
            {
                while (true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Enter a first number");
                    bool isNumber2 = false;
                    isNumber2 = double.TryParse(Console.ReadLine(), out number2);
                    if (isNumber2 == true)
                    {
                        break;
                    }
                }
                Console.WriteLine("Enter sign (-, +, *, /, ^, sqrt)");

                string znak = Console.ReadLine();

                while (true)
                {
                    Console.WriteLine("Enter a second number");
                    bool isNumber3 = false;
                    isNumber3 = double.TryParse(Console.ReadLine(), out number3);
                    if (isNumber3 == true)
                    {
                        break;
                    }
                }
                Console.Clear();

                switch (znak)
                {
                    case "+":
                        Console.Write(number2 + " + " + number3 + " = ");
                        Console.WriteLine(number2 + number3);
                        break;
                    case "-":
                        Console.Write(number2 + " - " + number3 + " = ");
                        Console.WriteLine(number2 - number3);
                        break;
                    case "*":
                        Console.Write(number2 + " * " + number3 + " = ");
                        Console.WriteLine(number2 * number3);
                        break;
                    case "/":
                        Console.Write(number2 + " / " + number3 + " = ");
                        Console.WriteLine(number2 / number3);
                        break;
                    case "^":
                        Console.Write(number2 + "^" + number3 + " = ");
                        Console.WriteLine(Math.Pow(number2, number3));
                        break;
                    case "sqrt":
                        Console.Write(number2 + " sqrt " + number3 + " = ");
                        Console.WriteLine(Math.Pow(number3, 1 / number2));
                        break;
                    default:
                        Console.WriteLine("ne tot znak");
                        break;
                }
            }

        }
        public static void Description()
        {
            Console.WriteLine("Задания:\n№1 Ввести число в диапазоне [1; 7]. Проверить, является ли введенная информация числом. Проверить принадлежность диапазону. При наличии отклонений, вывести сообщение об ошибке. Согласно введенному числу вывести название дня недели. Решить задачу через if-else и через switch-case.\n" +
                "№2 Ввести целое число. Если число делится на 3, вывести сообщение Buzz. Если число делится на 5 – вывести Fizz. Если число делится и на 3, и на 5, – вывести BuzzFizz.\n" +
                "№3 Написать простейший консольный калькулятор(на +, –, *, /)\n");
        }
        public static void Id()
        {
            Console.WriteLine("\nLab2\n");
        }
        public static void Name() 
        {
            Console.WriteLine("Заголовок - Условия. Операторы сравнения\n");
        }
    }
}
