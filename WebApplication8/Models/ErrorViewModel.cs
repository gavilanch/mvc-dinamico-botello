using System;
using System.Collections.Generic;

namespace WebApplication8.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Direccion> Direcciones { get; set; } = new List<Direccion>();

    }

    public class Direccion
    {
        public string Calle { get; set; }
        public int Numero { get; set; }
    }
}
