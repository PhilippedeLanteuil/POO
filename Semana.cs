using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana
{
    namespace Enumeração
    {
        public enum Semana
        {
        Domingo = 1,
        Segunda = 2,
        Terça = 3,
        Quarta = 4,
        Quinta = 5,
        Sexta = 6,
        Sábado = 7
        }
    class Program
    {
         static void Main(){
            Semana semana1 = Semana.Domingo;
            int i1 = (int)Semana.Domingo;

            System.Console.WriteLine(semana1);
            System.Console.WriteLine(i1);
            Console.ReadKey();

            Semana semana5 = Semana.Quinta;
            int i5 = (int)Semana.Quinta;

            System.Console.WriteLine(semana5);
            System.Console.WriteLine(i5);
            Console.ReadKey();
        }
    }
        }
}

