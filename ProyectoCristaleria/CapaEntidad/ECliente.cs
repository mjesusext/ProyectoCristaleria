using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ECliente
    {
        public Guid ID { get; set; }
        public List<ERelacion> Relaciones { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public List<EDireccion> Direcciones { get; set; }
        public List<EDatosContacto> DatosContacto { get; set; }
    }

    public class ERelacion
    {
        public Guid ID { get; set; }
        public Guid IDClienteIzq { get; set; }
        public Guid IDClienteDer { get; set; }
        public ETipoRelacion Relacion { get; set; }
    }

    public class ETipoRelacion
    {
        public Guid ID { get; set; }
        public string NombreDirecto { get; set; }
        public string NombreReciproco { get; set; }
    }

    public class EDireccion
    {
        public Guid ID { get; set; }
        public string NombreDireccion { get; set; }
        public bool DireccionFiscal { get; set; }
        public bool DireccionComercial { get; set; }
        public bool DireccionDefault { get; set; }
        public string TipoVia { get; set; }
        public string NombreVia { get; set; }
        public string Portal { get; set; }
        public string Piso { get; set; }
        public string Puerta { get; set; }
        public string CP { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
    }

    public class EDatosContacto
    {
        public Guid ID { get; set; }
        public bool ContactoDefault { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
    }

    public class ETipoIdFiscal
    {
        public Guid ID { get; set;}
        public string Nombre { get; set; }
    }
}
