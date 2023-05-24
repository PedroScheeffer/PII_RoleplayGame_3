using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            Axe axe= new Axe();
            Bow bow=new Bow();
            Armor armor1=new Armor();

            Figths figths1=new Figths();

            Enemies gandalf = new Enemies("Gandalf",40);
            gandalf.AddItem(axe);
            

            Heroes gimli = new Heroes("Gimli");
            gimli.AddItem(bow);
            gimli.AddItem(armor1);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}points of health");
            Console.WriteLine($"Gandalf attacks Gimli with {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();


            Console.WriteLine($"Someone cured Gimli. Gimli now has ❤️ {gimli.Health}");

            figths1.addheroes(gimli);
            figths1.addenemies(gandalf);
            figths1.doencounterfigth(figths1);

        }
    }
}

