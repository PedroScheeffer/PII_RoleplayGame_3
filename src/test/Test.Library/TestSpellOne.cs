using NUnit.Framework;
using System;
namespace RoleplayGame.Tests
{
    public class TestSpellOne
    {
        [Test]
        public void AttackValue()
        {
            SpellOne spellOne = new SpellOne();
            int attackValue = spellOne.AttackValue;
            Assert.AreEqual(70, attackValue);
        }   

        [Test]
        public void DefenseValue()
        {
            SpellOne spellOne = new SpellOne();
            int defenseValue = spellOne.DefenseValue;
            Assert.AreEqual(70, defenseValue);
        }
    }
}
