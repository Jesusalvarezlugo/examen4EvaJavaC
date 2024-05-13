using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen4EvaJava.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
       

        public int mostrarMenuYSeleccionPrin()
        {
            int opcion;

            Console.WriteLine("##############################");
            Console.WriteLine("0. Salir de la aplicacion.");
            Console.WriteLine("1. Menu empleados");
            Console.WriteLine("2. Menu clientes");
            Console.WriteLine("3. PRUEBAS");
            Console.WriteLine("##############################");
            Console.WriteLine("Elija una opcion: ");
            opcion=Console.ReadKey().KeyChar -('0');

            return opcion;
        }

        public int mostrarMenuYSeleccionEmp()
        {
            int opcion;

            Console.WriteLine("##############################");
            Console.WriteLine("0. Volver al menu principal.");
            Console.WriteLine("1. Validar nuevo cliente");
            Console.WriteLine("2. Imprimir citas medicas");
            Console.WriteLine("##############################");
            Console.WriteLine("Elija una opcion: ");
            opcion = Console.ReadKey().KeyChar - ('0');

            return opcion;
        }

        public int mostrarMenuYSeleccionCli()
        {
            int opcion;
            Console.WriteLine("##############################");
            Console.WriteLine("0. Volver al menu principal.");
            Console.WriteLine("1. Registro de cliente.");
            Console.WriteLine("2. Solicitud de cita medica");
            Console.WriteLine("3. Consultar citas medicas");
            Console.WriteLine("##############################");
            Console.WriteLine("Elija una opcion: ");
            opcion = Console.ReadKey().KeyChar - ('0');

            return opcion;
        }

        public int mostrarMenuYSeleccionEsp()
        {
            int opcion;
            Console.WriteLine("##############################");
            Console.WriteLine("1. Psicologia.");
            Console.WriteLine("2. Traumatologia.");
            Console.WriteLine("3. Fisioterapia.");
            Console.WriteLine("##############################");
            Console.WriteLine("Elija una opcion: ");
            opcion = Console.ReadKey().KeyChar - ('0');

            return opcion;
        }
    }
}
