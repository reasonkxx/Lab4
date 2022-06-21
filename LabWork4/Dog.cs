using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4
{
     class Dog : Pet
    {
        public string Golos { get; set; }
        internal Dog(string name, string Description, double Weighr, int Age, string WayOfMov, string Golos)
            : base(name, Description, Weighr, Age, WayOfMov)
        {
            this.Golos = Golos;
        }
        public static Dog Sobaka = new Dog("Чейз", "Собака,мужской", 15.34, 8, "ходьба, бег, прыжок, плавание", "Гав");
        public override string ToString()
        {
            return $"\nИмя = {Sobaka.Name},\nВид = {Sobaka.Description} \nМасса = {Sobaka.Weight}кг ,\nВозраст = {Sobaka.Age} лет,\nСпособ передвижения = {Sobaka.WayOFMov},\nГолос = {Golos}";
        }
    }
}
