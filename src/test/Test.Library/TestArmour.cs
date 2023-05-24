using NUnit.Framework;
using System;
namespace RoleplayGame.Tests
{
    public class ArmourTest
    {
        [Test]
        public void DefenseValueTest()
        {
            Armor armor = new Armor();
            int defenseValue = armor.DefenseValue;
            Assert.AreEqual(25, defenseValue);
        }

    }
}
