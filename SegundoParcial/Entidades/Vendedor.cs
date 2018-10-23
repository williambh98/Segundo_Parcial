using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades
{
   public class Vendedor
    {
        [Key]
        public int VendedorID { get; set; }
        public decimal Restencion { get; set; }
        public decimal Total { get; set; }
        public decimal Sueldo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaVendedor { get; set; }
        public virtual List<VendedorDetalle> Metas { get; set; }


        public Vendedor()
        {
            VendedorID = 0;
            Restencion = 0;
            Sueldo = 0;
            Total = 0;
            Nombre = string.Empty;
            FechaVendedor = DateTime.Now.Date;
            Metas = new List<VendedorDetalle>();
        }

    }
}
