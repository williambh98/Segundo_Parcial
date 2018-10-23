using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades
{
    public class Metas
    {
        [Key]
        public int Metaid { get; set; }
        public string Descripcion { get; set; }
        public decimal Cuota { get; set; }


        public Metas()
        {
            Metaid = 0;
            Descripcion = string.Empty;
            Cuota = 0;
        }
    }
}
