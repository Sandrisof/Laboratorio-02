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
        int alturaAVL = 0;
        int nuevoValor =0;
        int Raiz2; 
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
                if (Alturarbol(Raiz.izquierdo) - Alturarbol(Raiz.derecho) == 2)
                {
                    if (nuevoValor < Raiz.izquierdo.Valor)
                    {
                        Raiz2 = Rotarsimpleizq(Raiz);
                    }
                    else
                    {
                        Raiz2 = Rotardobleizq(Raiz);
                    }
                }
                if (Alturarbol(Raiz.derecho)-Alturarbol(Raiz.izquierdo) ==2)
                {
                    if (nuevoValor > Raiz.derecho.Valor)
                    {
                        Raiz2 = Rotarsimpleder(Raiz); 
                    }
                    else
                    {
                        Raiz2 = Rotardobleder(Raiz);
                    }
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

        private int altura(Nodo derecho)
        {
            throw new NotImplementedException();
        }
        private int Ramamax(int ladoi, int ladod)
        {
            return ladoi > ladod ? ladoi : ladod; //? hace la comprobación si uno de ellos es nulo y hace la comparacion entre lados y si uno es nullo devuelve el lado derecho
        }
        private int Alturarbol(Nodo raiz)
        {
            return raiz == null ? -1 : raiz.alturaAVL;
        }
        private int Rotarsimpleizq(Nodo hijo1)
        {
            Nodo hijo2 = hijo1.derecho; //ver si las hojas tienen o no la misma altura 
            hijo1.izquierdo = hijo2.derecho;
            hijo2.derecho = hijo1;
            hijo1.alturaAVL = Ramamax(Alturarbol(hijo1.izquierdo), Alturarbol(hijo2.derecho)) + 1;
            hijo2.alturaAVL = Ramamax(Alturarbol(hijo2.izquierdo), hijo1.alturaAVL) + 1;
            return hijo2.alturaAVL; //devuelve la que ahora sera la raiz de la rotacion haciendo los cambios respectivos
        }
        private int Rotarsimpleder(Nodo hijo2)
        {
            Nodo hijo1 = hijo2.izquierdo;
            hijo2.derecho = hijo1.izquierdo;
            hijo1.izquierdo = hijo2;
            hijo2.alturaAVL = Ramamax(Alturarbol(hijo2.derecho), Alturarbol(hijo1.derecho)) + 1;
            hijo1.alturaAVL = Ramamax(Alturarbol(hijo1.derecho), hijo2.alturaAVL) + 1;
            return hijo1.alturaAVL; 
        }
        private int Rotardobleizq(Nodo val3)
        {
           // val3.izquierdo = Rotarsimpleder(val3.izquierdo);
            return Rotarsimpleizq(val3);
        }
        private int Rotardobleder(Nodo hijo2)
        {
            //hijo2.derecho = Rotarsimpleizq(hijo2.alturaAVL);
            return Rotarsimpleder(hijo2);
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
        //public int factorE(Nodo raiz, Nodo derecho)
        //{

        //}
        //public int factorE(int factor)
        //{

        //}

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
