using NUnit.Framework;
using System;
namespace RoleplayGame.Tests
{
    public class TestShield
    {
        [Test]
        public void DefenseValue()
        {
            Shield shield = new Shield();
            int defenseValue = shield.DefenseValue;
            Assert.AreEqual(14, defenseValue);
        }   

    }
}
