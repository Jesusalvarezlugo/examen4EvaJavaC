using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace examen4EvaJava.Dtos
{
    internal class ClienteDto
    {
        //Atributos

        long idCliente;
        string dniCliente = "aaaaa";
        string nombreCompleto = "aaaaa";
        DateTime fchaAltaCli;
        bool esValido=false;


        //Getters y Setters

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public DateTime FchaAltaCli { get => fchaAltaCli; set => fchaAltaCli = value; }
        public bool EsValido { get => esValido; set => esValido = value; }

        //Constructores

        public ClienteDto(long idCliente, string dniCliente, string nombreCliente, string apellidosCliente)
        {
            this.IdCliente = idCliente;
            this.DniCliente = dniCliente;
            this.NombreCompleto = apellidosCliente + ", " + nombreCliente;
        }


        override
            public string ToString()
        {
            string texto = this.dniCliente + "-" + this.nombreCompleto;

            return texto;
        }
        
    }
}
