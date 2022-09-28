using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula16
{
    public static class Calculadora
    {
        private static double pi = 3.14;
        public static int adicao(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public static int subtracao(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        public static int multiplicacao(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
        public static int divisao(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
        public static double areaCirculo(int raio)
        {
            double area = 0;
            area = Calculadora.pi * raio * raio;
            return area;
        }
    }
}
