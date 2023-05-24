using System;

namespace RoleplayGame;

public class Figths : Encounters
{
    public void doencounterfigth(Figths figths)
    {
        int countenemies = 0;
        int counterheroes = 0;
        foreach (var enemie in figths.enemiex)
        {
            countenemies = countenemies + 1;


            foreach (var heroe in figths.heroex)
            {
                counterheroes = counterheroes + 1;

            }
        }

        while (countenemies != 0 & counterheroes != 0)
        {
            if (countenemies == counterheroes)
            {
                foreach (var enemie in figths.enemiex)
                {
                    foreach (var heroe in figths.heroex)
                    {
                        heroe.ReceiveAttack(enemie.AttackValue);
                        if (heroe.Health <= 0)
                        {
                            removeheroesdead(heroe);
                            counterheroes = counterheroes - 1;
                            Console.WriteLine($"El heroe{heroe.Name} ha muerto en el encuentro");
                        }
                        else
                        {
                            Console.WriteLine($"El heroe {heroe.Name} fue atacado y su vida se redujo a {heroe.Health}");
                        }
                    }
                }
                foreach (var heroe in figths.heroex)
                {
                    foreach (var enemie in figths.enemiex)
                    {
                        enemie.ReceiveAttack(heroe.AttackValue);
                        if (enemie.Health <= 0)
                        {
                            removeenemiesdead(enemie);
                            countenemies = countenemies - 1;
                            heroe.victoryPoints = (heroe.victoryPoints + enemie.victoryPoints);
                            Console.WriteLine($"El enemigo {enemie.Name} murio en el encuentro, y el heroe {heroe.Name} obtuvo {enemie.victoryPoints} victory points");
                        }
                        else
                        {
                            Console.WriteLine($"El enemigo {enemie.Name} fue atacado y su vida se redujo a {enemie.Health}");
                        }
                    }
                }


            }
        }

        if (counterheroes <= 0)
        {
            Console.WriteLine("Los ganadores fueron los enemigos");
        }

        if (countenemies <= 0)
        {
            Console.WriteLine("Los ganadores del encuentro fueron los heroes");
        }

    }
}