namespace RoleplayGame
{
    public class AttackItem: IItem
    {
        public int AttackValue { get; }
        public AttackItem(int attackValue = 100){
            AttackValue = attackValue;
        }
    }
}