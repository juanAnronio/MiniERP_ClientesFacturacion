using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using System.Linq;

using System.ComponentModel.DataAnnotations.Schema;

namespace MiniERP_ClientesFacturacion
{
    internal class FacturaDetalle
    {
        public int Id { get; set; }

        public int FacturaId { get; set; }
        public Factura Factura { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        public decimal Subtotal => Cantidad * Producto.Precio;
    }
}
