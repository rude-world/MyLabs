using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyLabs.Classes
{
    [DataContract]
    public class Group : Sudent
    {
        public Group(string Name, int Age, string Sex, string Group, string Spesialisation, string VUZ) : base(Name, Age, Sex, Group, Spesialisation, VUZ)
        {
            
            name = Name;
            age = Age;
            sex = Sex;
            group = Group;
            spesialisation = Spesialisation;
            vuz = VUZ;
        }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        int age { get; set; }
        [DataMember]
        string sex { get; set; }
        [DataMember]
        string group { get; set; }
        [DataMember]
        string spesialisation { get; set; }
        [DataMember]
        string vuz { get; set; }
        public void PRINT1()
        {
            Console.WriteLine("\nName\tAge\tSex\tGroup\tSpesialisation\tVUZ");
            Console.WriteLine("\n" + name + "\t"+age + "\t" + sex + "\t" + group + "\t" + spesialisation + "\t" + vuz);
        }

        public override string ToString()
        {
            return name;
        }

    }
}
