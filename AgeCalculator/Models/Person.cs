using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace AgeCalculator.Models
{
    public class Person : IAge
    {
        private readonly string _firstname;
        private readonly string _lastname;
        private readonly DateTime _birthdate;

        public Person(string firstname, string lastname, DateTime birthdate)
        {
            _firstname = firstname;
            _lastname = lastname;
            _birthdate = birthdate;
        }
        public int Age => DateTime.Today.Year - _birthdate.Year;

        public string Name => $"{_firstname} {_lastname}";
    }
}
