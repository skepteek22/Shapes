namespace Shapes
{
    abstract class Shape
    {
        public abstract double Area { get; }
        public abstract double Perimeter { get; }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area => Width * Height;
        public override double Perimeter => 2 * (Width + Height);

        public override string ToString()
        {
            return $"Rectangle: Width = {Width}, Height = {Height}, Area = {Area}, Perimeter = {Perimeter}";
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area => Math.PI * Radius * Radius;
        public override double Perimeter => 2 * Math.PI * Radius;

        public override string ToString()
        {
            return $"Circle: Radius = {Radius}, Area = {Area}, Circumference = {Perimeter}";
        }
    }

    class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public override double Area
        {
            get
            {
                double p = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            }
        }

        public override double Perimeter => SideA + SideB + SideC;

        public override string ToString()
        {
            return $"Triangle: SideA = {SideA}, SideB = {SideB}, SideC = {SideC}, Area = {Area}, Perimeter = {Perimeter}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Rectangle { Width = 5, Height = 3 };
            shapes[1] = new Circle { Radius = 2.5 };
            shapes[2] = new Triangle { SideA = 4, SideB = 5, SideC = 6 };

            PrintShapesInfo(shapes);
        }

        static void PrintShapesInfo(Shape[] shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }
    }
}