using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Creando items
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());
            AttackItem axe = new AttackItem(25);
            AttackItem bow = new AttackItem(15);
            DefenseItem armor = new DefenseItem(25);
            // Creando heroes y enemigos
            Enemies gandalf = new Enemies("Gandalf", 40);
            gandalf.AddItem(axe);
            Heroes gimli = new Heroes("Gimli");
            gimli.AddItem(bow);
            gimli.AddItem(armor);

            Encounters fight = new Encounters();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}points of health");
            Console.WriteLine($"Gandalf attacks Gimli with {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();


            Console.WriteLine($"Someone cured Gimli. Gimli now has ❤️ {gimli.Health}");

            fight.addHero(gimli);
            fight.addEnemies(gandalf);
            fight.doencounterfigth(fight);

        }
    }
}

