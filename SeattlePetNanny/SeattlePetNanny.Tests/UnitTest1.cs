using SeattlePetNanny.Models;
using SeattlePetNanny.Controllers;
using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using SeattlePetNanny.Data;
using Microsoft.EntityFrameworkCore;

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
        public void CanChangeLastName()
        {
            // Arrange
            var u = new Owner { LastName = "Dirt" };

            // Act
            u.LastName = "Pam";

            // Assert
            Assert.Equal(u.LastName, "Pam");

        }

        [Fact]
        public void CanChangeAddress()
        {
            // Arrange
            var u = new Owner { Address = "345 Road Ave" };

            // Act
            u.Address = "718 State Street";

            // Assert
            Assert.Equal(u.Address, "718 State Street");

        }
        [Fact]
        public void CanChangeLocation()
        {
            // Arrange
            var u = new Owner { Location = "Belltown" };

            // Act
            u.Location = "South Lake Union";

            // Assert
            Assert.Equal(u.Location, "South Lake Union");

        }

        [Fact]
        public void CanChangeTemperment()
        {
            // Arrange
            var d = new Dog { Temperment = "Angry" };

            // Act
            d.Temperment = "Happy";

            // Assert
            Assert.Equal(d.Temperment, "Happy");

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

        [Fact]
        public void CanChangeOwnerId()
        {
            // Arrange
            var d = new Dog { OwnerId = 2 };

            // Act
            d.OwnerId = 3;

            // Assert
            Assert.Equal(d.OwnerId, 3);

        }

        [Fact]
        public void CanChangeOwnerNotes()
        {
            // Arrange
            var d = new Dog { OwnerNotes = "This is a good dog." };

            // Act
            d.OwnerNotes = "This is a bad dog.";

            // Assert
            Assert.Equal(d.OwnerNotes, "This is a bad dog.");

        }

        [Fact]
        public void CanChangeWorkerNotes()
        {
            // Arrange
            var d = new Dog { WorkerNotes = "He pooped!" };

            // Act
            d.WorkerNotes = "She pooped!";

            // Assert
            Assert.Equal(d.WorkerNotes, "She pooped!");

        }

        [Fact]
        public void CanChangeAdminFirstName()
        {
            // Arrange
            var d = new Admin { FirstName = "Lorenzo" };

            // Act
            d.FirstName = "Mark";

            // Assert
            Assert.Equal(d.FirstName, "Mark");

        }

        [Fact]
        public void CanChangeAdminLastName()
        {
            // Arrange
            var d = new Admin { LastName = "Wells" };

            // Act
            d.LastName = "Duke";

            // Assert
            Assert.Equal(d.LastName, "Duke");

        }

        [Fact]
        public void CanChangeAdminNeighborhood()
        {
            // Arrange
            var d = new Admin { Neighborhood = "Lakeview" };

            // Act
            d.Neighborhood = "Washington";

            // Assert
            Assert.Equal(d.Neighborhood, "Washington");

        }

        [Fact]
        public void CanChangeReportCardReport()
        {
            // Arrange
            var d = new ReportCard { Report = "A" };

            // Act
            d.Report = "D";

            // Assert
            Assert.Equal(d.Report, "D");

        }

        [Fact]
        public void CanChangeReportCardOwnerNotes()
        {
            // Arrange
            var d = new ReportCard { OwnerNotes = "Stacy has to go." };

            // Act
            d.OwnerNotes = "Stacy can stay.";

            // Assert
            Assert.Equal(d.OwnerNotes, "Stacy can stay.");

        }

        [Fact]
        public void CanChangeReportCardWorkerNotes()
        {
            // Arrange
            var d = new ReportCard { WorkerNotes = "This dog stinks." };

            // Act
            d.WorkerNotes = "Dog is cleaned.";

            // Assert
            Assert.Equal(d.WorkerNotes, "Dog is cleaned.");

        }

        [Fact]
        public void CanChangeWorkerFirstName()
        {
            // Arrange
            var d = new Worker { FirstName = "Stacy" };

            // Act
            d.FirstName = "Susan";

            // Assert
            Assert.Equal(d.FirstName, "Susan");

        }
        [Fact]
        public void CanChangeWorkerLastName()
        {
            // Arrange
            var d = new Worker { LastName = "Tuts" };

            // Act
            d.LastName = "Toots";

            // Assert
            Assert.Equal(d.LastName, "Toots");

        }

        [Fact]
        public void CanChangeWorkerNeighborhood()
        {
            // Arrange
            var d = new Worker { Neighborhood = "Franklin" };

            // Act
            d.Neighborhood = "Templeton";

            // Assert
            Assert.Equal(d.Neighborhood, "Templeton");

        }

        [Fact]
        public void DoesReturnView()
        {
            var controller = new HomeController();
            // Arrange
            HomeController a = new HomeController();
            // Act
            IActionResult result = a.About();

            // Assert
            Assert.IsType<ViewResult>(result);

        }

        //[Fact]
        //public void SuccessfullyAddFirstNameToDatabase()
        //{
        //    //Arrange
        //    var options = new DbContextOptionsBuilder<SeattlePetNannyContext>();
        //    options.UseSqlServer("Server=tcp:seattlepetnanny.database.windows.net,1433;Initial Catalog=SeattlePetNannyDatabase;Persist Security Info=False;User ID=adamcamgeorge;Password=CassP@$$word123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");

        //    var context = new SeattlePetNannyContext(options.Options);
        //    // may need to add all the properties to this table
        //    context.Add(new Owner { FirstName = "Stacy" });
        //    context.SaveChanges();
        //    var name = context.Owner.FirstOrDefaultAsync(m => m.FirstName == "Stacy");

        //    Assert.NotNull(name);
        //}

        //[Fact]
        //public void SuccessfullyAddLastNameToDatabase()
        //{
        //    //Arrange
        //    var options = new DbContextOptionsBuilder<SeattlePetNannyContext>();
        //    options.UseSqlServer("Server=tcp:seattlepetnanny.database.windows.net,1433;Initial Catalog=SeattlePetNannyDatabase;Persist Security Info=False;User ID=adamcamgeorge;Password=CassP@$$word123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");

        //    var context = new SeattlePetNannyContext(options.Options);
        //    // may need to add all the properties to this table
        //    context.Add(new Owner { LastName = "Yule" });
        //    context.SaveChanges();
        //    var name = context.Owner.FirstOrDefaultAsync(m => m.LastName == "Yule");

        //    Assert.NotNull(name);
        //}
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
