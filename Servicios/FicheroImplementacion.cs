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
        public void ficheroLog(string texto)
        {
            try
            {
                DateTime fechaActual = DateTime.Now;
                
                string fechaString=fechaActual.Date.ToString("ddMMyyyy");
                
                string rutaFichero = "log-" + fechaString+ ".txt";
                StreamWriter sw = File.AppendText(rutaFichero);

                sw.WriteLine(texto,true);

                sw.Close();

            }catch(IOException e)
            {
                Console.WriteLine("[ERROR] al escribir en el fichero.");
                Console.WriteLine(e.ToString());
            }
        }

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
            //Se puede hacer con un replace y quitar los guiones.
            StreamWriter sw = new StreamWriter(rutaFichero);
            bool aux = false;

            foreach(CitaDto cita in listaAntgCitas)
            {
                if (fechaConvertida == cita.FechaCita.Date)
                {
                    foreach(ClienteDto cliente in listaAntgClientes)
                    {
                        if (cita.DniClienteC == cliente.DniCliente)
                        {
                            sw.WriteLine(cliente.DniCliente+";"+cliente.NombreCompleto+";"+cita.EspecialidadCita);
                            aux = true;
                        }
                                                                                                                                                                   
                    }
                 
                }
            }

            if (aux = false)
            {
                Console.WriteLine("No hay informacion que mostrar.");
            }

            sw.Close();
            
        }
    }
}
