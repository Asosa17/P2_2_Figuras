using System.Drawing;
namespace P2_2_Figuras;

    internal class TrianguloEquilatero : Figura
    {
        private double _lado;

    public TrianguloEquilatero(Color color, double ladoTriangulo)
    {
        _color = color;
        _lado = ladoTriangulo;
    }

    public override double GetArea()
    {
        return (_lado * _lado * Math.Sqrt(3)) / 4;
    }

    public override string ToString()
    {
        return base.ToString() + $"\n- Lado: {_lado}";
    }
    }
