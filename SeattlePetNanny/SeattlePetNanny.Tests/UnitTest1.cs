using SeattlePetNanny.Models;
using System;
using Xunit;

namespace SeattlePetNanny.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanChangeFirstName()
        {
            // Arrange
            var u = new Owner { FirstName = "Joe" };

            // Act
            u.FirstName = "Jill";

            // Assert
            Assert.Equal(u.FirstName, "Jill");

        }

        [Fact]
        public void CanChangeBreed()
        {
            // Arrange
            var d = new Dog { Breed = "Boxer" };

            // Act
            d.Breed = "Pug";

            // Assert
            Assert.Equal(d.Breed, "Pug");

        }

        // I think we need a fake repository to test this?
        //[Fact]
        //public void CanAddDog()
        //{
        //    // Arrange
        //    var u = new Owner { FirstName = "Joe" };
        //    var d = new Dog { Breed = "Boxer" };

        //    // Act
        //    u.Dogs.Add(d);

        //    // Assert
        //    Assert.True(u.Dogs.Count > 0);

        //}

        //[Fact]
        //public void CanAddReportCard()
        //{
        //    // Arrange
        //    var d = new Dog { Breed = "Boxer" };

        //    // Act
        //    d.ReportCards.Add(new ReportCard { OwnerNotes = "fiesty" });


        //    // Assert
        //    Assert.True(d.ReportCards.Count > 0);

        //}

    }
}
