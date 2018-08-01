using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ELineaDocumento
    {
        public Guid ID { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public EProducto Producto { get; set; }
        public EDescuento DescuentoConcreto { get; set; }
    }
}
