using NUnit.Framework;
using System;
namespace RoleplayGame.Tests
{
    public class BowTest
    {
        [Test]
        public void AttackValueTest()
        {
            Bow bow = new Bow();
            int attackValue = bow.AttackValue;
            Assert.AreEqual(15, attackValue);
        }

    }
}
