using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EPresupuesto
    {
        public Guid ID { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public List<ELineaDocumento> Lineas { get; set; }
        public EDescuento DescuentoGlobal { get; set; }
    }
}
