using FullFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFamily.Data
{
    public class DataContext
    {
        List<Family> _families = new List<Family>();

        public DataContext()
        {

            var family1 = new Family()
            {
                FamilyId = 1,
                Nickname = "Family One ",
                Father = new Adult { Name = "Jim", DateOfBirth = DateTime.Now.AddYears(-34), Job = "Programmer", LicenseNumber = "2344454", PersonId = 5 },
                Mother = new Adult() { Name = "Amy", DateOfBirth = DateTime.Now.AddYears(-33), Job = "Accountant", LicenseNumber = "8888", PersonId = 6 },
                Children = new List<Person>()
                 {
                   new Person() {Name = "Bob",DateOfBirth = DateTime.Now.AddYears(-4),PersonId = 1},
                   new Person() {Name = "Ella",DateOfBirth = DateTime.Now.AddYears(-6),PersonId = 2},
                   new Person() {Name = "Sophia",DateOfBirth = DateTime.Now.AddYears(-3),PersonId = 3},
                 }
            };
            _families.Add(family1);

            var family2 = new Family()
            {
                FamilyId = 2,
                Nickname = "Family two ",
                Father = new Adult() { Name = "Noah", DateOfBirth = DateTime.Now.AddYears(-28), Job = "Plumber", LicenseNumber = "12344454", PersonId = 15 },
                Mother = new Adult() { Name = "Emma", DateOfBirth = DateTime.Now.AddYears(-25), Job = "Homemaker", LicenseNumber = "18888", PersonId = 16 },
                Children = new List<Person>()
                 {
                   new Person() {Name = "Matthew",DateOfBirth = DateTime.Now.AddYears(-10),PersonId = 11},
                   new Person() {Name = "James",DateOfBirth = DateTime.Now.AddYears(-7),PersonId = 13},
                 }
            };
            _families.Add(family2);

            var family3 = new Family()
            {
                FamilyId = 3,
                Nickname = "Family three ",
                Father = new Adult() { Name = "Bill", DateOfBirth = DateTime.Now.AddYears(-25), Job = "Driver", LicenseNumber = "12344454", PersonId = 35 },
                Mother = new Adult() { Name = "Judy", DateOfBirth = DateTime.Now.AddYears(-23), Job = "Teacher", LicenseNumber = "18888", PersonId = 36 },

            };
            _families.Add(family3);

            var family4 = new Family()
            {
                FamilyId = 4,
                Nickname = "Family four",
                Father = new Adult() { Name = "Max", DateOfBirth = DateTime.Now.AddYears(-28), Job = "Architect ", LicenseNumber = "2344454", PersonId = 45 },
                Mother = new Adult() { Name = "Lena", DateOfBirth = DateTime.Now.AddYears(-27), Job = "Accountant", LicenseNumber = "8888", PersonId = 46 },
                Children = new List<Person>()
                 {
                   new Person() {Name = "Alexis",DateOfBirth =new DateTime(2008,10,21),PersonId = 41},
                   new Person() {Name = "Ella",DateOfBirth = new DateTime(2004,8,16),PersonId =42},


                 }
            };
            _families.Add(family4);
        }

        public List<Family> Families
        {
            get { return _families; }
        }

        
        //-------Tasks---------

        // Display info about family   
        // Family with most kids ----- done
        // Family with no kids -----done
        // Youngest child
        // Oldest child
        // Family fayther name Jim 
        // Youngest Family
        // Family where parent name starts with "O"
        // Find awesome family (if any starts with "O")
    }
}
