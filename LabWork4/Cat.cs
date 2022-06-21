using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4
{
     class Cat : Pet
    {
        public string Golos { get; set; }
        internal Cat(string name, string Description, double Weighr, int Age, string WayOfMov, string Golos)
            : base(name, Description, Weighr, Age, WayOfMov)
        {
            this.Golos = Golos;
        }
        public static Cat Koshka = new Cat("Мурка", "Собака,женский", 8.42, 6, "ходьба, бег, прыжок, плавание", "Мяу");
        public override string ToString()
        {
            return $"\nИмя = {Koshka.Name},\nВид = {Koshka.Description} \nМасса = {Koshka.Weight}кг ,\nВозраст = {Koshka.Age} лет,\nСпособ передвижения = {Koshka.WayOFMov},\nГолос = {Koshka.Golos}";
        }
    }
}
