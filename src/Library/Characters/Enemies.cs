using System;

namespace RoleplayGame;

public class Enemies : Character
{
    public int victoryPoints { get; }
    public Enemies(string name, int victorypoints) : base(name)
    {
        this.victoryPoints = victorypoints;
    }
}