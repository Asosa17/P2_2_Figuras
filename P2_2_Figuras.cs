//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0

using System.Drawing;

//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {

             List<Figura> listaFiguras = new List<Figura>();

           
            Color color1 = new Color(255,89,0,55);
            Color color2 = new Color(36,0, 0, 255);
            Color color3 = new Color(0, 255, 28,0);
            
            Figura rectangulo = new Rectangulo(color1, 5, 10);
            Figura circulo = new Circulo(color2, 7);
            Figura triangulo = new TrianguloEquilatero(color3, 8);

            listaFiguras.Add(rectangulo);
            listaFiguras.Add(circulo);
            listaFiguras.Add(triangulo);

            
            Color colorNuevo = new Color(245, 40, 145, 200);
            Console.WriteLine("Figuras y sus áreas:");
            double suma=0;
            foreach (var figura in listaFiguras)
            {
                suma+=figura.GetArea();
                Console.WriteLine("_________________________");
                Console.WriteLine(figura.ToString());
                Console.WriteLine("- Color: "+figura.getColor());
                Console.WriteLine($"- Área: {figura.GetArea():F2}");
                figura.setColor(colorNuevo);
                Console.WriteLine("- Nuevo color: "+figura.getColor());
                
            }
            Console.WriteLine($"- Suma de las áreaa: {suma:F2}");



           
            
    }
}
