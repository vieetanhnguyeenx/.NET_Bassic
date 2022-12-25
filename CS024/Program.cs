using System;

namespace CS024
{

    class Student
    {
        public readonly string? name;

        public Student(string name)
        {
            this.name = name;
        }
    }
    class CountNumber
    {
        public static int number = 0;
        public static void Info()
        {
            Console.WriteLine($"So lan truy cap {number}");
        }
        public void Count()
        {
            CountNumber.number++;
        }
    }

    class Vector
    {
        public double x;
        public double y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Info()
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }

        // vector + vector => vector
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(x: a.x + b.x, y: a.y + b.y);
        }

        public static Vector operator +(Vector a, double b)
        {
            return new Vector(x: a.x + b, y: a.y + b);
        }

        public double this[int i]
        {
            set
            {
                switch (i)
                {
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                    default:
                        throw new Exception("Chi so sai");
                }
            }

            get
            {
                switch (i)
                {
                    case 0:
                        return x;
                    case 1:
                        return y;
                    default:
                        throw new Exception("Chi so sai");
                }
            }
        }

        public double this[string s]
        {
            set
            {
                if (s.ToLower().Equals("chisox"))
                {
                    this.x = value;
                }
                else if (s.ToLower().Equals("chisoy"))
                {
                    this.y = value;
                }
                else
                {
                    throw new Exception("Chi so sai");
                }
            }
            get
            {
                if (s.ToLower().Equals("chisox"))
                {
                    return this.x;
                }
                else if (s.ToLower().Equals("chisoy"))
                {
                    return this.y;
                }
                else
                {
                    throw new Exception("Chi so sai");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // CountNumber c1 = new CountNumber();
            // CountNumber c2 = new CountNumber();
            // c1.Count();
            // c2.Count();
            // CountNumber.Info();

            // Student s = new Student("Nguyen Van A");
            // Console.WriteLine(s.name);

            // Vector v1 = new Vector(2, 3);
            // v1.Info();
            // Vector v2 = new Vector(1, 1);
            // // (x1, x2) + (x2, y2) : (x1 + x2, y1 + y2)
            // Vector v3 = v1 + v2;
            // v3.Info();
            // Vector v4 = v1 + 10;
            // v4.Info();

            Vector v = new Vector(2, 3);

            // xay dung bo truy cap 
            // v[0] ~ x
            // v[1] ~ y
            v[0] = 5;
            v[1] = 6;
            v.Info();

            v["chisox"] = 10;
            v["chisoy"] = 20;
            v.Info();

            // v["toadox"] ~ x
            // v["toadoy"] ~ x
        }
    }
}
