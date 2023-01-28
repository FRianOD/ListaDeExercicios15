using ListaDeExercicios15.Entities.Enums;

namespace ListaDeExercicios15.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.14 * Radius * Radius;
        }
    }
}
