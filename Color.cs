using System.Drawing;

namespace P2_2_Figuras
{
    public struct Color
    {
        public int A { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public Color(int a,int r, int g, int b)
        {
            A = A;
            R = r;
            G = g;
            B = b;
        }
        public string ToString()
        {
            return $"[A={A}, R={R}, G={G}, B={B}]";
                  
        }
    }
}