using System;
using System.Collections.Generic;

namespace RoleplayGame;
public class Encounters
{
    public List<Heroes> heroes = new List<Heroes>();
    public List<Enemies> enemies = new List<Enemies>();


    public void addHero(Heroes hero)
    {
        this.heroes.Add(hero);
    }

    public void addEnemies(Enemies enemy)
    {
        this.enemies.Add(enemy);
    }

    public void removeHero(Heroes hero)
    {
        this.heroes.Remove(hero);
    }

    public void removeEnemy(Enemies enemy)
    {
        this.enemies.Remove(enemy);
    }

    public void doEncounter()
    {
        int i = 0;
        while (heroes.Count + enemies.Count >= 2)
        {
            foreach (var enemy in enemies)
            {
                heroes[i].ReceiveAttack(enemy.AttackValue);
                if (heroes[i].Health <= 0)
                {
                    removeHero(heroes[i]);
                    Console.WriteLine($"El heroe{heroes[i].Name} ha muerto en el encuentro");
                }
                else
                {
                    Console.WriteLine($"El heroe {heroes[i].Name} fue atacado y su vida se redujo a {heroes[i].Health}");
                }
                if (i == heroes.Count-1)
                {
                    i = 0;
                }else
                {
                    i++;
                }

            }
            foreach (var heroe in heroes)
            {
                foreach (var enemie in enemies)
                {
                    enemie.ReceiveAttack(heroe.AttackValue);
                    if (enemie.Health <= 0)
                    {
                        removeEnemy(enemie);
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
        Console.WriteLine("Not Enough Characters /n Enconters ends...");
        foreach (var heroe in heroes)
        {
            if(heroe.victoryPoints > 5){
                heroe.Cure();
                Console.WriteLine($"El heroe {heroe.Name} fue curado {heroe.Health}");
            }
        }
        return;


    }

}