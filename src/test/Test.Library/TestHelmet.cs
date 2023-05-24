using NUnit.Framework;
using System;
namespace RoleplayGame.Tests
{
    public class HelmetTest
    {
        [Test]
        public void DefenseValueTest()
        {
            Helmet helmet = new Helmet();
            int defenseValue = helmet.DefenseValue;
            Assert.AreEqual(18, defenseValue);
        }

    }
}
