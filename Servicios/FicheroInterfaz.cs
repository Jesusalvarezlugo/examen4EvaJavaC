using examen4EvaJava.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen4EvaJava.Servicios
{
    internal interface FicheroInterfaz
    {
        public void imprimirCitas(List<CitaDto> listaAntgCitas, List<ClienteDto> listaAntgClientes);
    }
}
