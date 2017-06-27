using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prototype;

namespace PrototypeTest
{
    [TestClass]
    public class PrototypeCloneTest
    {
        Dinner _dinner;
        Dinner _clonedDinner;

        [TestInitialize]
        public void Setup()
        {
            _dinner = new Dinner("Main Course", "Dessert")
            {
                Restaurant = "Restaurant",
                ChefName = "Chef"
            };
            _clonedDinner = (Dinner)_dinner.Clone();
            _clonedDinner.ChefName = "Another Chef";
            _clonedDinner.Restaurant = "Better Restaurant";
        }

        [TestMethod]
        public void VerifyClonedProperties()
        {
            Assert.AreEqual(_dinner.MainCourse, _clonedDinner.MainCourse);
            Assert.AreEqual(_dinner.Dessert, _clonedDinner.Dessert);
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
            Assert.AreNotEqual(_dinner.ChefName, _clonedDinner.ChefName);
            Assert.AreNotEqual(_dinner.Restaurant, _clonedDinner.Restaurant);
        }
    }
}
