using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class PInfo
    {
        public string Name { get; private set; }
        public bool Gender { get; private set; }


        public PInfo()
        {
            Name = Console.ReadLine();
            Gender = Console.ReadLine() == "1" ? true : false;

        }

        public void PrintInfo()
        {
            Console.WriteLine(Name + "\n" + (Gender == true ? "Male" : "Female"));
        }
    }
}
