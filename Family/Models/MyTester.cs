using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFamily.Models
{
    public class MyTester
    {
        private readonly List<Family> _data;
        public MyTester(List<Family> data)
        {
            _data = data;                 //it's a private field    
        }

        public List<Family> GetFamilyWithMostKids()
        {
            List<Family> response = new List<Family>();
            

            int maxkids = 0;

            foreach (var family in _data)       // finding all families with kids
            {
                if (family.Children.Count > maxkids)   //going trough entire list looking how many kids in 
                {
                    maxkids = family.Children.Count;
                }
            }
            foreach (var family in _data)        // finding 
            {
                if (family.Children.Count == maxkids)
                {
                    response.Add(family);
                }
            }
            return response;
        }

        public List<Family> GetFamilyWithNoKids()
        {
            List<Family> response = new List<Family>();  //we initilizing an object RESPONSE on a base of Family List , so as it's our method's return adta type, we are returning it

            foreach (var family in _data)   //we iterate through _date, which will bring us data from our list of family
            {
                if (family.Children.Count == 0)   //we are comparing list to 0
                {
                    response.Add(family);
                }
            }
            return response;
        }

        public List<Family> GetFamilyByName(string nameToFind)
        {
            List<Family> response = new List<Family>();

            foreach (var family in _data)
            {
                if (family.Father.Name.Equals(nameToFind, StringComparison.CurrentCultureIgnoreCase) ||
                     family.Mother.Name.Equals(nameToFind, StringComparison.CurrentCultureIgnoreCase))
                {
                    response.Add(family);
                }
                else
                {
                    foreach (var familyChild in family.Children)
                    {
                        if (familyChild.Name.Equals(nameToFind, StringComparison.CurrentCultureIgnoreCase))
                        {
                            response.Add(family);
                            break;
                        }
                    }
                }
            }
            return response;
            #region
            //--------- My Method -------

            //    List<Family> response = new List<Family>();
            //    var name = "";
            //    Adult father = new Adult();
            //    Adult mother = new Adult();

            //    nameToFind.Equals(name, StringComparison.CurrentCultureIgnoreCase);

            //    foreach (var family in _data)         
            //    {
            //        if (father.Name == nameToFind)
            //        {
            //            if (mother.Name == nameToFind)
            //            {
            //                List<Person> Children = new List<Person>();
            //                foreach (var child in Children)
            //                {
            //                    if (child.Name == nameToFind) ;
            //                }
            //            }
            //        }
            //    }
            //    return response;
            #endregion
        }
      
        public List<Family> GetYoungestFamilyAge()
        {
            List<Family> response = new List<Family>();
            int youngestFamilyAge = 100;
           // Family youngestFamily = null;

            foreach (var family in _data)
            {
                if (family.AverageAge < youngestFamilyAge)
                {
                    youngestFamilyAge = family.AverageAge;
                    response.Add(family);
                }
            }

            return response;
        }

        public List<Family> GetFamilyWithYoungestChild()
        {
            List<Family> response = new List<Family>();    
           // Family response = null;

            var youngestChildAge = 100;

            foreach (var family in _data)              // finding all families with kids
            {
                if (family.YoungestChildAge < youngestChildAge)
                {
                    youngestChildAge = family.YoungestChildAge;
                    response.Add(family);
                }
            }
            return response;
        }

        public List<Family> GetFamilyWithOldestChild()
        {
            List<Family> response = new List<Family>();
            
            int oldestChildAge = 0;

            foreach (var family in _data)
            {
                if (family.OldestChild !=null && family.OldestChild.Age > oldestChildAge)
                {
                    oldestChildAge = family.OldestChild.Age;     //here we keeping trak of the oldest child
                }
            }

            foreach (var family in _data)    //we are looping this time , we alreary know the age of all kids
            {
                if (family.OldestChild != null && family.OldestChild.Age == oldestChildAge)  //go here and give me the oldest child from all families
                {
                    response.Add(family);
                }
            }
            return response;
        }
        //public Family GetFamilyWithOldestChild()
        //{

        //    //Family response = null;

        //    //int oldestChildAge = 0;

        //    //foreach (var family in _data)
        //    //{
        //    //    if (family.OldestChildAge > oldestChildAge)
        //    //    {
        //    //        oldestChildAge = family.OldestChildAge;
        //    //        response = family;
        //    //    }
        //    //}
        //    //return response;
        //}

        #region
        //public List<Family> GetFamilyWithOldestChild()
        //{
        //    List<Family> response = new List<Family>();

        //    int oldestChildAge = 0;

        //foreach (var family in _data)   //we iterate through _date, which will bring us data from our list of family
        //{
        //    if (family.OldestChildAge == family.YoungestChildAge && family.OldestChildAge == 0)
        //    {
        //        oldestChildAge = family.OldestChildAge;

        //        if (family.OldestChildAge > oldestChildAge)
        //        {
        //            response.Add(family);
        //        }
        //    }              
        //}
        //return response;

        //int oldestChildAge = 1;

        //foreach (var family in _data)
        //{

        //    if (family.OldestChildAge > oldestChildAge)
        //    {
        //        oldestChildAge = family.OldestChildAge;
        //        response.Add(family);
        //    }
        //}
        //return response;
        //}
        #endregion

        public List<Family> GetFamilyParentNameStartsWith(string letterToFind)
        {
            List<Family> response = new List<Family>();

            foreach (var family in _data)
            {
                if (family.Father.Name.StartsWith(letterToFind) ||
                    family.Mother.Name.StartsWith(letterToFind, StringComparison.CurrentCultureIgnoreCase))
                {
                    response.Add(family);
                }
            }

            return response;
        }
        public void Run()
        {

            var family = new Family();
            family.Nickname = "Ukrainians";
            family.FamilyId = 1;

            Adult father = new Adult();
            //father.FirstName = "Igor";
            //father.LastName = "Dukh";
            father.DateOfBirth = DateTime.Now.AddYears(-30);
            // father.DOB = new DateTime(1987, 1, 1);
            father.Job = "Programmer";
            father.LicenseNumber = "2344454";
            family.Father = father;


            Adult mother = new Adult();
            //mother.FirstName = "Galyna";
            //mother.LastName = "Dukh";
            mother.DateOfBirth = DateTime.Now.AddYears(-20);
            mother.Job = "Nurse";
            mother.LicenseNumber = "B12345";
            family.Mother = mother;

            var child = new Person();
            //child.FirstName = "Solomia";
            child.DateOfBirth = DateTime.Now.AddYears(-10);
            // child.Nickname = "Mia";
            family.Children.Add(child);

            var child2 = new Person();
            //child2.FirstName = "Marko";
            child2.DateOfBirth = DateTime.Now.AddYears(-5);
            //child2.Nickname = "Mark";
            family.Children.Add(child2);

            var child3 = new Person();
            //child3.FirstName = "Andrew";
            child3.DateOfBirth = DateTime.Now.AddYears(-14);
            //child3.Nickname = "Andy";
            family.Children.Add(child3);

            //child.FirstName = "Marko";
            //child.DOB = DateTime.Now.AddYears(-5);
            //family.Children.Add(child);

            // family.Children = new List<Child>();   we don't have to create it because we did it in the constructor

            // Console.WriteLine(family.Nickname);
            // Console.WriteLine(father.FirstName);

            Console.WriteLine(family.ToString());
        }

    }
    
}

