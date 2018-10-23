using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades
{
    public class VendedorDetalle
    {
            [Key]
            public int Venid { get; set; }
            public int VendorID { get; set; }
            public int MetasID { get; set; }
            public Decimal Cuota { get; set; }
           

            public VendedorDetalle()
            {
               Venid = 0;
               VendorID= 0;
               MetasID = 0;
               Cuota = 0;
                
            }

            public VendedorDetalle(int Venid ,int VendorID, int Metas, Decimal Cuota)
            {
                 this.Venid = Venid;
                this.VendorID = VendorID;
                this.MetasID = Metas;
                this.Cuota = Cuota;

                

            }
        }
}
