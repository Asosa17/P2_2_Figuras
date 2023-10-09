namespace P2_2_Figuras;
{
internal class Rectangulo : Figura
    {
        private double _base;
        private double _altura;

        public Rectangulo(Color color, double baseRectangulo, double alturaRectangulo)
        {
            _color = color;
            _base = baseRectangulo;
            _altura = alturaRectangulo;
        }

        public override double GetArea()
        {
            return _base * _altura;
        }

        public override string ToString()
        {
            return $"Rectángulo - Base: {_base}, Altura: {_altura}, Color: {_color}";
        }
    }
}