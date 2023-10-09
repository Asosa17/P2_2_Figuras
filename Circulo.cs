using System.Drawing;
namespace P2_2_Figuras;

    internal class Circulo : Figura
    {
        private double _radio;

        public Circulo(Color color, double radioCirculo)
        {
            _color = color;
            _radio = radioCirculo;
        }

        public override double GetArea()
        {
            return Math.PI * _radio * _radio;
        }

        public override string ToString()
        {
           return base.ToString() + $"\n- Lado: {_radio}";
        }
    }