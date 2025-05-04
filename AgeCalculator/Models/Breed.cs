using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator.Models
{
    public class Breed
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public double AgeEquivalent { get; set; }

        public override string ToString()
        {
            return this.Name;
        }

        public static List<Breed> GetAll()
        {
            return new List<Breed>
            {
                new Breed { Name = "Beagle", Size = "K", AgeEquivalent = 12.5 },
                new Breed { Name = "Border Terrier", Size = "K", AgeEquivalent = 12.5 },
                new Breed { Name = "Boxer", Size = "G", AgeEquivalent = 9 },
                new Breed { Name = "Bulldog", Size = "MG", AgeEquivalent = 10.5 },
                new Breed { Name = "Cavalier King Charles", Size = "K", AgeEquivalent = 12.5 },
                new Breed { Name = "Chihuahua", Size = "K", AgeEquivalent = 12.5 },
                new Breed { Name = "Cocker Spaniel", Size = "K", AgeEquivalent = 12.5 },
                new Breed { Name = "Duitse Herder", Size = "G", AgeEquivalent = 9 },
                new Breed { Name = "Dwerg Schnauzer", Size = "K", AgeEquivalent = 12.5 },
                new Breed { Name = "Franse Bulldog", Size = "K", AgeEquivalent = 12.5 }
            };
        }
    }
}
