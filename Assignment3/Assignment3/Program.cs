namespace Assignment3
{
    class Shape
    {
        protected int[] sidelength;
        public Shape(int[] sidelength)
        {
            this.sidelength = sidelength;
        }
        public virtual double getArea()
        {
            return 0;
        }
        public virtual bool IsLegal()
        {
            return true;
        }
        public virtual int getlength()
        {
            int length = 0;
            for (int i = 0; i < sidelength.Length; i++)
            {
                length += sidelength[i];
            }
            return length;
        }
    }
    class Triangle : Shape
    {
        public Triangle(int[] sidelength ): base(sidelength)
        {
        }
        public override double getArea()
        {
            double p = (sidelength[0] + sidelength[1] + sidelength[2]) / 2.0;
            return System.Math.Sqrt(p * (p - sidelength[0]) * (p - sidelength[1]) * (p - sidelength[2]));
        }
        public override bool IsLegal()
        {
            return sidelength[0] + sidelength[1] > sidelength[2] && sidelength[0] + sidelength[2] > sidelength[1] && sidelength[1] + sidelength[2] > sidelength[0];
        }

    }
    class Square : Shape
    {
        public Square(int[] sidelength) : base(sidelength) { }
        public override double getArea()
        {
            return sidelength[0] * sidelength[1];
        }
        public override bool IsLegal()
        {
            return (sidelength[0] == sidelength[1]) && (sidelength[1]== sidelength[2]) && (sidelength[2]== sidelength[3]);
        }
    }
    class Rectangle : Shape
    {
        public Rectangle(int[] sidelength) : base (sidelength) { }
        public override double getArea()
        {
            return sidelength[0] * sidelength[1];
        }
        public override bool IsLegal()
        {
            return sidelength[0] == sidelength[2] && sidelength[1] == sidelength[3];
        }
    }
    class circle : Shape
    {
        public circle(int[] sidelength) : base(sidelength) { }
        public override double getArea()
        {
            return System.Math.PI * sidelength[0] * sidelength[0];
        }
        public override bool IsLegal()
        {
            return sidelength[0] > 0;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<10;i++)
            {
                string typestr;
                string[] lengthstr;
                int type;
                try
                {
                    typestr = Console.ReadLine();
                    type = int.Parse(typestr);
                    lengthstr = Console.ReadLine().Split(' ');
                }
                catch
                {
                    Console.WriteLine("Illegal");
                    continue;
                }
                int[] length = new int[lengthstr.Length];
                for (int j = 0; j < lengthstr.Length; j++)
                {
                    length[j] = int.Parse(lengthstr[j]);
                }
                switch (type)
                {
                    case 1:
                        Triangle triangle = new Triangle(length);
                        if (triangle.IsLegal())
                        {
                            Console.WriteLine(triangle.getArea());
                        }
                        else
                        {
                            Console.WriteLine("Illegal");
                        }
                        break;
                    case 2:
                        Square square = new Square(length);
                        if (square.IsLegal())
                        {
                            Console.WriteLine(square.getArea());
                        }
                        else
                        {
                            Console.WriteLine("Illegal");
                        }
                        break;
                    case 3:
                        rectangle rectangle = new rectangle(length);
                        if (rectangle.IsLegal())
                        {
                            Console.WriteLine(rectangle.getArea());
                        }
                        else
                        {
                            Console.WriteLine("Illegal");
                        }
                        break;
                    case 4:
                        circle circle = new circle(length);
                        if (circle.IsLegal())
                        {
                            Console.WriteLine(circle.getArea());
                        }
                        else
                        {
                            Console.WriteLine("Illegal");
                        }
                        break;
                }
            }


        }
    }
}