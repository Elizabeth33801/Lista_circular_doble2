using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Circular_doble
{
  class Nodo
  {
    private int dato;
    public int Dato
    {
      get { return dato; }
      set { dato = value; }
    }
    //tiene un apuntador al siguiente nodo
    private Nodo siguiente;
    public Nodo Siguiente
    {
      get { return siguiente; }
      set { siguiente = value; }
    }

    // y tiene un apuntador al nodo anterior
    private Nodo atras;

    public Nodo Atras
    {
      get { return atras; }
      set { atras = value; }
    }
 
    public Nodo()
    {
      dato = 0;
      siguiente = null;


    }
    public Nodo(int dato,Nodo siguiente)
    {
      this.Dato = dato;
      this.Siguiente = siguiente;
    }

    public override string ToString()
    {
      return dato + "";
    }
  }
}
