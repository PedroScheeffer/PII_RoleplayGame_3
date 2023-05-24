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
            
    }

}