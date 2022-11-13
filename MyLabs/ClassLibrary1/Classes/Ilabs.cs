using MyLabs.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLabs
{
     public interface Ilabs
    {
            
            void Demo() //Демонстрация
            {

            }
            string Description() // Описание заданий
            {
            return "Description";
            }
            int Id() // Номер лабы
            {
            return 0;
            }
            string Name() // Название лабы
            {
            return "Name";
            }

        
    }

}

