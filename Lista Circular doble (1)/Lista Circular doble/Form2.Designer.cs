﻿namespace Lista_Circular_doble
{
  partial class FrmDatos
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.txtEdad = new System.Windows.Forms.TextBox();
      this.cmbRaza = new System.Windows.Forms.ComboBox();
      this.dgvDatos = new System.Windows.Forms.DataGridView();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.tslRegistrar = new System.Windows.Forms.ToolStripLabel();
      this.tsmConsultar = new System.Windows.Forms.ToolStripLabel();
      this.tsmEliminar = new System.Windows.Forms.ToolStripLabel();
      this.tsmSalir = new System.Windows.Forms.ToolStripLabel();
      this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
      this.Guardar = new System.Windows.Forms.Button();
      this.txtSEP = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
      this.toolStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.8481F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(26, 176);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(142, 37);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nombre:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.8481F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(26, 338);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(95, 37);
      this.label2.TabIndex = 1;
      this.label2.Text = "Edad:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.8481F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(26, 254);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(91, 37);
      this.label3.TabIndex = 2;
      this.label3.Text = "Raza:";
      // 
      // txtNombre
      // 
      this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei", 11.8481F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNombre.Location = new System.Drawing.Point(223, 170);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(196, 44);
      this.txtNombre.TabIndex = 3;
      // 
      // txtEdad
      // 
      this.txtEdad.Font = new System.Drawing.Font("Microsoft YaHei", 11.8481F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEdad.Location = new System.Drawing.Point(223, 333);
      this.txtEdad.Name = "txtEdad";
      this.txtEdad.Size = new System.Drawing.Size(196, 44);
      this.txtEdad.TabIndex = 4;
      // 
      // cmbRaza
      // 
      this.cmbRaza.Font = new System.Drawing.Font("Microsoft YaHei", 11.8481F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbRaza.FormattingEnabled = true;
      this.cmbRaza.Items.AddRange(new object[] {
            "",
            "Pastor Aleman",
            "Dowerman",
            "Labrador",
            "Chihuahua"});
      this.cmbRaza.Location = new System.Drawing.Point(223, 254);
      this.cmbRaza.Name = "cmbRaza";
      this.cmbRaza.Size = new System.Drawing.Size(196, 45);
      this.cmbRaza.TabIndex = 5;
      // 
      // dgvDatos
      // 
      this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
      this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDatos.Location = new System.Drawing.Point(477, 74);
      this.dgvDatos.Name = "dgvDatos";
      this.dgvDatos.RowHeadersWidth = 67;
      this.dgvDatos.RowTemplate.Height = 30;
      this.dgvDatos.Size = new System.Drawing.Size(1038, 596);
      this.dgvDatos.TabIndex = 6;
      // 
      // toolStrip1
      // 
      this.toolStrip1.ImageScalingSize = new System.Drawing.Size(26, 26);
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslRegistrar,
            this.tsmConsultar,
            this.tsmEliminar,
            this.tsmSalir});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
      this.toolStrip1.Size = new System.Drawing.Size(1529, 36);
      this.toolStrip1.TabIndex = 8;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // tslRegistrar
      // 
      this.tslRegistrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.tslRegistrar.Name = "tslRegistrar";
      this.tslRegistrar.Size = new System.Drawing.Size(94, 30);
      this.tslRegistrar.Text = "Registrar";
      this.tslRegistrar.Click += new System.EventHandler(this.toolStripLabel1_Click);
      // 
      // tsmConsultar
      // 
      this.tsmConsultar.Name = "tsmConsultar";
      this.tsmConsultar.Size = new System.Drawing.Size(101, 30);
      this.tsmConsultar.Text = "Consultar";
      this.tsmConsultar.Click += new System.EventHandler(this.tsmConsultar_Click);
      // 
      // tsmEliminar
      // 
      this.tsmEliminar.Name = "tsmEliminar";
      this.tsmEliminar.Size = new System.Drawing.Size(87, 30);
      this.tsmEliminar.Text = "Eliminar";
      this.tsmEliminar.Click += new System.EventHandler(this.tsmEliminar_Click);
      // 
      // tsmSalir
      // 
      this.tsmSalir.Name = "tsmSalir";
      this.tsmSalir.Size = new System.Drawing.Size(52, 30);
      this.tsmSalir.Text = "Salir";
      this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
      // 
      // erpError
      // 
      this.erpError.ContainerControl = this;
      // 
      // Guardar
      // 
      this.Guardar.Location = new System.Drawing.Point(103, 482);
      this.Guardar.Name = "Guardar";
      this.Guardar.Size = new System.Drawing.Size(136, 76);
      this.Guardar.TabIndex = 9;
      this.Guardar.Text = "Guardar ";
      this.Guardar.UseVisualStyleBackColor = true;
      this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
      // 
      // txtSEP
      // 
      this.txtSEP.Location = new System.Drawing.Point(278, 482);
      this.txtSEP.Name = "txtSEP";
      this.txtSEP.Size = new System.Drawing.Size(110, 29);
      this.txtSEP.TabIndex = 10;
      // 
      // FrmDatos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1529, 699);
      this.Controls.Add(this.txtSEP);
      this.Controls.Add(this.Guardar);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.dgvDatos);
      this.Controls.Add(this.cmbRaza);
      this.Controls.Add(this.txtEdad);
      this.Controls.Add(this.txtNombre);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "FrmDatos";
      this.Text = "ListaMascotas";
      this.Load += new System.EventHandler(this.FrmDatos_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.TextBox txtEdad;
    private System.Windows.Forms.ComboBox cmbRaza;
    private System.Windows.Forms.DataGridView dgvDatos;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripLabel tslRegistrar;
    private System.Windows.Forms.ToolStripLabel tsmConsultar;
    private System.Windows.Forms.ToolStripLabel tsmEliminar;
    private System.Windows.Forms.ToolStripLabel tsmSalir;
    private System.Windows.Forms.ErrorProvider erpError;
    private System.Windows.Forms.Button Guardar;
    private System.Windows.Forms.TextBox txtSEP;
  }
}