using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Entidades
{
    public class E_Cliente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? TipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public bool Socio { get; set; }
        public string? Carnet { get; set; }
        public DateTime? CuotaVencimiento { get; set; }
        public string? FichaMedica { get; set; }
    }
}
