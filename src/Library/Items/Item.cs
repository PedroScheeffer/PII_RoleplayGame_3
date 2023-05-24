namespace RoleplayGame
{
    public class Item: IItem
    {
        public int DefenseValue { get; }
       public int AttackValue { get; }

        public Item(int attackValue = 100, int defenseValue = 100){
            DefenseValue = defenseValue;
        }
    }
}