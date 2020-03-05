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
    public class ABB<T> : ICollection<T>, IEnumerable<T>
    {
        private Nodo Raiz { get; set; }
        public bool estaVacio { get { return Raiz == null;  } }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();
        private void Add(Medicamentosinfo articulo)
        {
            if (articulo.enExistencia())
            {
                this.Add(articulo, Raiz);
            }
            else
            {
                Raiz = new Nodo(articulo);
            }
        }
        public void Add(Medicamentosinfo articulo, Nodo raiz)
        {
            if (Raiz != null)
            {
                if (string.Compare(articulo.nombremed, raiz.medsinfo.nombremed) == 1)
                {
                    this.Add(articulo, raiz.izquierdo); 
                }
                else
                {
                    raiz.izquierdo = new Nodo(articulo); 
                }
                    
            }
            else
            {
                if (raiz.derecho != null)
                {
                    this.Add(articulo, raiz.derecho); 
                }
                else
                {
                    raiz.derecho = new Nodo(articulo); 
                }
            }
        }
        public void verificarbol(List<Medicamentosinfo> listameds)
        {
            foreach (var articulo in listameds)
            {
                this.Add(articulo); 
            }
        }
        public int Busqueda(string medicina)
        {
            if (Raiz !=null)
            {
                if (Raiz.medsinfo.nombremed == medicina)
                {
                    return Raiz.creaindice; 
                }
                else
                {
                    return Busqueda(medicina, Raiz);
                }
            }
            else
            {
                return -1;
            }
        }

        private int Busqueda(string medicina, Nodo raiz)
        {
            if (raiz.buscarhoja())
            {
                return -1;
            }
            else if (string.Compare(medicina, raiz.medsinfo.nombremed)==1)
            {
                if (!raiz.buscarderecho())
                {
                    return raiz.creaindice;
                      
                }
                else
                {
                    return Busqueda(medicina, raiz.buscarderecho);
                }
            }
            else
            {
                if (raiz.buscarizquierdo())
                {
                    return raiz.creaindice;
                }
                else
                {
                    return Busqueda(medicina, raiz.izquierdo); 
                }
            }
            throw new NotImplementedException();
        }

        private int Busqueda(string medicina, Func<bool> buscarderecho)
        {
            throw new NotImplementedException();
        }

        private void Preorden(Nodo obtienenodo)
        {
            if (obtienenodo != null)
            {
                Console.Write(obtienenodo.medsinfo + " ");
                Preorden(obtienenodo.izquierdo);
                Preorden(obtienenodo.derecho); 
            }
        }
        public void Preorden()
        {
            Preorden(Raiz);
            Console.WriteLine();
        }
        private void Inorden(Nodo obtienenodo)
        {
            if (obtienenodo != null)
            {
                Inorden(obtienenodo.izquierdo);
                Console.WriteLine(obtienenodo.medsinfo + " ");
                Inorden(obtienenodo.derecho); 
            }
        }
        public void Inorden()
        {
            Inorden(Raiz);
            Console.WriteLine(); 
        }
        private void Postorden(Nodo obtienenodo)
        {
            if (obtienenodo != null)
            {
                Postorden(obtienenodo.izquierdo);
                Postorden(obtienenodo.derecho);
                Console.WriteLine(obtienenodo.medsinfo + " "); 
            }
        }

    public void Postorden()
        {
            Postorden(Raiz);
            Console.WriteLine(); 
        }


        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }
    }
}
