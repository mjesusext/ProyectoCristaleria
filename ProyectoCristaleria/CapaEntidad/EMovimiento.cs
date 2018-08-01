﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EMovimiento
    {
        public Guid ID { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Nombre { get; set; }
        public ETipoMovimiento TipoMovimiento { get; set; }
        public decimal Valor { get; set; }
    }

    public class ETipoMovimiento
    {
        public Guid ID { get; set; }
        public bool Activo { get; set; }
        public string Nombre { get; set; }
    }
}
