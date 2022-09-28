using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15_Ex2
{
   public class Circulo : Figura
    {
       double raio;
       public Circulo(double raio)
       {
           this.raio = raio;
       }
       public double calculaArea()
       {
           double area = 0;
           area = 3.14 * raio * raio;
           return area;
       }
    }
}
