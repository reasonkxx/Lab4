using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dog.Sobaka.ToString());
            Console.WriteLine(Cat.Koshka.ToString());
            Console.WriteLine(Parrot.Popygai.ToString());
            Console.WriteLine(Bird.Goose.Gus.ToString());
            Console.ReadKey();
        }
    }
}
