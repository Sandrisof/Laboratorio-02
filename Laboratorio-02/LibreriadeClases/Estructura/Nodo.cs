using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriadeClases.Estructura
{
    public class Nodo
    {
        public Medicamentosinfo medsinfo { get; set; }
        public int creaindice { get; set; }
        public Nodo padre { get; set; }
        public Nodo izquierdo { get; set; }
        public Nodo derecho { get; set; }
       // public T Valor { get; set; }
        //constructores
        public Nodo()
        {

        }
        public Nodo(Medicamentosinfo medicamentosinfo)
        {
            this.medsinfo = medicamentosinfo; 
        }
        public Nodo(Medicamentosinfo Medicinfo, Nodo Izquierdo, Nodo Derecho, Nodo Padre)
        {
            this.medsinfo = Medicinfo;
            this.izquierdo = Izquierdo;
            this.derecho = Derecho;
            this.padre = Padre; 
        }
           //Identificar cual es la raiz, las hojas y si existen subarboles en el 
           public bool tieneRaiz()
           {
                if (padre != null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
           }
        public bool buscarhoja()
        {
            if ((derecho == null) && (derecho == null))
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
        
        public bool buscarderecho()
        {
            if (derecho !=null)
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }

        public bool buscarizquierdo()
        {
            if (izquierdo != null)
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }
        public bool medexistente()
        {
            if (medsinfo !=null)
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }
        
    }
}
