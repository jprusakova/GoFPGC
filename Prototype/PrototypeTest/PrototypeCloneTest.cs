using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prototype;

namespace PrototypeTest
{
    [TestClass]
    public class PrototypeCloneTest
    {
        Dinner _steakDinner;
        Dinner _vegetarianDinner; 
        Dinner _clonedDinner;
        Dinner _clonedVegetarianOption;

        [TestInitialize]
        public void Setup()
        {
            SetupSteakDinner();
            SetupVegetarianDinner();
        }

        [TestMethod]
        public void VerifyClonedProperties()
        {
            Assert.AreEqual(_steakDinner.MainCourse, _clonedDinner.MainCourse);
            Assert.AreEqual(_steakDinner.Dessert, _clonedDinner.Dessert);

            Assert.AreEqual(_vegetarianDinner.MainCourse, _clonedVegetarianOption.MainCourse);
            Assert.AreEqual(_vegetarianDinner.Dessert, _clonedVegetarianOption.Dessert);

            Assert.AreNotEqual(_clonedDinner.MainCourse, _clonedVegetarianOption.MainCourse);
            Assert.AreNotEqual(_clonedDinner.Dessert, _clonedVegetarianOption.Dessert);
        }

        [TestMethod]
        public void ClonnedAdditionalPropertiesTest()
        {
            Assert.AreEqual("Another Chef", _clonedDinner.ChefName);
            Assert.AreEqual("Better Restaurant", _clonedDinner.Restaurant);
        }

        [TestMethod]
        public void OriginalAdditionalPropertiesTest()
        {
            Assert.AreNotEqual(_steakDinner.ChefName, _clonedDinner.ChefName);
            Assert.AreNotEqual(_steakDinner.Restaurant, _clonedDinner.Restaurant);
        }

        private void SetupVegetarianDinner()
        {
            _vegetarianDinner = new Dinner("Beans and Vegetables", "Cake")
            {
                Restaurant = "Vegetarian Restaurant",
                ChefName = "TV Personality"
            };

            _clonedVegetarianOption = (Dinner)_vegetarianDinner.Clone();
        }

        private void SetupSteakDinner()
        {
            _steakDinner = new Dinner("Steak And Potatoes", "Dessert")
            {
                Restaurant = "Restaurant",
                ChefName = "Meat Butcher"
            };

            _clonedDinner = (Dinner)_steakDinner.Clone();
            _clonedDinner.ChefName = "Another Chef";
            _clonedDinner.Restaurant = "Better Restaurant";
        }
    }
}
