using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriadeClases.Interfaz;
using LibreriadeClases.Estructura;
using System.Collections;

namespace LibreriadeClases.Estructura
{
    class ABB<T> : EstructuradeDatosNoLineal1<T>/*, IEnumerable<T>*/
    {
        private Nodo<T> Raiz { get; set; }
        public void AgregarRaiz(T valor)
        {
            InsertarRaiz(valor);
        }
        public void Agregar(Nodo<T> raiz, Nodo<T> nuevo)
        {
            Insertar(raiz, nuevo);
        }

        protected override void InsertarRaiz(T valor)
        {
            Nodo<T> Nuevo = new Nodo<T>();
            Nuevo.Valor = valor;
            {
                if (Raiz == null)
                {
                    Raiz = Nuevo;
                }
                else
                {
                    Insertar(Raiz, Nuevo);                    
                }
            };
        }

        protected override void Insertar(Nodo<T> raiz, Nodo<T> nuevo) 
        {
            if (raiz == null)
            {
                raiz = nuevo;
            }
            
        }
    }
}
