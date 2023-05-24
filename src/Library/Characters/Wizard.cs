using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard : Character
    {
        private int health = 100;

        private List<IItem> items = new List<IItem>();

        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

        public Wizard(string name) : base(name)
        {            
            this.AddItem(new Staff());
        }
        
        public new int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IAttackItem item in this.items)
                {
                    value += (item as IAttackItem).AttackValue;
                }
                foreach (IMagicalAttackItem item in this.magicalItems)
                {
                    value += (item as IMagicalAttackItem).AttackValue;
                }
                return value;
            }
        }

        public new int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IDefenseItem item in this.items)
                {

                    value += (item as IDefenseItem).DefenseValue;
                }
                foreach (IMagicalDefenseItem item in this.magicalItems)
                {

                    value += (item as IMagicalDefenseItem).DefenseValue;

                }
                return value;
            }
        }
        public void AddItem(IMagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        public void RemoveItem(IMagicalItem item)
        {
            this.magicalItems.Remove(item);
        }

    }
}