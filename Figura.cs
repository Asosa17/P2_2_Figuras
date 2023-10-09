using System.Drawing;
using System.Dynamic;


namespace P2_2_Figuras;

internal abstract class Figura
{
  protected Color _color;

  public abstract double GetArea();

  public override string ToString()
        {
            return $"FIGURA {GetType().Name.ToUpper()}\n" + $"- Color: Color [A={_color.A}, R={_color.R}, G={_color.G}, B={_color.B}]";
                  
        }
}