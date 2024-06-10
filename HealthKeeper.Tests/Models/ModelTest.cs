using HealthKeeper.Models.Views;
namespace HealthKeeper.Tests.Models
{
    public class ModelTest
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
        public void TestPostStatisticEntry()
        {
            var vm = new PostStatisticEntry(43, 42);

            Assert.That(vm.Height, Is.EqualTo(42));
            Assert.That(vm.Weight, Is.EqualTo(43));
        }
    }
}
