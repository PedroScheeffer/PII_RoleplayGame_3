using System;

namespace RoleplayGame;

public class Heroes : Character
{
    public int victoryPoints;
    public Heroes(string name) : base(name)
    {
    }
    public void addVictoryPoints(Enemies enemy){
        victoryPoints = victoryPoints + enemy.victoryPoints;
    }
}