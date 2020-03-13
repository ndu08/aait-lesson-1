using System;
using System.Collections.Generic;
using FullFamily.Data;
using FullFamily.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FamilyStats.Test
{
    [TestClass] //we created this way so it knows it's test
    public class MyTesterTest
    {
        private MyTester stats;   //doesn't matter how many methods run we will have stats 
        // you need to declare this variable on class level scoope because it will be seen from every method in the class

        [TestInitialize]        //  it will be runed first of all
        public void Init()          // in this method we will initialize our data and pass it to variable on a slass scope level stats
        {
            var context = new DataContext();                  // it will run before any method runs
            stats = new MyTester(context.Families);
        }

        [TestMethod]    // it's called decorator
        public void GetFamilyWithNoKidsTest()
        {
            //Arrange
               //var context = new DataContext();          //this ststs we declared on class scoope level, that is why we don't need it here
               //var stats = new MyTester(context.Families);

            //Act
            //var fam = stats.GetFamilyWithNoKids();
            List<Family> fam = stats.GetFamilyWithNoKids();

            //Assert

            //-----This method to check the condition if we know number how many fam with no kids------
            Assert.IsNotNull(fam);
            Assert.IsTrue(fam.Count == 1);  //based on a data we send we will have 1 family
            Assert.AreEqual(1, fam.Count); //here we expecting just one family with no kids,  if we will have 2 elements-it will fail
            //how to get index ? 
            Assert.AreEqual(3, fam[0].FamilyId); //array notation to get to that element


            //-----This method to check the condition if we are not sure how many fam don't have kids------
            Assert.IsNotNull(fam);
            Assert.IsTrue(fam.Count > 0);  //based on a data we send we will have 1 family
            //how to get index ? 
            foreach (var family in fam)
            {
                Assert.IsTrue(family.Children.Count == 0);
            }
        }

        [TestMethod]   
        public void GetFamilyWithMostKidsTest()
        {
            //Arrange

            //Act
            List<Family> fam = stats.GetFamilyWithMostKids();

            //Assert
            Assert.IsNotNull(fam);
            Assert.IsTrue(fam.Count > 0);
            Assert.IsTrue(fam[0].FamilyId == 1);
            Assert.AreEqual(fam[0].Children.Count, 3);  //it means this family has 3 kids
        }

        [TestMethod]        
        public void GetFamilyByNameTest()
        {
            //Arrange

            //Act
            List<Family> fam = stats.GetFamilyByName("jim");
            Assert.AreEqual(fam[0].FamilyId, 1);
            fam = stats.GetFamilyByName("Emma");
            Assert.AreEqual(fam[0].FamilyId, 2);
            fam = stats.GetFamilyByName("MATTHEW");
            Assert.AreEqual(fam[0].FamilyId, 2);

            //Assert 
        }

        [TestMethod]
        public void FamilyAverageAgeTest()
        {
            int fatherAge = 25;
            int motherAge = 23;

            var family = new Family();
            family.Father = new Adult();
            family.Mother = new Adult();

            family.Father.DateOfBirth = DateTime.Today.AddYears(-fatherAge);
            family.Mother.DateOfBirth = DateTime.Today.AddYears(-motherAge);

            Assert.AreEqual(24, family.AverageAge);
            family.Children.Add(new Person() { DateOfBirth = DateTime.Today.AddYears(-12) });
            Assert.AreEqual(20, family.AverageAge);

        }

        [TestMethod]
        public void GetFamilyWithYoungestChildTest()
        {
            int youngestChildAge = 3;

            var family = new Family();

            family.Children.Add(new Person() { DateOfBirth = DateTime.Today.AddYears(-3) });
            Assert.AreEqual(3, family.YoungestChildAge);
        }

        [TestMethod]
        public void GetFamilyWithOldestChildTest()
        {
            List<Family> fam = stats.GetFamilyWithOldestChild();//  We know that this method will bring us data who is the oldest

            Assert.IsNotNull(fam);
            Assert.IsTrue(fam.Count > 0);
           // Assert.AreEqual(16, fam[0].OldestChild.Age);   this will work if we know that we have just one kid with age 16
            foreach (var family in fam)   //this case if we expecting that a few families will have a few the same kids with age 16
            {
                Assert.AreEqual(16, family.OldestChild.Age);
            }

            //int oldestChildAge = 16;

            //var family = new Family();

            //family.Children.Add(new Person() { DateOfBirth = DateTime.Today.AddYears(-16) });

            //Assert.AreEqual(16, family.OldestChildAge);
        }

        [TestMethod]
        public void GetFamilyParentNameStartsWithTest()
        {
            List<Family> fam = stats.GetFamilyParentNameStartsWith("N");

           Assert.AreEqual(fam[0].FamilyId, 2);
            //fam = stats.GetFamilyParentNameStartsWith("N");
        }

        [TestMethod]
        public void GetYoungestFamilyAgeTest()
        {
            //Arrange

            //Act
            List<Family> fam = stats.GetYoungestFamilyAge();
           
            //Assert
            Assert.IsNotNull(fam);

            //Assert.IsTrue(fam.Count == 1);  //based on a data we send we will have 1 family
           // Assert.AreEqual(1, fam.Count); //here we expecting just one family with no kids,  if we will have 2 elements-it will fail
            //how to get index ? 
            Assert.AreEqual(1, fam[0].FamilyId); //array notation to get to that element
            Assert.AreEqual(16, fam[0].AverageAge);
        }

    }
    
}
