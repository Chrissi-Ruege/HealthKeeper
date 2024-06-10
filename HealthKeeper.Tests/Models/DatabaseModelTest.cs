using HealthKeeper.Models.Database;
using HealthKeeper.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthKeeper.Tests.Models
{
    public class DatabaseModelTest
    {

        [Test]
        public void TestCalendarEntry()
        {
            var vm = new CalendarEntry()
            {
                Name = "Test",
                Description = "Test",
                Timestamp = DateTime.Now,
                Id = 42,
                UserId = "123"
            };

            Assert.That(vm.Name, Is.EqualTo("Test"));
            Assert.That(vm.Description, Is.EqualTo("Test"));
            Assert.That(vm.UserId, Is.EqualTo("123"));
            Assert.That(vm.Id, Is.EqualTo(42));
            Assert.That(vm.User, Is.EqualTo(null));
        }

        [Test]
        public void TestFoodJournalEntry()
        {
            var vm = new FoodJournalEntry()
            {
                Name = "Test",
                Id = 42,
                Fat = 42,
                Calories = 42,
                Protein = 42,
                Sugar = 42,
                Carbs = 42,
                Timestamp = DateTime.Now,
            };

            Assert.That(vm.Name, Is.EqualTo("Test"));
            Assert.That(vm.Fat, Is.EqualTo(42));
            Assert.That(vm.Carbs, Is.EqualTo(42));
            Assert.That(vm.Calories, Is.EqualTo(42));
            Assert.That(vm.Sugar, Is.EqualTo(42));
            Assert.That(vm.Protein, Is.EqualTo(42));
            Assert.That(vm.Id, Is.EqualTo(42));
            Assert.That(vm.UserId, Is.EqualTo(null));
        }

        [Test]
        public void TestStatisticEntry()
        {
            var vm = new StatisticEntry()
            {
                Height = 40,
                Weight = 42,
                Timestamp = DateTime.Now,
                Id = 42,
                UserId = "123"
            };

            Assert.That(vm.Height, Is.EqualTo(40));
            Assert.That(vm.Weight, Is.EqualTo(42));
            Assert.That(vm.UserId, Is.EqualTo("123"));
            Assert.That(vm.Id, Is.EqualTo(42));
        }
    }
}
