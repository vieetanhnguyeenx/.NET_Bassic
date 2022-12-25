using System;

namespace MyException
{
    public class NameEmptyException : Exception
    {
        public NameEmptyException() : base("Ten phai khac rong")
        {

        }
    }

    public class AgeException : Exception
    {
        public int age {set; get;}
        public AgeException(int age) : base("Tuoi khong phu hop")
        {
            this.age = age;
        }

        public void Detail()
        {
            Console.WriteLine($"Tuoi = {age}, khong nam trong khoang tu 18 den 100");
        }
    }
}