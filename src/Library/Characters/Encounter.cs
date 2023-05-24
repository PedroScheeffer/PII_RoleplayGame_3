using System;
using System.Collections.Generic;

namespace RoleplayGame;

public class Encounters
{
    public List<Heroes> heroex = new List<Heroes>();
    public List<Enemies> enemiex = new List<Enemies>();


    public void addheroes(Heroes heroef)
    {
        this.heroex.Add(heroef);
    }

    public void addenemies(Enemies enemief)
    {
        this.enemiex.Add(enemief);
    }

    public void removeheroesdead(Heroes heroef)
    {
        this.heroex.Remove(heroef);
    }

    public void removeenemiesdead(Enemies enemief)
    {
        this.enemiex.Remove(enemief);
    }

    public void doencounter()
    {
    }

}