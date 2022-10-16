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
            Console.Write("Введите имя: ");
            Name = Console.ReadLine();
            Console.Write("Введите пол: ");
            Gender = Console.ReadLine() == "1";

        }

        public void PrintInfo()
        {
            Console.WriteLine(Name + "\n" + (Gender ? "Male" : "Female"));
        }
    }
}
