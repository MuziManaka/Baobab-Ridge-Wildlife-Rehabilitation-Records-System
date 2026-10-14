using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baobab_Ridge_Wildlife_Rehabilitation_Records_System.Models
{
    public class Pet
    {
        public string AnimalId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }  
        public string Species { get; set; }
        public int RecoveryScore { get; set; }

        public Pet(string id, string name, int age)
        {
            AnimalId = id;
            Name = name;
            Age = age;
        }

    }
}
