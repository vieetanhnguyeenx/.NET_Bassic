using System;

namespace CS014
{
    /*
    tinh ke thua
    A, B
    B ke thua A

    A - lop co so
    B - lop ke thua

    Class B : A
    {

    }

    Animal
        - Legs
        - Weight
        - Show Legs
    Cat : Animal
        -
    */

    class Animal
    {
        public int leg {set;get;}
        public float weight {set; get;}
        
        public void showLeg()
        {
            Console.WriteLine($"Legs:{leg}");
        }
    }

    class Cat : Animal
    {
        public string food {set;get;}
        public Cat()
        {
            this.leg = 4;
            this.food = "Mouse";
        }
        public void Eat()
        {
            Console.WriteLine(food);
        }

        public new void showLeg()
        {
            Console.WriteLine($"loai meo co {leg} chan");
        }

        public void showInfo(){
            base.showLeg();
            showLeg();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.weight = 5;
            Console.WriteLine(c.food + "\t" + c.leg + "\t" + c.weight);
            c.Eat();
            c.showInfo();
        }
    }
}
