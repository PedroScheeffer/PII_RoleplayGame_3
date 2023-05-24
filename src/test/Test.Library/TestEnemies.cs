using NUnit.Framework;
using System;
namespace RoleplayGame.Tests
{
    public class EnemiesTest
    {
        [Test]
        public void ConstructorEnemiesTest()
        {
            string name1 = "Enemy1";
            int victoryPoints1 = 10;
            Enemies enemy1 = new Enemies(name1, victoryPoints1);


            //verificar si los valores son asignadps correctamente
            if (enemy1.Name == name1 && enemy1.victorypoints == victoryPoints1)
            {
                Console.WriteLine("Caso de prueba 1 aprobado");
            }
            else
            {
                Console.WriteLine("Caso de prueba 1 fallido");
            }

        }

    }
}
