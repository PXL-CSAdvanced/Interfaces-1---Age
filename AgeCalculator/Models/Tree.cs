using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator.Models
{
    public class Tree : IAge
    {
        private readonly Species _species;
        private readonly double _circumference;

        public Tree(Species species, double circumference)
        {
            _species = species;
            _circumference = circumference;
        }

        public int Age => Convert.ToInt32(_circumference / Math.PI * _species.GrowFactor);

        public string Name => $"Boom: {_species.Name}";
    }
}
