using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyLabs.Classes
{
    public class Lab7 : ilabs
    {
        public static void Demo()
        {

            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sex(М/Ж): ");
            string Sex = Console.ReadLine();
            Console.Write("Group: ");
            string Group = Console.ReadLine();
            Console.Write("Spesialisation: ");
            string Spesialisation = Console.ReadLine();
            Console.Write("VUZ: ");
            string VUZ = Console.ReadLine();


            Group Person1 = new Group(Name, Age, Sex, Group, Spesialisation, VUZ);
            Person1.PRINT1();
            var groups = new List<Object>();
            groups.Add(Name);
            groups.Add(Age);
            groups.Add(Sex); 
            groups.Add(Group);
            groups.Add(Spesialisation);
            groups.Add(VUZ);
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Object>));
            using (var file = new FileStream("Student.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(file, groups);
            }
          
            
    }
        public static void Description()
        {
            Console.WriteLine("Задания:\n№1 Создать класс Person. С полями имя, возраст, пол.\n№2 Создать класс Sudent - наследник Person. Добавить поля Группа, ВУЗ/СУЗ, Специальность.\n№3 Создать класс Group. Предусмотреть методы записи студентов в группу. Предусмотреть сохранение списка студентов в файл .json методом сериализации \n\nЗадание повышенной сложности \nВыполнить сериализацию во все форматы, озвученные в видео. Сравнить объемы файлов.\n");
        }
        public static void Id()
        {
            Console.WriteLine("\nLab7\n");
        }
        public static void Name()
        {
            Console.WriteLine("Заголовок - Сериализация\n");
        }
    }
}
