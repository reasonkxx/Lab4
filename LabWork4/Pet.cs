using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4
{
    public abstract class Pet
    {
        public string Name { get; set; }  
        public string Description { get; set; }
        public double Weight { get; set; }  
        public int Age { get; set; }
        public string WayOFMov { get; set; }
        public Pet (string Name,string Description, double Weighr, int Age, string WayOfMov)
        {
            this.Name = Name;
            this.Description = Description;
            this.Weight = Weighr;   
            this.Age = Age;
            this.WayOFMov = WayOfMov;
        }

    }
}
