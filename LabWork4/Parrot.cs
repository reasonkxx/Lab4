using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4
{
     class Parrot : Pet
    {
        public string Golos { get; set; }
        internal Parrot(string name, string Description, double Weighr, int Age, string WayOfMov, string Golos)
            : base(name, Description, Weighr, Age, WayOfMov)
        {
            this.Golos = Golos;
        }
        public static Parrot Popygai = new Parrot("Чирик", "Попугай,мужской", 1.04, 3, "ходьба, бег, прыжок, полет" , "Каррр");
        public override string ToString()
        {
            return $"\nИмя = {Popygai.Name},\nВид = {Popygai.Description} \nМасса = {Popygai.Weight}кг ,\nВозраст = {Popygai.Age} года,\nСпособ передвижения = {Popygai.WayOFMov},\nГолос = {Popygai.Golos}";
        }

    }
}
