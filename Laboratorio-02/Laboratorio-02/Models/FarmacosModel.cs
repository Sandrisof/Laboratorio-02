using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_02.Models
{
    public class FarmacosModel
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string CasaProductora { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
    }
}