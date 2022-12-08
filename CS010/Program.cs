using System;

namespace CS010
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon pistol;
            pistol = new Weapon();

            Weapon rifle = new Weapon();
            rifle.setName("Rifle");
            rifle.setDamage(5);
            Console.WriteLine(rifle.getName());
            rifle.attack();

            Weapon machineGun = new Weapon(damage: 15, name: "Machine Gun");
            machineGun.attack();

            Weapon knife = new Weapon();
            knife.Name = "Knife";
            knife.Damage = 2;
            knife.attack();
            Console.WriteLine(knife.Name + " " + knife.Damage);
        }
    }
}