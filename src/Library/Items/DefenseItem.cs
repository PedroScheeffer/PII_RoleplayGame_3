namespace RoleplayGame
{
    public class DefenseItem: IItem
    {
        public int DefenseValue { get; }
        public DefenseItem(int defenseValue = 100){
            DefenseValue = defenseValue;
        }
    }
}