using NumeroMayor0.servicios;

namespace NumeroMayor0.controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            MenuYSeleccionInterfaz mys = new MenuYSeleccionImplementacion();
            int seleccion = mys.MenuSeleccionar();
            OperacionInterfaz oi = new OperacionImplementacion();
            oi.operacion(seleccion);
 

        }
    }
}
