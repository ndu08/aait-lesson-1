using FullFamily.Data;
using FullFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyStats.Extentions;

namespace FullFamily
{
    public class Program
    {
        static void Main(string[] args)
        {
            var context = new DataContext();

            #region 
            // this code can be done in two ways, just in one line instead of two

            //var families = context.Families;
            // var myTest = new MyTester(families);
            #endregion

            var myTest = new MyTester(context.Families);

            // ------------- Calling Extension Methodts -------------------

            var myName = "Nelya";                     //  it's an extention
            Console.WriteLine(myName.SayHello());     // say hello extention method

            // Task: Create IsValidZipCode Extension Method

            string zip1 = "19115";
            string zipCode = zip1.IsValidZipCode1();
            Console.WriteLine(zip1.IsValidZipCode1());

            var zip = "12345";
            Console.WriteLine(zip.IsValidZipCode());



            // ----------- My Tester Methods Caling -----------

            Console.WriteLine("-----------Get Family With Most Kids-----------");
            List<Family> f = myTest.GetFamilyWithMostKids();
            PrintFamilies(f);

            Console.WriteLine("-----------Get Family With No Kids------------");
            f = myTest.GetFamilyWithNoKids();
            PrintFamilies(f);

            Console.WriteLine("-----------Get Family By Name ------------");
            f = myTest.GetFamilyByName("Jim");
            PrintFamilies(f);

            Console.WriteLine("--------All Father's Names and Ages-----------");
            foreach (var family in context.Families)
            {
                Console.WriteLine($"{family.Father.Name} - {family.Father.Age}");
            }

            Console.WriteLine("--------Average Age of Each Family -----------");
            foreach (var family in context.Families)
            {
                Console.WriteLine(family.FamilyId + " " + family.AverageAge);              
            }

            Console.WriteLine("--------Get Youngest Family -----------");
            f = myTest.GetYoungestFamilyAge();
            PrintFamilies(f);

            // var youngestFamily = myTest.GetYoungestFamily();
            // Console.WriteLine(youngestFamily.Nickname);
            // Console.WriteLine(youngestFamily.FamilyId);
            //Console.WriteLine(youngestFamily.AverageAge);


            Console.WriteLine("--------Get Family With Youngest Child -----------");
            f = myTest.GetFamilyWithYoungestChild();
            PrintFamilies(f);

            Console.WriteLine("--------Get Family With Oldest Child-----------");
             //var oldestChild = myTest.GetFamilyWithOldestChild();
             //Console.WriteLine("Family  " + oldestChild.Nickname+ " " + oldestChild.FamilyId);
             //Console.WriteLine(" Age  " + oldestChild.OldestChildAge);

            f = myTest.GetFamilyWithOldestChild();
            PrintFamilies(f);

            Console.WriteLine("------Get Family With Parent Name Starts With (N)------");
            f = myTest.GetFamilyParentNameStartsWith("N");
            PrintFamilies(f);

            #region
            //var myTest = new MyTester();
            //myTest.Run();
            //foreach (var family in collection)
            //{

            //  }
            #endregion

            Console.ReadLine();
        }
        public static void PrintFamily(Family family)
        {
            Console.WriteLine(family);
        }
        public static void PrintFamilies(List<Family> families)
        {
            foreach (var family in families)
            {
                PrintFamily(family);
            } 
        }



        #region
        //string obj = "!";               // my way 

        //for (int i = 0; i < obj.Length; i++)
        //{
        //    i+=100;
        //    Console.WriteLine("Orest is a nice guy " + i);
        //}

        //var person
        //var message = person.FirstName 

        //message = "Orest is a nice guy";
        //for (int i = 0; i < 100; i++)
        //{
        //    message += "!";
        //}
        //Console.WriteLine(message);

        //var builder = new StringBuilder("Orest is a nice guy");
        //for (int i = 0; i < 100; i++)
        //{
        //    builder.Append("!");
        //}

        //var context = new DataContext();
        //var families = context.Families;
        //foreach (var family in families)
        //{
        //    Console.WriteLine(family);
        //    Console.WriteLine("-----------------");
        //}
        #endregion
    }
}
