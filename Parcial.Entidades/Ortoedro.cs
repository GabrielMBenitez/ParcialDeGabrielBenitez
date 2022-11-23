using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    public class Ortoedro
    {
        public Ortoedro()
        {

        }
        public Ortoedro(int arista1, int arista2, int arista3, string colorines)
        {
            arista1 = AristaA;
            arista2 = AristaB;
            arista2 = AristaC;
            colorines = Colorines;
        }
        public int AristaA { get; set; }
        public int AristaB { get; set; }
        public int AristaC { get; set; }
        public string Colorines { get; set; }

        public double GetArea()
        {
           return  2 * (AristaA * AristaB + AristaB * AristaC + AristaC * AristaA);
        }
        public double GetVolumen()
        {
            return AristaA * AristaB * AristaC;
        }
      
    }
}
