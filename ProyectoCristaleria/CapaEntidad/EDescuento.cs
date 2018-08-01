using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EDescuento
    {
        public Guid ID { get; set; }
        public string Nombre { get; set; }
        public decimal Valor { get; set; }
        public ETipoCalculo TipoCalculo { get; set; }
    }
}
