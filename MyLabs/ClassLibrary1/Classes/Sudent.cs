using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyLabs.Classes
{
    [DataContract]
    public class Sudent : Person
    {
        public Sudent () { }

        public Sudent(string Name, int Age, string Sex, string Group, string Spesialisation, string VUZ) : base(Name, Age, Sex)
        {

        }
    }
}
