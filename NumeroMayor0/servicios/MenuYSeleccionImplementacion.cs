using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMayor0.servicios
{
    internal class MenuYSeleccionImplementacion : MenuYSeleccionInterfaz
    {
        public int MenuSeleccionar()
        {
            Console.WriteLine("Escribe un numero mayor que 0: ");
            int numeroseleccionado = Convert.ToInt32(Console.ReadLine());
            return numeroseleccionado;
        }

    }
}
