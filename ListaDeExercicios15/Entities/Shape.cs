using ListaDeExercicios15.Entities.Enums;

namespace ListaDeExercicios15.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public Shape (Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
