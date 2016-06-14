using System;
using NUnit.Framework;

namespace Task4
{   
    [TestFixture]
    class Tests
    {

        // Planet tests
        [Test]
        public void wrongparameter1()
        {
            Assert.Catch(() =>
            {
                var x = new Planet(0, 0, null);
            });
        }

        [Test]
        public void wrongparameter2()
        {
            Assert.Catch(() =>
            {
                var x = new Planet(-10, 0, "test");
            });
        }

        [Test]
        public void wrongparameter3()
        {
            Assert.Catch(() =>
            {
                var x = new Planet(0, -10, "test");
            });
        }

        [Test]
        public void wrongparameter4()
        {
            Assert.Catch(() =>
            {
                var x = new Sun(-10, "arf", Type.Giant);
            });
        }

        [Test]
        public void wrongparameter5()
        {
            Assert.Catch(() =>
            {
                var x = new Sun(123, null, Type.Giant);
            });
        }

        [Test]
        public void checkcorrectPlanet()
        {
            var x = new Planet(8450000, 121230000, "JFHD34");
            Assert.IsTrue(x.Mass == 8450000);
            Assert.IsTrue(x.Name == "JFHD34");
        }

        [Test]
        public void checkcorrectSun()
        {
            var x = new Sun(99999999, "Frankenstein", Type.redDwarf);
            Assert.IsTrue(x.Mass == 99999999);
            Assert.IsTrue(x.Name == "Frankenstein");
            Assert.IsTrue(x.Classification == Type.redDwarf);
        }

        [Test]
        public void canBeUpdated()
        {
            var x = new Planet(8450000, 121230000, "JFHD34");
            x.Update_Distance(12);
            Assert.IsTrue(x.Distance_to_sun == 12);
        }

        [Test]
        public void canNotBeUpdated()
        {
            Assert.Catch(() =>
            {
                var x = new Planet(8450000, 121230000, "JFHD34");
                x.Update_Distance(-112);
            });
         
        }


       
    }
}
