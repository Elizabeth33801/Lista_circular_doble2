﻿namespace Lista_Circular_doble
{
  partial class form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.txtdato = new System.Windows.Forms.TextBox();
      this.btnContar = new System.Windows.Forms.Button();
      this.btnInsertar = new System.Windows.Forms.Button();
      this.btnMostrar = new System.Windows.Forms.Button();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.btnBorrar = new System.Windows.Forms.Button();
      this.lblContarDes = new System.Windows.Forms.Label();
      this.lblContar = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Lista = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.txtSEP = new System.Windows.Forms.TextBox();
      this.button3 = new System.Windows.Forms.Button();
      this.buscando = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe Print", 15.94937F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(217, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(560, 67);
      this.label1.TabIndex = 1;
      this.label1.Text = "Inserte elemento de la lista:";
      // 
      // txtdato
      // 
      this.txtdato.Location = new System.Drawing.Point(855, 60);
      this.txtdato.Name = "txtdato";
      this.txtdato.Size = new System.Drawing.Size(76, 29);
      this.txtdato.TabIndex = 2;
      // 
      // btnContar
      // 
      this.btnContar.Location = new System.Drawing.Point(986, 446);
      this.btnContar.Name = "btnContar";
      this.btnContar.Size = new System.Drawing.Size(219, 68);
      this.btnContar.TabIndex = 3;
      this.btnContar.Text = "Contar";
      this.btnContar.UseVisualStyleBackColor = true;
      this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
      // 
      // btnInsertar
      // 
      this.btnInsertar.Location = new System.Drawing.Point(986, 369);
      this.btnInsertar.Name = "btnInsertar";
      this.btnInsertar.Size = new System.Drawing.Size(219, 68);
      this.btnInsertar.TabIndex = 4;
      this.btnInsertar.Text = "Insertar";
      this.btnInsertar.UseVisualStyleBackColor = true;
      this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
      // 
      // btnMostrar
      // 
      this.btnMostrar.Location = new System.Drawing.Point(1255, 369);
      this.btnMostrar.Name = "btnMostrar";
      this.btnMostrar.Size = new System.Drawing.Size(219, 68);
      this.btnMostrar.TabIndex = 5;
      this.btnMostrar.Text = "Mostrar";
      this.btnMostrar.UseVisualStyleBackColor = true;
      this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
      // 
      // btnBuscar
      // 
      this.btnBuscar.Location = new System.Drawing.Point(986, 524);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(219, 68);
      this.btnBuscar.TabIndex = 6;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // btnBorrar
      // 
      this.btnBorrar.Location = new System.Drawing.Point(1255, 446);
      this.btnBorrar.Name = "btnBorrar";
      this.btnBorrar.Size = new System.Drawing.Size(219, 68);
      this.btnBorrar.TabIndex = 7;
      this.btnBorrar.Text = "Borrar";
      this.btnBorrar.UseVisualStyleBackColor = true;
      this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
      // 
      // lblContarDes
      // 
      this.lblContarDes.AutoSize = true;
      this.lblContarDes.Location = new System.Drawing.Point(55, 134);
      this.lblContarDes.Name = "lblContarDes";
      this.lblContarDes.Size = new System.Drawing.Size(112, 25);
      this.lblContarDes.TabIndex = 8;
      this.lblContarDes.Text = "....................";
      // 
      // lblContar
      // 
      this.lblContar.AutoSize = true;
      this.lblContar.Location = new System.Drawing.Point(55, 174);
      this.lblContar.Name = "lblContar";
      this.lblContar.Size = new System.Drawing.Size(117, 25);
      this.lblContar.TabIndex = 9;
      this.lblContar.Text = ".....................";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(50, 216);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(172, 25);
      this.label2.TabIndex = 10;
      this.label2.Text = "Contando nodos...";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(1255, 524);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(219, 68);
      this.button1.TabIndex = 11;
      this.button1.Text = "Siguiente Lista";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(986, 602);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(219, 68);
      this.button2.TabIndex = 12;
      this.button2.Text = "Guardar ";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lista});
      this.dataGridView1.Location = new System.Drawing.Point(14, 260);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 67;
      this.dataGridView1.RowTemplate.Height = 30;
      this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dataGridView1.Size = new System.Drawing.Size(874, 608);
      this.dataGridView1.TabIndex = 13;
      // 
      // Lista
      // 
      this.Lista.HeaderText = "Lista";
      this.Lista.MinimumWidth = 8;
      this.Lista.Name = "Lista";
      this.Lista.Width = 165;
      // 
      // txtSEP
      // 
      this.txtSEP.Location = new System.Drawing.Point(986, 302);
      this.txtSEP.Name = "txtSEP";
      this.txtSEP.Size = new System.Drawing.Size(67, 29);
      this.txtSEP.TabIndex = 15;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(1154, 222);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(231, 64);
      this.button3.TabIndex = 16;
      this.button3.Text = "Modificar tabla";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // buscando
      // 
      this.buscando.AutoSize = true;
      this.buscando.Location = new System.Drawing.Point(1140, 306);
      this.buscando.Name = "buscando";
      this.buscando.Size = new System.Drawing.Size(158, 25);
      this.buscando.TabIndex = 17;
      this.buscando.Text = "Buscando dato...";
      // 
      // form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1713, 920);
      this.Controls.Add(this.buscando);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.txtSEP);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblContar);
      this.Controls.Add(this.lblContarDes);
      this.Controls.Add(this.btnBorrar);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.btnMostrar);
      this.Controls.Add(this.btnInsertar);
      this.Controls.Add(this.btnContar);
      this.Controls.Add(this.txtdato);
      this.Controls.Add(this.label1);
      this.Name = "form1";
      this.Text = "Lista circular doble";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.TextBox txtdato;
    private System.Windows.Forms.Button btnContar;
    private System.Windows.Forms.Button btnInsertar;
    private System.Windows.Forms.Button btnMostrar;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.Button btnBorrar;
    private System.Windows.Forms.Label lblContarDes;
    private System.Windows.Forms.Label lblContar;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.TextBox txtSEP;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Lista;
    private System.Windows.Forms.Label buscando;
  }
}

