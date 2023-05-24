using NUnit.Framework;
using System;
namespace RoleplayGame.Tests
{
    public class EncountersTest
    {
        [Test]
        public void AddHeroesTest()
        {
            Encounters encounters = new Encounters();
            Heroes hero1 = new Heroes("Hero1");
            encounters.addheroes(hero1);

            //verificar si se agregan correctamente 
            if (encounters.heroex.Contains(hero1))
            {
                Console.WriteLine("Test AddHeroes caso de prueba aprobado");
            }
            else
            {
                Console.WriteLine("Test AddHeroes caso de prueba fallido");
            }
            
        }

        [Test]
        public void AddEnemiesTest()
        {
            Encounters encounters = new Encounters();
            Enemies enemy1 = new Enemies("Enemy1", 10);
            encounters.addenemies(enemy1);
            

            // Verificar que los enemigos se agregaron correctamente
            if (encounters.enemiex.Contains(enemy1))
            {
                Console.WriteLine("Test AddEnemies caso de prueba aprobado");
            }
            else
            {
                Console.WriteLine("Test AddEnemies caso de prueba fallido");
            }
            
        }

        [Test]
        public void RemoveHeroesDeadTest()
        {
            Encounters encounters = new Encounters();
            Heroes hero1 = new Heroes("Hero1");
            encounters.addheroes(hero1);

            encounters.removeheroesdead(hero1);
            if (!encounters.heroex.Contains(hero1))
            {
                Console.WriteLine("Test RemoveHeroesDead caso de prueba aprobado");
            }
            else
            {
                Console.WriteLine("Test RemoveHeroesDead caso de prueba fallido");
            }

        }

        [Test]
        public void RemoveEnemiesDeadTest()
        {
            Encounters encounters = new Encounters();
            Enemies enemy1 = new Enemies("Enemy1", 10);
            encounters.addenemies(enemy1);

            if (!encounters.enemiex.Contains(enemy1))
            {
                Console.WriteLine("Test RemoveEnemiesDead caso de prueba aprobado");
            }
            else
            {
                Console.WriteLine("Test RemoveEnemiesDead caso de prueba fallido");
            }


        }




    }
}
