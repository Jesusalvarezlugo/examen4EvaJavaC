using examen4EvaJava.Dtos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen4EvaJava.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        

        private void registroCliente(List<ClienteDto> listaAntgCliente)
        {
            string dniCliente;
            string nombreCliente;
            string apellidosCliente;
            long idCliente=autoIdC(listaAntgCliente);

            Console.WriteLine("Introduzca su DNI: ");
            dniCliente=Console.ReadLine();
            Console.WriteLine("Introduzca el nombre del cliente: ");
            nombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos del cliente: ");
            apellidosCliente=Console.ReadLine();

            ClienteDto cliente = new ClienteDto(idCliente,dniCliente,nombreCliente,apellidosCliente);
            cliente.FchaAltaCli=DateTime.Now;

            listaAntgCliente.Add(cliente);
        }

        private long autoIdC(List<ClienteDto> listaAntgCliente)
        {
            int tamanioLista = listaAntgCliente.Count;
            long nuevoId;


            if (tamanioLista > 0)
            {
                nuevoId = listaAntgCliente[tamanioLista - 1].IdCliente + 1;
            }
            else
            {
                nuevoId = 1;
            }

            return nuevoId;
        }



        public void menuCliente(List<ClienteDto> listaAntgCliente)
        {
            int opcion;
            bool cerrarMenu = false;
            MenuInterfaz mi = new MenuImplementacion();

            while (!cerrarMenu)
            {
                opcion = mi.mostrarMenuYSeleccionCli();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("[INFO] Se volvera al menu principal.");
                        cerrarMenu=true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] Se registrara un cliente nuevo.");
                        registroCliente(listaAntgCliente);
                        break;
                }
            }


        }

        public void menuEmpleado(List<ClienteDto> listaAntgCliente)
        {
            int opcion;
            bool cerrarMenu = false;
            MenuInterfaz mi = new MenuImplementacion();

            while (!cerrarMenu)
            {
                opcion = mi.mostrarMenuYSeleccionEmp();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("[INFO] Se volvera al menu principal.");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] se validara un cliente.");
                        validarCliente(listaAntgCliente);
                        break;
                }
            }
        }

        private void validarCliente(List<ClienteDto> listaAntgCliente)
        {
            string dniAPedir;
            foreach(ClienteDto cliente in listaAntgCliente)
            {
                if (cliente.EsValido == false)
                {
                    Console.WriteLine(cliente.DniCliente + "-" + cliente.NombreCompleto);
                }
                
            }

            Console.WriteLine("Introduzca el Dni para validar el cliente: ");
            dniAPedir = Console.ReadLine();

            foreach(ClienteDto cliente in listaAntgCliente)
            {
                if(cliente.EsValido == false && cliente.DniCliente == dniAPedir)
                {
                    cliente.EsValido = true;
                    break;
                }
            }
        }

        private void solicitudCita(List<CitaDto> listaAntgCita, List<ClienteDto> listaAntgCliente)
        {
            MenuInterfaz mi = new MenuImplementacion();
            string dniAPedir;
            int opcionEsp;
            CitaDto cita = new CitaDto();
            DateOnly fechaCita;
            TimeOnly horaCita;
            string citaHoraS;
            string citaFechaS;

            Console.WriteLine("Introduzca el dni del cliente para la cita: ");
            dniAPedir= Console.ReadLine();

            foreach(ClienteDto cliente in listaAntgCliente)
            {
                if (cliente.DniCliente == dniAPedir && cliente.EsValido == true)
                {
                    cita.DniClienteC = dniAPedir;
                    opcionEsp = mi.mostrarMenuYSeleccionEsp();

                    switch (opcionEsp)
                    {
                        case 1:
                            Console.WriteLine("Ha escogido la especialidad de psicologia");
                            cita.EspecialidadCita = "Psicologia";
                            break;

                        case 2:
                            Console.WriteLine("Ha escogido la especialidad de traumatologia");
                            cita.EspecialidadCita = "Traumatologia";
                            break;

                        case 3:
                            Console.WriteLine("Ha escogido la especialidad de fisioterapia");
                            cita.EspecialidadCita = "Fisioterapia";
                            break;
                    }
                }
            }

            Console.WriteLine("Introduce la fecha para la cita: ");
            citaFechaS = Console.ReadLine();
            fechaCita = DateOnly.Parse(citaFechaS);

            Console.WriteLine("Introduce la hora para la cita: ");
            citaHoraS=Console.ReadLine();
            horaCita=TimeOnly.Parse(citaHoraS);

            cita.FechaCita = Convert.ToDateTime(fechaCita + " " + horaCita);


        }


    }

    
}
