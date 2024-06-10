using HealthKeeper.Models.Views;
using NuGet.ContentModel;
namespace HealthKeeper.Tests.Models
{
    public class ViewModelTest
    {


        [Test]
        public void TestErrorViewModel()
        {
            var vm = new ErrorViewModel();
            var vm2 = new ErrorViewModel("Error");

            Assert.That(vm2.ShowError, Is.EqualTo(true));
            Assert.That(vm.ShowError, Is.EqualTo(false));

            Assert.That(vm2.Error, Is.EqualTo("Error"));
        }

        [Test]
        public void TestLoginForm()
        {
            var vm = new LoginForm()
            {
                UserName = "test1",
                Password = "test2",
            };

            Assert.That(vm.UserName, Is.EqualTo("test1"));
            Assert.That(vm.Password, Is.EqualTo("test2"));
        }


        [Test]
        public void TestRegisterForm()
        {
            var vm = new RegisterForm()
            {
                Username = "test1",
                Password = "test2",
                Email = "a@a.a",
                PasswordConfirm = "test2"
            };

            Assert.That(vm.Username, Is.EqualTo("test1"));
            Assert.That(vm.Password, Is.EqualTo("test2"));
            Assert.That(vm.PasswordConfirm, Is.EqualTo("test2"));
            Assert.That(vm.Email, Is.EqualTo("a@a.a"));
        }

        [Test]
        public void TestStatisticModel()
        {
            var vm = new StatisticModel("error")
            {
                Statistics = new()
            };
            vm.Statistics.Add(new Controllers.StatisticsController.GetStatisticEntry(DateTime.Now, 42, 42, 42, ""));

            Assert.That(vm.Statistics.Count, Is.EqualTo(1));
            Assert.That(vm.Error, Is.EqualTo("error"));
            Assert.That(vm.ShowError, Is.EqualTo(true));
        }

        [Test]
        public void TestStatisticModelWithoutError()
        {
            var vm = new StatisticModel()
            {
                Statistics = new()
            };
            vm.Statistics.Add(new Controllers.StatisticsController.GetStatisticEntry(DateTime.Now, 42, 42, 42, ""));

            Assert.That(vm.Statistics.Count, Is.EqualTo(1));
            Assert.That(vm.ShowError, Is.EqualTo(false));
        }

        [Test]
        public void TestPostStatisticEntry()
        {
            var vm = new PostStatisticEntry(43, 42);

            Assert.That(vm.Height, Is.EqualTo(42));
            Assert.That(vm.Weight, Is.EqualTo(43));
        }
    }
}
