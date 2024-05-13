using examen4EvaJava.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen4EvaJava.Servicios
{
    internal interface OperativaInterfaz
    {
        

        public void menuCliente(List<ClienteDto> listaAntgCliente,List<CitaDto> listaAntgCita);

        public void menuEmpleado(List<ClienteDto> listaAntgCliente, List<CitaDto> listaAntgCita);
    }
}
