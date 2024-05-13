using examen4EvaJava.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen4EvaJava.Servicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void imprimirCitas(List<CitaDto> listaAntgCitas,List<ClienteDto> listaAntgClientes)
        {
            string fechaAConsultar;
            
            Console.WriteLine("Introduzca la fecha para consultar la cita (dd-MM-yyyy)");
            fechaAConsultar=Console.ReadLine();
            DateTime fechaConvertida=Convert.ToDateTime(fechaAConsultar);
            string[] partirFecha = fechaAConsultar.Split("-");
            string dia=partirFecha[0];
            string mes=partirFecha[1];
            string anio=partirFecha[2];
            string rutaFichero = "informe" + dia + mes + anio + ".txt";
            StreamWriter sw = new StreamWriter(rutaFichero);

            foreach(CitaDto cita in listaAntgCitas)
            {
                if (fechaConvertida == cita.FechaCita.Date)
                {
                    foreach(ClienteDto cliente in listaAntgClientes)
                    {
                        if (cita.DniClienteC == cliente.DniCliente)
                        {
                            sw.WriteLine(cliente.DniCliente+";"+cliente.NombreCompleto+";"+cita.EspecialidadCita);
                        }
                        else
                        {
                            Console.WriteLine("No hay informacion que mostrar.");
                            break;
                        }
                        
                                              
                    }

                    
                }
            }

            sw.Close();
            
        }
    }
}
