using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator.Models
{
    public class Species
    {
        public string Name { get; set; }
        public double GrowFactor { get; set; }

        public override string ToString()
        {
            return this.Name;
        }

        public static List<Species> GetAll()
        {
            return new List<Species>()
            {
                new Species() { Name="Populier", GrowFactor=1.5 },
                new Species() { Name="Iep", GrowFactor=1.5 },
                new Species() { Name="Wilg", GrowFactor=1.5 },
                new Species() { Name="Zilveresdoorn", GrowFactor=1.5 },
                new Species() { Name="Fruitboom", GrowFactor=2 },
                new Species() { Name="Berk", GrowFactor=2 },
                new Species() { Name="Den", GrowFactor=2 },
                new Species() { Name="Lariks", GrowFactor= 2},
                new Species() { Name="Rode esdoorn", GrowFactor=2 },
                new Species() { Name="Linde", GrowFactor=2 },
                new Species() { Name="Spar", GrowFactor=2.5 },
                new Species() { Name="Beuk", GrowFactor=2.5 },
                new Species() { Name="Es", GrowFactor=2.5 },
                new Species() { Name="Eik", GrowFactor=3 },
                new Species() { Name="Notelaar", GrowFactor=3 },
                new Species() { Name="Kastanjeboom", GrowFactor=3 },
            };
        }
    }
}
