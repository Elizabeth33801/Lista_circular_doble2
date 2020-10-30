namespace Lista_Circular_doble
{
  partial class Lista_Circular_Doble
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
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(72, 107);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(237, 24);
      this.label1.TabIndex = 1;
      this.label1.Text = "Inserte elemento de la lista:";
      // 
      // txtdato
      // 
      this.txtdato.Location = new System.Drawing.Point(366, 107);
      this.txtdato.Name = "txtdato";
      this.txtdato.Size = new System.Drawing.Size(147, 28);
      this.txtdato.TabIndex = 2;
      // 
      // btnContar
      // 
      this.btnContar.Location = new System.Drawing.Point(388, 248);
      this.btnContar.Name = "btnContar";
      this.btnContar.Size = new System.Drawing.Size(105, 41);
      this.btnContar.TabIndex = 3;
      this.btnContar.Text = "Contar";
      this.btnContar.UseVisualStyleBackColor = true;
      this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
      // 
      // btnInsertar
      // 
      this.btnInsertar.Location = new System.Drawing.Point(388, 169);
      this.btnInsertar.Name = "btnInsertar";
      this.btnInsertar.Size = new System.Drawing.Size(105, 41);
      this.btnInsertar.TabIndex = 4;
      this.btnInsertar.Text = "Insertar";
      this.btnInsertar.UseVisualStyleBackColor = true;
      this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
      // 
      // btnMostrar
      // 
      this.btnMostrar.Location = new System.Drawing.Point(532, 248);
      this.btnMostrar.Name = "btnMostrar";
      this.btnMostrar.Size = new System.Drawing.Size(105, 41);
      this.btnMostrar.TabIndex = 5;
      this.btnMostrar.Text = "Mostrar";
      this.btnMostrar.UseVisualStyleBackColor = true;
      this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
      // 
      // btnBuscar
      // 
      this.btnBuscar.Location = new System.Drawing.Point(532, 169);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(105, 41);
      this.btnBuscar.TabIndex = 6;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // btnBorrar
      // 
      this.btnBorrar.Location = new System.Drawing.Point(388, 328);
      this.btnBorrar.Name = "btnBorrar";
      this.btnBorrar.Size = new System.Drawing.Size(105, 41);
      this.btnBorrar.TabIndex = 7;
      this.btnBorrar.Text = "Borrar";
      this.btnBorrar.UseVisualStyleBackColor = true;
      this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
      // 
      // lblContarDes
      // 
      this.lblContarDes.AutoSize = true;
      this.lblContarDes.Location = new System.Drawing.Point(72, 187);
      this.lblContarDes.Name = "lblContarDes";
      this.lblContarDes.Size = new System.Drawing.Size(110, 24);
      this.lblContarDes.TabIndex = 8;
      this.lblContarDes.Text = "....................";
      // 
      // lblContar
      // 
      this.lblContar.AutoSize = true;
      this.lblContar.Location = new System.Drawing.Point(72, 248);
      this.lblContar.Name = "lblContar";
      this.lblContar.Size = new System.Drawing.Size(115, 24);
      this.lblContar.TabIndex = 9;
      this.lblContar.Text = ".....................";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(226, 215);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 24);
      this.label2.TabIndex = 10;
      this.label2.Text = "label2";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(532, 319);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(105, 58);
      this.button1.TabIndex = 11;
      this.button1.Text = "Siguiente Lista";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Lista_Circular_Doble
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(727, 413);
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
      this.Name = "Lista_Circular_Doble";
      this.Text = "Lista circular doble";
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
  }
}

