using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Circular_doble
{
  public partial class Lista_Circular_Doble : Form
  {
    Lista milista;
    public Lista_Circular_Doble()
    {
      InitializeComponent();
      milista = new Lista();

    }

    private void btnInsertar_Click(object sender, EventArgs e)
    {
      Nodo n;
      int d = Int32.Parse(txtdato.Text);
      n = new Nodo();
      n.Dato = d; 
      n.Siguiente = null; //este comando ya existe
      n.Atras = null;
      milista.Agregar(n);
      txtdato.Clear();
      txtdato.Focus();

    }

    private void btnMostrar_Click(object sender, EventArgs e)
    {
      lblContar.Text = milista.MostrarDatos();
      lblContarDes.Text = milista.MostrarDatosAnt();

    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      if (milista.Buscar(int.Parse(txtdato.Text)))
      {
        lblContar.Text = "Si esta";
      }
      else
      {
        lblContar.Text = "No esta";
      }
    }

    private void btnBorrar_Click(object sender, EventArgs e)
    {
      milista.Eliminar(int.Parse(txtdato.Text));
    
    }

    private void btnContar_Click(object sender, EventArgs e)
    {
      label2.Text = milista.ContarNodos ()+ "" ;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      ListaMascota frm2 = new ListaMascota();

      frm2.Show();
    }
  }
}

