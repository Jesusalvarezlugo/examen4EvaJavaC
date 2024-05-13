using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen4EvaJava.Dtos
{
    internal class CitaDto
    {

        //Atributos

        long idCita;
        string dniClienteC = "aaaaa";
        string especialidadCita = "aaaaa";
        DateTime fechaCita;

        //Getters y Setters
        public long IdCita { get => idCita; set => idCita = value; }
        public string DniClienteC { get => dniClienteC; set => dniClienteC = value; }
        public string EspecialidadCita { get => especialidadCita; set => especialidadCita = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }


        override
            public string ToString()
        {
            string texto=this.dniClienteC+"\t"+this.especialidadCita+"\t"+this.fechaCita;

            return texto;
        }
    }
}
