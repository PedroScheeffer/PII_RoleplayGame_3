using NUnit.Framework;
using System;
namespace RoleplayGame.Tests
{
    public class TestSword
    {
        
        [Test]
        public void AtackValue()
        {
            Sword sword = new Sword();
            int attackValue = sword.AttackValue;
            Assert.AreEqual(20, attackValue);
        }
    }
}
