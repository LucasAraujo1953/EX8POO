using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8POO
{
    internal class Comparador
    {
        private double valor1;
        private double valor2;

        public Comparador(double v1, double v2)
        {
            valor1 = v1;
            valor2 = v2;
        }

        public void CompararEExibirMaior()
        {
            if (valor1 > valor2)
            {
                Console.WriteLine("O primeiro valor é maior: " + valor1);
            }
            else if (valor2 > valor1)
            {
                Console.WriteLine("O segundo valor é maior: " + valor2);
            }
            else
            {
                Console.WriteLine("Os valores são iguais.");
            }
        }
    }
}
