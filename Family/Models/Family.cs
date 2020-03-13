using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFamily.Models
{
    public class Family
    {
        public Family()
        {
            Children = new List<Person>();    //inisializing an empty list  it never will be null because it in the constructor
        }
        public int FamilyId { get; set; }
        public string Nickname { get; set; }
        public Adult Father { get; set; }
        public Adult Mother { get; set; }
        public List<Person> Children { get; set; }
        public int YoungestChildAge 
        {
            get
            {
                int youngest = 100;

                foreach (var item in Children)
                {
                    if(item.Age < youngest)
                    {
                        youngest = item.Age;
                    }
                }
                return youngest;
            }
        }


        // ------------Orest's version -----------------------
        public Person OldestChild 
        { 
            get
            {
                if (this.Children.Count ==0)
                {
                    return null;        //null will be if we don't have kids, that is why we checking this condition here
                }

                Person oldestChild= Children[0];

                foreach (var child in Children)
                {
                    if (child.Age > oldestChild.Age)
                    {
                        oldestChild = child;
                    }
                }
                return oldestChild;
            }
        }

        //public int OldestChildAge
        //{
        //    get
        //    {
        //        int oldest = 1;
        //        foreach (var item in Children)
        //        {
        //            if (item.Age > oldest)
        //            {
        //                oldest = item.Age;
        //            }
        //        }
        //        return oldest;
        //    }
        //}
        public int AverageAge
        {
            get
            {
                var age = Father.Age + Mother.Age;

                foreach (var child in Children)
                {
                    age = age + child.Age;
                }

                return age / (2 + Children.Count);
            }
        }

        

        public override string ToString()
        {

            //Family One (1)
            var separator = "    ";
            var builder = new StringBuilder();
            builder.AppendLine($"Family {Nickname} ({FamilyId})");
            builder.AppendLine($"{separator} Parent");
            builder.AppendLine($"{separator}{separator}{Father.Name} - {DateTime.Now.Year - Father.DateOfBirth.Year}, {Father.Job}, {Father.LicenseNumber}");
            builder.AppendLine($"{separator}{separator}{Mother.Name} - {DateTime.Now.Year - Mother.DateOfBirth.Year}, {Mother.Job}, {Mother.LicenseNumber}");
            builder.AppendLine($"{separator} Kids");

            foreach (var child in Children)
            {
                builder.AppendLine($"{separator}{ separator}{child.Name} - { DateTime.Now.Year - child.DateOfBirth.Year}");
            }
            return builder.ToString();

            //Console.WriteLine("Family" + Nickname + "("+ Id + ")" );
            //Console.WriteLine("Father" + Father);
           
           // return base.ToString();

           // Console.WriteLine(MyFamily);
        }

        //overrite to 
        //Console.WriteLine(family.ToString);
    }
}
