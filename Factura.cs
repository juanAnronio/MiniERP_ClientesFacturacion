using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP_ClientesFacturacion
{
    internal class Factura
    {
        [Key]
        public int Id { get; set; }

        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public decimal Total { get; set; }

        public List<FacturaDetalle> Detalles { get; set; } = new List<FacturaDetalle>();

        [NotMapped]
        public decimal TotalCalculado => Detalles?.Sum(d => d.Subtotal) ?? 0;
    }
}
