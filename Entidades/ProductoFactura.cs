﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoFactura
    {
        public int ProductoId { get; set; }

        public Producto Producto { get; set; }

        public int FacturaId { get; set; }

        public Factura Factura { get; set; }

        public int Cantidad { get; set; }

        public int Precio { get; set; }

        public ProductoFactura()
        {

        }
        public ProductoFactura(int productoId, int facturaId, int cantidad, int precio)
        {
            this.ProductoId = productoId;
            this.FacturaId = facturaId;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }
    }
}
