using NUnit.Framework;
using System;
namespace RoleplayGame.Tests
{
    public class TestHeroes
    {
        [Test]
        public void ConstructorHeroesTest()
        {
            string name1 = "Hero1";
            Heroes hero1 = new Heroes(name1);

            //verificar si los valores son asignados correctamente

            if (hero1.Name == name1)
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
