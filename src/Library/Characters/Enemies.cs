using System;

namespace RoleplayGame;

public class Enemies : Character
{
    public int victorypoints;
    public Enemies(string name, int victorypoints) : base(name)
    {
        this.victorypoints = victorypoints;
    }
}