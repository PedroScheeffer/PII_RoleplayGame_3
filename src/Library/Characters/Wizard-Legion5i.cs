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
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalAttackItem)
                    {
                        value += (item as IMagicalAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public new int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalDefenseItem)
                    {
                        value += (item as IMagicalDefenseItem).DefenseValue;
                    }
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