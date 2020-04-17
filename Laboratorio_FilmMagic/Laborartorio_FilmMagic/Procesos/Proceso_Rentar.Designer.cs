namespace Laborartorio_FilmMagic.Procesos
{
    partial class Proceso_Rentar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proceso_Rentar));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Gpb_Encabezado = new System.Windows.Forms.GroupBox();
            this.btn_buscarS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscarM = new System.Windows.Forms.Button();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Txt_membresia = new System.Windows.Forms.TextBox();
            this.Txt_sucursal = new System.Windows.Forms.TextBox();
            this.Lbl_estadoMov = new System.Windows.Forms.Label();
            this.Lbl_fechaMov = new System.Windows.Forms.Label();
            this.Lbl_nombreConcep = new System.Windows.Forms.Label();
            this.Lbl_codigoMov = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaE = new System.Windows.Forms.DateTimePicker();
            this.Dgv_MovIntDetalles = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.btn_BuscarProducto = new System.Windows.Forms.Button();
            this.Codigo_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.Pnl_nombreForm.SuspendLayout();
            this.Gpb_Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MovIntDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.LightGreen;
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.lblTitulo);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(1, 0);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(1135, 51);
            this.Pnl_nombreForm.TabIndex = 5;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(1009, 5);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.btn_Ayuda.TabIndex = 6;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(959, 5);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(77, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(98, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RENTAR";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1059, 5);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Gpb_Encabezado
            // 
            this.Gpb_Encabezado.Controls.Add(this.dtp_FechaE);
            this.Gpb_Encabezado.Controls.Add(this.dtp_fecha);
            this.Gpb_Encabezado.Controls.Add(this.btn_buscarS);
            this.Gpb_Encabezado.Controls.Add(this.btn_buscarM);
            this.Gpb_Encabezado.Controls.Add(this.Txt_Codigo);
            this.Gpb_Encabezado.Controls.Add(this.Txt_membresia);
            this.Gpb_Encabezado.Controls.Add(this.Txt_sucursal);
            this.Gpb_Encabezado.Controls.Add(this.label2);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_estadoMov);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_fechaMov);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_nombreConcep);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_codigoMov);
            this.Gpb_Encabezado.Location = new System.Drawing.Point(21, 73);
            this.Gpb_Encabezado.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_Encabezado.Name = "Gpb_Encabezado";
            this.Gpb_Encabezado.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_Encabezado.Size = new System.Drawing.Size(1100, 157);
            this.Gpb_Encabezado.TabIndex = 6;
            this.Gpb_Encabezado.TabStop = false;
            this.Gpb_Encabezado.Text = "Encabezado";
            // 
            // btn_buscarS
            // 
            this.btn_buscarS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarS.BackgroundImage")));
            this.btn_buscarS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarS.Location = new System.Drawing.Point(1040, 15);
            this.btn_buscarS.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscarS.Name = "btn_buscarS";
            this.btn_buscarS.Size = new System.Drawing.Size(43, 39);
            this.btn_buscarS.TabIndex = 109;
            this.btn_buscarS.UseVisualStyleBackColor = true;
            this.btn_buscarS.Click += new System.EventHandler(this.Btn_buscarS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(788, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 107;
            this.label2.Text = "Sucursal";
            // 
            // btn_buscarM
            // 
            this.btn_buscarM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarM.BackgroundImage")));
            this.btn_buscarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarM.Location = new System.Drawing.Point(301, 86);
            this.btn_buscarM.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscarM.Name = "btn_buscarM";
            this.btn_buscarM.Size = new System.Drawing.Size(43, 39);
            this.btn_buscarM.TabIndex = 106;
            this.btn_buscarM.UseVisualStyleBackColor = true;
            this.btn_buscarM.Click += new System.EventHandler(this.Btn_buscarM_Click);
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(120, 23);
            this.Txt_Codigo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(173, 22);
            this.Txt_Codigo.TabIndex = 11;
            // 
            // Txt_membresia
            // 
            this.Txt_membresia.Location = new System.Drawing.Point(120, 92);
            this.Txt_membresia.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_membresia.Name = "Txt_membresia";
            this.Txt_membresia.Size = new System.Drawing.Size(173, 22);
            this.Txt_membresia.TabIndex = 10;
            // 
            // Txt_sucursal
            // 
            this.Txt_sucursal.Enabled = false;
            this.Txt_sucursal.Location = new System.Drawing.Point(859, 23);
            this.Txt_sucursal.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_sucursal.Name = "Txt_sucursal";
            this.Txt_sucursal.Size = new System.Drawing.Size(173, 22);
            this.Txt_sucursal.TabIndex = 7;
            // 
            // Lbl_estadoMov
            // 
            this.Lbl_estadoMov.AutoSize = true;
            this.Lbl_estadoMov.Location = new System.Drawing.Point(16, 28);
            this.Lbl_estadoMov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_estadoMov.Name = "Lbl_estadoMov";
            this.Lbl_estadoMov.Size = new System.Drawing.Size(38, 17);
            this.Lbl_estadoMov.TabIndex = 4;
            this.Lbl_estadoMov.Text = "COD";
            // 
            // Lbl_fechaMov
            // 
            this.Lbl_fechaMov.AutoSize = true;
            this.Lbl_fechaMov.Location = new System.Drawing.Point(367, 99);
            this.Lbl_fechaMov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_fechaMov.Name = "Lbl_fechaMov";
            this.Lbl_fechaMov.Size = new System.Drawing.Size(101, 17);
            this.Lbl_fechaMov.TabIndex = 3;
            this.Lbl_fechaMov.Text = "Fecha Entrega";
            // 
            // Lbl_nombreConcep
            // 
            this.Lbl_nombreConcep.AutoSize = true;
            this.Lbl_nombreConcep.Location = new System.Drawing.Point(12, 97);
            this.Lbl_nombreConcep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombreConcep.Name = "Lbl_nombreConcep";
            this.Lbl_nombreConcep.Size = new System.Drawing.Size(106, 17);
            this.Lbl_nombreConcep.TabIndex = 2;
            this.Lbl_nombreConcep.Text = "Cod Membresia";
            // 
            // Lbl_codigoMov
            // 
            this.Lbl_codigoMov.AutoSize = true;
            this.Lbl_codigoMov.Location = new System.Drawing.Point(367, 28);
            this.Lbl_codigoMov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_codigoMov.Name = "Lbl_codigoMov";
            this.Lbl_codigoMov.Size = new System.Drawing.Size(98, 17);
            this.Lbl_codigoMov.TabIndex = 0;
            this.Lbl_codigoMov.Text = "Fecha Alquiler";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(474, 24);
            this.dtp_fecha.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(275, 22);
            this.dtp_fecha.TabIndex = 108;
            // 
            // dtp_FechaE
            // 
            this.dtp_FechaE.Location = new System.Drawing.Point(477, 99);
            this.dtp_FechaE.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_FechaE.Name = "dtp_FechaE";
            this.dtp_FechaE.Size = new System.Drawing.Size(275, 22);
            this.dtp_FechaE.TabIndex = 109;
            // 
            // Dgv_MovIntDetalles
            // 
            this.Dgv_MovIntDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_MovIntDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Movimiento,
            this.CodigoProducto,
            this.NombreProducto,
            this.Concepto});
            this.Dgv_MovIntDetalles.Location = new System.Drawing.Point(61, 257);
            this.Dgv_MovIntDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_MovIntDetalles.Name = "Dgv_MovIntDetalles";
            this.Dgv_MovIntDetalles.RowHeadersVisible = false;
            this.Dgv_MovIntDetalles.RowHeadersWidth = 51;
            this.Dgv_MovIntDetalles.Size = new System.Drawing.Size(503, 216);
            this.Dgv_MovIntDetalles.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(669, 259);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 22);
            this.textBox1.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 111;
            this.label1.Text = "Producto";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(916, 257);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(118, 32);
            this.btn_Agregar.TabIndex = 112;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 328);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 113;
            this.label3.Text = "Total";
            // 
            // txt_Total
            // 
            this.txt_Total.Enabled = false;
            this.txt_Total.Location = new System.Drawing.Point(669, 328);
            this.txt_Total.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(140, 22);
            this.txt_Total.TabIndex = 114;
            // 
            // btn_BuscarProducto
            // 
            this.btn_BuscarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BuscarProducto.BackgroundImage")));
            this.btn_BuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuscarProducto.Location = new System.Drawing.Point(861, 250);
            this.btn_BuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarProducto.Name = "btn_BuscarProducto";
            this.btn_BuscarProducto.Size = new System.Drawing.Size(43, 39);
            this.btn_BuscarProducto.TabIndex = 110;
            this.btn_BuscarProducto.UseVisualStyleBackColor = true;
            // 
            // Codigo_Movimiento
            // 
            this.Codigo_Movimiento.HeaderText = "Codigo Producto";
            this.Codigo_Movimiento.MinimumWidth = 6;
            this.Codigo_Movimiento.Name = "Codigo_Movimiento";
            this.Codigo_Movimiento.Width = 125;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Nombre";
            this.CodigoProducto.MinimumWidth = 6;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Width = 125;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Precio";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Width = 125;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Categoria";
            this.Concepto.MinimumWidth = 6;
            this.Concepto.Name = "Concepto";
            this.Concepto.Width = 125;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(916, 320);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(118, 32);
            this.btn_Guardar.TabIndex = 115;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Proceso_Rentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 499);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_BuscarProducto);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Dgv_MovIntDetalles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gpb_Encabezado);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proceso_Rentar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso_Rentar";
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.Gpb_Encabezado.ResumeLayout(false);
            this.Gpb_Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MovIntDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.GroupBox Gpb_Encabezado;
        private System.Windows.Forms.Button btn_buscarS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscarM;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.TextBox Txt_membresia;
        private System.Windows.Forms.TextBox Txt_sucursal;
        private System.Windows.Forms.Label Lbl_estadoMov;
        private System.Windows.Forms.Label Lbl_fechaMov;
        private System.Windows.Forms.Label Lbl_nombreConcep;
        private System.Windows.Forms.Label Lbl_codigoMov;
        private System.Windows.Forms.DateTimePicker dtp_FechaE;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.DataGridView Dgv_MovIntDetalles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Button btn_BuscarProducto;
        private System.Windows.Forms.Button btn_Guardar;
    }
}