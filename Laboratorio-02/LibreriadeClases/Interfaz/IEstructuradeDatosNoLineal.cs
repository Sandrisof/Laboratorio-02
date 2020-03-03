using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriadeClases.Estructura;

namespace LibreriadeClases.Interfaz
{
    interface IEstructuradeDatosNoLineal<T>
    {
        void InsertarRaiz(T valor);
        void Insertar(Nodo raiz, Nodo nuevo);
        void Eliminar();
        T Get();

    }
}
