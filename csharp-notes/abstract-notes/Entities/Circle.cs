using abstract_notes.Entities.Enum;

namespace abstract_notes.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() { }
        public Circle(double radius, Colors color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }
    }
}
