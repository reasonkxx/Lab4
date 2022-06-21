using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4
{
    public abstract class Bird : Pet
    {
        public string Golos { get; set; }
        internal Bird(string name, string Description, double Weighr, int Age, string WayOfMov, string Golos)
            : base(name, Description, Weighr, Age, WayOfMov)
        {
            this.Golos = Golos;
        }
        public class Goose : Bird

        {
            internal Goose (string name, string Description, double Weighr, int Age, string WayOfMov, string Golos)
            : base(name, Description, Weighr, Age, WayOfMov, Golos)
            {

            }
            public static Goose Gus = new Goose("Ясень", "Попугай, мужской", 3.41, 5, "ходьба, бег, прыжок, полет", "Кря");
             public override string ToString()
            {
                return $"\nИмя = {Gus.Name},\nВид = {Gus.Description} \nМасса = {Gus.Weight}кг ,\nВозраст = {Gus.Age} года,\nСпособ передвижения = {Gus.WayOFMov},\nГолос = {Gus.Golos}";
            }
        }
    }
}
