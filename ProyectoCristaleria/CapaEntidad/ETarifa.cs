using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ETarifa
    {
        public Guid ID { get; set; }
        public string Nombre { get; set; }
        public List<EConceptoTarifa> Conceptos { get; set; }
    }

    public class EConceptoTarifa
    {
        public Guid Id { get; set; }
        public bool Activo { get; set; }
        public string Nombre { get; set; }
        public decimal Valor { get; set; }
        public ETipoCalculo TipoCalculo { get; set; }
    }
}
