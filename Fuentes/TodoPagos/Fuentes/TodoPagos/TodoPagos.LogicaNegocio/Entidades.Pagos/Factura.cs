﻿using System;
using static TodoPagos.LogicaNegocio.Enumerados.Enumerados;

namespace TodoPagos.LogicaNegocio.Entidades.Pagos
{
    public class Factura
    {

        public int FacturaId { get; set; }

        public string NumeroFactura { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public DateTime FechaEmision { get; set; }

        public bool EstaPaga { get; set; }

        public TipoPago TipoPago { get; set; }

        public long Monto { get; set; }

        public Boolean EstaBorrado { get; set; }
    }
}
