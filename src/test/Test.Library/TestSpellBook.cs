using NUnit.Framework;
using System;
namespace RoleplayGame.Tests
{
    public class TestSpellBook
    {
        [Test]
        public void AttackValue()
        {
            SpellsBook spellsBook = new SpellsBook();
            ISpell spell1 = new SpellOne();;
            spellsBook.AddSpell(spell1);

            int attackValue = spellsBook.AttackValue;
            Assert.AreEqual(spell1.AttackValue, attackValue);
        }   
        [Test]
        public void DefenseValue()
        {
            SpellsBook spellsBook = new SpellsBook();
            ISpell spell1 = new SpellOne();
            spellsBook.AddSpell(spell1);
            

            int defenseValue = spellsBook.DefenseValue;
            Assert.AreEqual(spell1.DefenseValue , defenseValue);
        }   

        [Test]
        public void AddSpells()
        {
            SpellsBook spellsBook = new SpellsBook();
            ISpell spell = new SpellOne();

            spellsBook.AddSpell(spell);
            CollectionAssert.Contains(spellsBook.Spells, spell);
        }   

        [Test]
        public void RemoveSpells()
        {
             SpellsBook spellsBook = new SpellsBook();
            ISpell spell = new SpellOne();
            spellsBook.AddSpell(spell);

            spellsBook.RemoveSpell(spell);
            CollectionAssert.DoesNotContain(spellsBook.Spells, spell);
        }   


    }
}
