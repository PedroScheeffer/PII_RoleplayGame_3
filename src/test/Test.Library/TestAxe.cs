using NUnit.Framework;
using System;
namespace RoleplayGame.Tests
{
    public class AxeTest
    {
        [Test]
        public void AttackValueTest()
        {
            Axe axe = new Axe();
            int attackValue = axe.AttackValue;
            Assert.AreEqual(25, attackValue);
        }

    }
}
