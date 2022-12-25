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
    public class Lab7 : Ilabs
    {
        public  void Demo()
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

            Group[] student = new Group[] { Person1 };

            Person1.PRINT1();

            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Group[]));

            using(FileStream fs = new FileStream("student.json", FileMode.OpenOrCreate))
            {
                json.WriteObject(fs, student);
            }
            

        }
        public  string Description()
        {
            
            return "Задания:\n№1 Создать класс Person. С полями имя, возраст, пол.\n№2 Создать класс Sudent - наследник Person. Добавить поля Группа, ВУЗ/СУЗ, Специальность.\n№3 Создать класс Group. Предусмотреть методы записи студентов в группу. Предусмотреть сохранение списка студентов в файл .json методом сериализации \n\nЗадание повышенной сложности \nВыполнить сериализацию во все форматы, озвученные в видео. Сравнить объемы файлов.\n";
        }
        public  int Id()
        {
           
            return 7;
        }
        public  string Name()
        {
           
            return "Заголовок - Сериализация\n";
        }
    }
}
