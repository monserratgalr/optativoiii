﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialI.Models
{
    public class Factura
    { 
            public int idFactura { get; set; }
            public int idCliente { get; set; }
            public string nroFactura { get; set; }
            public DateTime fechaHora { get; set; }
            public float total { get; set; }
            public float iva5 { get; set; }
            public float iva10 { get; set; }
            public float ivaTotal { get; set; }
            public string sucursal { get; set; }

            public Factura(string nroFactura, DateTime fechaHora, float total, float iva5, float iva10, float ivaTotal, string sucursal)
            {
                this.nroFactura = nroFactura;
                this.fechaHora = fechaHora;
                this.total = total;
                this.iva5 = iva5;
                this.iva10 = iva10;
                this.ivaTotal = ivaTotal;
                this.sucursal = sucursal;
            }
        }
    }


