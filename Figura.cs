using System.Drawing;
using System.Dynamic;


namespace P2_2_Figuras;

internal abstract class Figura
{
  protected Color _color;

  public abstract double GetArea();
  public void setColor(Color c)=>_color = c;
  public string getColor()=>_color.ToString();
  public override string ToString()
        {
            return $"FIGURA {GetType().Name.ToUpper()}";
                  
        }
}