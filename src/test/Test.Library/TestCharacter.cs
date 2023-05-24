using NUnit.Framework;
using System;
namespace RoleplayGame.Tests
{
    public class CharacterTest
    {
        [Test]
        //calcula valoe de ataque del personaje en funcion de los elementos 
        //test con Bow
        public void AttackValueTest()
        {
            Character character = new Character("Ejemplo");
            IItem bow = new Bow();
            character.AddItem(bow);

            int valorEsperado= bow.AttackValue; 
            int valorActual = character.AttackValue;

            // Comprobar si el valor de ataque es el esperado
            if (valorActual == valorEsperado)
            {
                Console.WriteLine("Test AttackValue caso de prueba aprobad");
            }
            else
            {
                Console.WriteLine("Test AttackValue fallo. Valor esperado: " + valorEsperado + ", Valor actual: " + valorActual);
            }
        }

        [Test]
        //como defensa se utiliza Armor
        public void DefenseValueTest()
        {
            Character character = new Character("Ejemplo");
            IItem armor = new Armor();
            character.AddItem(armor);

            int valorEsperado = armor.DefenseValue; 
            int valorActual = character.DefenseValue;

            if (valorActual == valorEsperado)
            {
                Console.WriteLine("Test AttackValue caso de prueba aprobad");
            }
            else
            {
                Console.WriteLine("Test AttackValue fallo. Valor esperado: " + valorEsperado + ", Valor actual: " + valorActual);
            }
        }

        [Test]
        public void HealthTest()
        {
            Character character = new Character("Ejemplo");
            int inicialHealth = character.Health;

            int nuevaHealth = 80;
            character.Health = nuevaHealth;
            int actualHealth = character.Health;

            if (actualHealth == nuevaHealth)
            {
                Console.WriteLine("La prueba de Health paso correctamente al establecer un nuevo valor de salud.");
            }
            else
            {
                Console.WriteLine("La prueba de Health fallo al establecer un nuevo valor de salud. Valor esperado: " + nuevaHealth + ", Valor actual: " + actualHealth);
            }
        }

        [Test]
        public void ReceiveAttackTest()
        {
            Character character = new Character("Ejemplo");
            character.Health = 100;

            character.AddItem(new Armor());
            int defenseValue = character.DefenseValue;

            int actualHealth = character.Health;
            if (actualHealth == 100)
            {
                Console.WriteLine("La prueba de ReceiveAttack paso correctamente ya que el poder de ataque es igual al valor de defensa.");
            }
            else
            {
                Console.WriteLine("La prueba de ReceiveAttack fallo ya que el poder de ataque es igual al valor de defensa. Valor esperado: 100, Valor actual: " + actualHealth);
            }

        }

        [Test]
        public void CureTest()
        {
            Character character = new Character("Ejemplo");
            character.Health = 50;

            character.Cure();

            int actualHealth = character.Health;
            if (actualHealth == 100)
            {
                Console.WriteLine("La prueba de Cure paso correctamente. La salud subio a 100.");
            }
            else
            {
                Console.WriteLine("La prueba de Cure fallo ya que el valor esperaod era 100 y el Valor actual es: " + actualHealth);
            }


        }

        [Test]
        public void AddItemTest()
        {
            Character character = new Character("Ejemplo");
            IItem sword = new Sword();

            character.AddItem(sword);
            List<IItem> characterItems = character.GetItems();

            bool agregarItem = false;
            foreach (IItem item in characterItems)
            {
                if (item == sword)
                {
                    agregarItem = true;
                    
                }
            }

            if (agregarItem)
            {
                Console.WriteLine("La prueba de AddItem paso correctamente. El elemento se agrego correctamente al personaje.");
            }
            else
            {
                Console.WriteLine("La prueba de AddItem fallo. El elemento no se agrego correctamente al personaje.");
            }

        }



    }
}
