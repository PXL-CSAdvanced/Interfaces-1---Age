using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator.Models
{
    public class Dog : IAge
    {
        private readonly string _name;
        private readonly Breed _breed;
        private readonly string _size;
        private readonly int _birthyear;

        public Dog(string name, Breed breed, int birthyear) 
        {
            _name = name;
            _breed = breed;
            _birthyear = birthyear;
        }

        public int Age => Convert.ToInt32((DateTime.Today.Year - _birthyear) * _breed.AgeEquivalent);

        public string Name => $"{_breed.Name}: {_name}";
    }
}
