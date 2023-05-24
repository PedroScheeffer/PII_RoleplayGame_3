using System.Collections.Generic;
namespace RoleplayGame
{
    public class Character
    {
        private int health = 100;

        private List<IItem> items = new List<IItem>();

        public Character(string name)
        {
            this.Name = name;
            // bow
            this.AddItem(new AttackItem(15));
            // helmet
            this.AddItem(new DefenseItem(18));
        }

        public string Name { get; set; }
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {

                    value += (item as AttackItem).AttackValue;

                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (DefenseItem item in this.items)
                {

                    value += (item as DefenseItem).DefenseValue;
                    
                }
                return value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }
    }
}