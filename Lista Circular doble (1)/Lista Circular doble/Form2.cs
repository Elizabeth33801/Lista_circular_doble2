using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lista_Circular_doble
{
  public partial class FrmDatos : Form
  {
    List<ClsLista> OtraLista = new List<ClsLista>();
    public FrmDatos()
    {
      InitializeComponent();
    
      tsmConsultar.Enabled = false;
      tsmEliminar.Enabled = false;

    }

    private void toolStripLabel1_Click(object sender, EventArgs e)
    {//validar la raza

      if (ValidarNombre() == false)
      {
        return;
      }
      if (ValidarRaza() == false)
      {
        return;
      }
      if (ValidarEdad() == false)
      {
        return;
      }
      if (Existe(txtNombre.Text))
      {
        erpError.SetError(txtNombre, "La mascota con ese nombre ya esta registrado");
        LimpiarControles();
        txtNombre.Focus();
        return;

      }
      erpError.SetError(txtNombre, "");


      //Creamos el objeto de la clase lista
      ClsLista miMascota = new ClsLista();
      miMascota.Nombre = txtNombre.Text;
      miMascota.Raza = cmbRaza.SelectedItem.ToString();
      miMascota.Edad = int.Parse(txtEdad.Text);
      OtraLista.Add(miMascota);
      dgvDatos.DataSource = null;
      dgvDatos.DataSource = OtraLista;
      LimpiarControles();
      txtNombre.Focus();
      tsmConsultar.Enabled = true;
    }
    //metodo que valida que no ingresen mascotas con el mismo nombre
    private bool Existe(string Nombre)
    {
      foreach (ClsLista miMascota in OtraLista)
      {
        if (miMascota.Nombre==Nombre)
        {
          return true;
        }
        
      }
      return false;
    }

    private bool ValidarEdad()
    {
      int Edad;
      if (!int.TryParse(txtEdad.Text, out Edad) || txtEdad.Text == "")
      {
        erpError.SetError(txtEdad, "Debe ingresar un valor numerico");
        txtEdad.Clear();
        txtEdad.Focus();
        return false;
      }
      else
      {
        erpError.SetError(txtEdad, "");
        return true;
      }
    }

    private bool ValidarRaza()
    {
      if (string.IsNullOrEmpty(cmbRaza.Text))
      {
        erpError.SetError(cmbRaza, "DEBE SELECCIONAR UNA RAZA");
        return false;

      }
      else
      {
        erpError.SetError(cmbRaza, "");
        return true;
      }
    }

    //validar el nombre
    private bool ValidarNombre()
    {
      if (string.IsNullOrEmpty(txtNombre.Text))
      {
        erpError.SetError(txtNombre, "Debe ingresar un nombre");
        return false;
      }
      else
      {
        erpError.SetError(txtNombre, "");
        return true;
      }
    }
    private void LimpiarControles()
    {
      txtNombre.Clear();
      txtEdad.Clear();
      cmbRaza.SelectedItem = 0;

    }

    private void tsmSalir_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void tsmConsultar_Click(object sender, EventArgs e)
    {
      if (ValidarNombre() == false)
      {
        return;
      }
      ClsLista miMascota = GetMascota(txtNombre.Text);
      if (miMascota == null)
      {
        erpError.SetError(txtNombre, "La mascota no esta registrada en la lista");
        LimpiarControles();
        txtNombre.Focus();
        return;
      }
      else
      {
        erpError.SetError(txtNombre, "");
        txtNombre.Text = miMascota.Nombre;
        cmbRaza.SelectedItem = miMascota.Raza;
        txtEdad.Text = miMascota.Edad.ToString();
        tsmEliminar.Enabled = true;
      }

    }
    //metodo consultar mascota
    private ClsLista GetMascota(string nombre)
    {
      return OtraLista.Find(mascota => mascota.Nombre.Contains(nombre));

    }

    private void tsmEliminar_Click(object sender, EventArgs e)
    {
      if (txtNombre.Text == "")
      {
        erpError.SetError(txtNombre, "Debe primero consultar la mascota a eliminar");
        LimpiarControles();
        txtNombre.Focus();
        tsmEliminar.Enabled = false;
        return;
      }
      else
      {
        erpError.SetError(txtNombre, "");
        DialogResult Respuesta = MessageBox.Show("¿Esta seguro de querer eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        if (Respuesta == DialogResult.Yes)
        {
          foreach (ClsLista miMascota in OtraLista)
          {
            if (miMascota.Nombre == txtNombre.Text)
            {
              OtraLista.Remove(miMascota);
              break;
            }
          }
          LimpiarControles();
          dgvDatos.DataSource = null;
          dgvDatos.DataSource = OtraLista;
        }
      }
    }

    private void FrmDatos_Load(object sender, EventArgs e)
    {

    }

    private void Guardar_Click(object sender, EventArgs e)
    {
      SaveFileDialog sfd = new SaveFileDialog() { Filter = "Archivo CSV|*.csv" };
      if (sfd.ShowDialog() == DialogResult.OK)
      {
        List<string> filas = new List<string>();

        List<string> cabeceras = new List<string>();
        foreach (DataGridViewColumn col in dgvDatos.Columns)
        {
          cabeceras.Add(col.HeaderText);
        }
        string SEP = txtSEP.Text;
        filas.Add(string.Join(SEP, cabeceras));

        foreach (DataGridViewRow fila in dgvDatos.Rows)
        {
          try
          {

            List<string> celdas = new List<string>();
            foreach (DataGridViewCell c in fila.Cells)
              celdas.Add(c.Value.ToString());

            filas.Add(string.Join(SEP, celdas));
          }
          catch (Exception ex)
          { }
        }

        File.WriteAllLines(sfd.FileName, filas);
      }
    }

 

  
  }
}
