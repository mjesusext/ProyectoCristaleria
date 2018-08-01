using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EProveedor
    {
        public Guid ID { get; set; }
        public bool Activo { get; set; }
        public string Nombre { get; set; }
        public string EmailPedidos { get; set; }
    }
}
