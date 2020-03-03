using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriadeClases
{
    public class Medicamentosinfo
    {
        public int id { get; set; }
        public string nombremed { get; set; }
        public int cantidadex { get; set;  }
        public string descripcion { get; set; }
        public double preciomed { get; set; }
        public string casaFarmaceutica { get; set; }

        public bool enExistencia()
        {
            if (cantidadex != 0)
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }
         
        //creando constructores para los medicamentos
        public Medicamentosinfo() { }
        public Medicamentosinfo(int id, string nombremed, int cantidadex, string descripcion, double preciomed,string casaFarmaceutica)
        {
            this.id = id;
            this.nombremed = nombremed;
            this.cantidadex = cantidadex;
            this.descripcion = descripcion;
            this.preciomed = preciomed;
            this.casaFarmaceutica = casaFarmaceutica; 
        }
    }
}
