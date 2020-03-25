using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Laboratorio_02.ABB;
namespace Laboratorio_02
{
    public class Infopedido
    {
        public string NombreCliente { get; set; }
        public string NitCliente { get; set; }
        public string DireccionCliente { get; set; }
        public List<Farmacos> pedido = new List<Farmacos>();

        public double Preciopedido()
        {
            double cantidad = 0; 
            foreach(var articulo in pedido)
            {
                cantidad = articulo.precio; 

            }
            return cantidad; 
        }
    }
}