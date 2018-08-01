using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EProducto
    {
        public Guid ID { get; set; }
        public ETipoProducto TipoProducto { get; set; }
        public EProveedor Proveedor { get; set; }
        public ETarifa Tarifa { get; set; }
    }

    public class ETipoProducto
    {
        public Guid ID { get; set; }
        public bool Activo { get; set; }
        public string Nombre { get; set; }
    }
}
