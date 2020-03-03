using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriadeClases.Estructura;

namespace LibreriadeClases.Interfaz
{
    public abstract class EstructuradeDatosNoLineal1<T>
    {
        protected abstract void InsertarRaiz(T valor);
        //protected abstract void Insertar(Nodo<T> raiz, Nodo<T> nuevo);
        //protected abstract void Eliminar();
        //protected abstract T Get();
    }
}
