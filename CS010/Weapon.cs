using System;

namespace CS010
{
    internal class Weapon 
    {
        private string name = "Weapon name";
        private int damage = 0;
        private string productBy{set; get;} = "Unknown";
        public Weapon()
        {

        }

        public Weapon(string name, int damage) 
        {
            this.name = name;
            this.damage = damage;
        }
        // public Weapon(string abc)
        // {
        //     Console.WriteLine("New Weapon " + abc);
        // }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getDamage()
        {
            return this.damage;
        }

        public void setDamage(int damage)
        {
            this.damage = damage;
        }

        public void attack()
        {
            Console.Write(name + ":\t");
            for (int i = 0; i < damage; i++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }

        public string Name 
        {
            set
            {
                this.name = value;
            }

            get
            {
                return this.name;
            }
        }

        public int Damage 
        {
            set
            {
                this.damage = value;
            }

            get
            {
                return this.damage;
            }
        }

    }
}