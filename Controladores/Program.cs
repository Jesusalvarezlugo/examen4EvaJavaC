using examen4EvaJava.Dtos;
using examen4EvaJava.Servicios;

namespace examen4EvaJava.Controladores
{
    class Program
    {
        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            int opcionP;
            bool cerrarMenu = false;
            List<ClienteDto> listaClientes = new List<ClienteDto>();

            while(!cerrarMenu)
            {
                opcionP=mi.mostrarMenuYSeleccionPrin();

                switch (opcionP)
                {
                    case 0:
                        Console.WriteLine("[INFO] se saldra de la aplicacion.");
                        cerrarMenu=true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] se accedera al menu de los empleados.");
                        oi.menuEmpleado(listaClientes);
                        break;

                    case 2:
                        Console.WriteLine("[INFO] se accedera al menu de los clientes.");
                        oi.menuCliente(listaClientes);
                        break;

                    case 3:
                        Console.WriteLine("[PRUEBAS]");
                        

                        foreach (ClienteDto cliente in listaClientes)
                        {
                            if (cliente.EsValido == true)
                            {
                                Console.WriteLine(cliente.ToString());
                            }
                            
                        }
                        break;
                        



                }
            }
        }

    }
}