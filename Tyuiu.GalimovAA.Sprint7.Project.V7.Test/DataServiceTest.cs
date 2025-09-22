using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GalimovAA.Sprint7.Project.V7.Lib;

namespace Tyuiu.GalimovAA.Sprint7.Project.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private const string TestFilePath = "test_data.csv";

        [TestInitialize]
        public void Initialize()
        {
            if (File.Exists(TestFilePath))
                File.Delete(TestFilePath);
        }

        [TestMethod]
        public void AddApartmentTest()
        {
            var service = new DataService(TestFilePath);
            var apartment = new DataService.Apartment
            {
                EntranceNumber = 1,
                ApartmentNumber = 101,
                TotalArea = 75.5,
                LivingArea = 55.0,
                RoomsCount = 3,
                TenantName = "Иванов И.И.",
                RegistrationDate = new DateTime(2020, 1, 15),
                FamilyMembers = 4,
                ChildrenCount = 2,
                HasDebt = false,
                Notes = "Примерная семья"
            };

            service.AddApartment(apartment);
            var apartments = service.GetAllApartments();

            Assert.AreEqual(1, apartments.Count);
            Assert.AreEqual(101, apartments[0].ApartmentNumber);
        }

        [TestMethod]
        public void StatisticsTest()
        {
            var service = new DataService(TestFilePath);

            service.AddApartment(new DataService.Apartment
            {
                EntranceNumber = 1,
                ApartmentNumber = 101,
                TotalArea = 75.5,
                FamilyMembers = 4,
                ChildrenCount = 2,
                HasDebt = false,
                TenantName = "Иванов",
                RegistrationDate = DateTime.Now,
                LivingArea = 55,
                RoomsCount = 3,
                Notes = ""
            });

            var stats = service.GetStatistics();

            Assert.AreEqual(1, stats["TotalApartments"]);
            Assert.AreEqual(75.5, stats["TotalArea"]);
        }

        [TestMethod]
        public void SearchTest()
        {
            var service = new DataService(TestFilePath);

            service.AddApartment(new DataService.Apartment
            {
                EntranceNumber = 1,
                ApartmentNumber = 101,
                TotalArea = 75.5,
                TenantName = "Иванов",
                RegistrationDate = DateTime.Now,
                LivingArea = 55,
                RoomsCount = 3,
                FamilyMembers = 4,
                ChildrenCount = 2,
                HasDebt = false,
                Notes = ""
            });

            var results = service.SearchApartments("Иванов");

            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("Иванов", results[0].TenantName);
        }
    }
}