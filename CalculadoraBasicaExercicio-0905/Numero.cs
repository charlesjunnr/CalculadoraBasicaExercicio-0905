using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBasicaExercicio_0905
{
    
    public class Numero
    {
        public decimal numero01;
        public decimal numero02;

        
        public Numero(decimal numero, decimal numero2)
        {
            this.numero01 = numero;
            this.numero02 = numero;
        }
        public static decimal Somar(decimal x, decimal y)
        {
            return x + y;
        }

        public static decimal Subtrair(decimal x, decimal y)
        {
            return x - y;
        }

        public static decimal Multiplicar(decimal x, decimal y)
        {
            return x * y;
        }

        public static decimal Dividir(decimal x, decimal y)
        {
            return x / y;
        }

    }
}
