using NumeroMayor0.controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMayor0.servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {

        public void operacion(int numero)
        {
            int ds = 0;
            int sumatorio;
            for (numero = numero; ds <= numero; ds++)
            {
                //sumatorio = numero + ds;
                //Console.WriteLine("La suma es: " + sumatorio);
                sumatorio = (numero*(numero + 1)) / 2;
                Console.WriteLine("La suma es: " + sumatorio);
            }
        }
    }
}
