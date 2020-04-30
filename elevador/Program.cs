using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace listaenlazada
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ListaEnlazada lista = new ListaEnlazada();//Se crea el objeto lista enlazada
            
            // lista.Insertar(1);//Se inserta un nodo a la lista con un atributo de tipo entero
            // lista.Insertar(2);
            // lista.Insertar(3);
            // lista.Insertar(4);
            // lista.Insertar(5);
            // lista.Mostrar();//_Muestra la lista enlazada ordenada del menor al mayor de los tipos enteros
            
            lista.Borrar(4);//Borra un nodo de la lista enlazada

            lista.elejir();
            //lista.yap();
            Console.ReadKey();
            int piso = 0;
            while (piso < 10)
            {
                lista.Insertar(piso);
                piso = piso ++;
            }
            lista.Mostrar();
        }
    }
    class Nodo
    {
        public int valor;
        public Nodo sig;
        public Nodo(int v, Nodo s)
        {
            valor = v;
            sig = s;
        }
    }
    class ListaEnlazada
    {
        Nodo primero;
        Nodo actual;
        public ListaEnlazada()
        {
        }
        public void Insertar(int v)
        {
            Nodo anterior;
            if (ListaVacia() || primero.valor > v)
            {
                primero = new Nodo(v, primero);
            }
            else
            {
                anterior = primero;
                while (anterior.sig != null && anterior.sig.valor <= v)
                anterior = anterior.sig;
                anterior.sig = new Nodo(v, anterior.sig);
            }
        }
        public void Mostrar()
        {
            Nodo aux;
            aux = primero;
            while (aux != null)
            {
                Console.Write(aux.valor + "->");
                aux = aux.sig;
            }
            Console.Write(" null");
            Console.WriteLine();
        }
        public void Siguiente()
        {
            if (actual != null)
            actual = actual.sig;
        }
        public void Primero()
        {
            actual = primero;
        }
        public void Borrar(int v)
        {
            Nodo anterior, nodo;
            nodo = primero;
            anterior = null;
            while (nodo != null && nodo.valor < v)
            {
                anterior = nodo;
                nodo = nodo.sig;
            }
            if (nodo == null || nodo.valor != v)
            return;
            else
            {
                if (anterior == null)
                primero = nodo.sig;
                else
                anterior.sig = nodo.sig;
            }
        }
        public bool ListaVacia()
        {
            if (primero == null)
            return true;
            return false;
        }
        public void Ultimo()
        {
            Primero();
            if (!ListaVacia())
            while (actual.sig != null)
            Siguiente();
        
        }
        public bool Actual()
        {
            if (actual != null)
            return true;
            return false;
        }
        public int ValorActual()
        {
            return actual.valor;
        }
        public int f;
        public void elejir()
        {
            
            f = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("elije un piso");
            System.Console.WriteLine($"{f} es el piso ideal");
            
        }
        // public void yap()
        // {
        //     int hj = 0;
        //     while(f< hj)
        //     {
        //         System.Console.WriteLine(hj);
        //         hj = hj ++;
        //         return hj;
        //     }
        //     return 0;
        // }
        
    }
}