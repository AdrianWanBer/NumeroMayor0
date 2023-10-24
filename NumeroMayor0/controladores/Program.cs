using NumeroMayor0.servicios;

namespace NumeroMayor0.controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            OperacionInterfaz oi = new OperacionImplementacion();
            oi.operacion();

        }
    }
}
