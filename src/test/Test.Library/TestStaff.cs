using NUnit.Framework;
using System;
namespace RoleplayGame.Tests
{
    public class TestStaff
    {
        [Test]
        public void DefenseValue()
        {
            Staff staff = new Staff();
            int attackValue = staff.AttackValue;
            Assert.AreEqual(100, attackValue);
        }   

        [Test]
        public void DefenseValue()
        {
            Staff staff = new Staff();
            int defenseValue = staff.DefenseValue;
            Assert.AreEqual(100, defenseValue);
        }
    }
}
