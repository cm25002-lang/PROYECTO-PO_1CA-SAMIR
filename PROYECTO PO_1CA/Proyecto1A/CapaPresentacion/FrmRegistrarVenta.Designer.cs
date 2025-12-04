namespace Proyecto1A.CapaPresentacion
{
    partial class FrmRegistrarVenta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dvgProductos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.llbBuscar = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarDetalle = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dvgDetalle = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistraVenta = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProductos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetalle)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarProducto);
            this.groupBox1.Controls.Add(this.dvgProductos);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscarProducto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.llbBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 149);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(428, 333);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(54, 288);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(316, 27);
            this.btnAgregarProducto.TabIndex = 20;
            this.btnAgregarProducto.Text = "Agregar Producto Al Carrito";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // dvgProductos
            // 
            this.dvgProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProductos.Location = new System.Drawing.Point(25, 95);
            this.dvgProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvgProductos.Name = "dvgProductos";
            this.dvgProductos.ReadOnly = true;
            this.dvgProductos.RowHeadersWidth = 51;
            this.dvgProductos.RowTemplate.Height = 24;
            this.dvgProductos.Size = new System.Drawing.Size(387, 167);
            this.dvgProductos.TabIndex = 3;
            this.dvgProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProductos_CellDoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBuscar.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(250, 39);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 38);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(80, 45);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(134, 27);
            this.txtBuscarProducto.TabIndex = 14;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            this.txtBuscarProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProducto_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 6;
            // 
            // llbBuscar
            // 
            this.llbBuscar.AutoSize = true;
            this.llbBuscar.Location = new System.Drawing.Point(14, 47);
            this.llbBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbBuscar.Name = "llbBuscar";
            this.llbBuscar.Size = new System.Drawing.Size(67, 20);
            this.llbBuscar.TabIndex = 2;
            this.llbBuscar.Text = "FILTRAR:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(150, 509);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(153, 21);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total A Pagar: $0.00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiarDetalle);
            this.groupBox2.Controls.Add(this.btnQuitar);
            this.groupBox2.Controls.Add(this.dvgDetalle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(449, 149);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(500, 333);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle De La Venta";
            // 
            // btnLimpiarDetalle
            // 
            this.btnLimpiarDetalle.BackColor = System.Drawing.Color.Pink;
            this.btnLimpiarDetalle.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDetalle.Location = new System.Drawing.Point(418, 175);
            this.btnLimpiarDetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarDetalle.Name = "btnLimpiarDetalle";
            this.btnLimpiarDetalle.Size = new System.Drawing.Size(78, 61);
            this.btnLimpiarDetalle.TabIndex = 21;
            this.btnLimpiarDetalle.Text = "Limpiar Todos";
            this.btnLimpiarDetalle.UseVisualStyleBackColor = false;
            this.btnLimpiarDetalle.Click += new System.EventHandler(this.btnLimpiarDetalle_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnQuitar.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(418, 78);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(78, 61);
            this.btnQuitar.TabIndex = 20;
            this.btnQuitar.Text = "Quitar Producto";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // dvgDetalle
            // 
            this.dvgDetalle.AllowUserToAddRows = false;
            this.dvgDetalle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDetalle.Location = new System.Drawing.Point(24, 64);
            this.dvgDetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvgDetalle.Name = "dvgDetalle";
            this.dvgDetalle.ReadOnly = true;
            this.dvgDetalle.RowHeadersWidth = 51;
            this.dvgDetalle.RowTemplate.Height = 24;
            this.dvgDetalle.Size = new System.Drawing.Size(387, 223);
            this.dvgDetalle.TabIndex = 3;
            this.dvgDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDetalle_CellEndEdit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 6;
            // 
            // btnRegistraVenta
            // 
            this.btnRegistraVenta.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistraVenta.Location = new System.Drawing.Point(434, 509);
            this.btnRegistraVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistraVenta.Name = "btnRegistraVenta";
            this.btnRegistraVenta.Size = new System.Drawing.Size(165, 32);
            this.btnRegistraVenta.TabIndex = 20;
            this.btnRegistraVenta.Text = "Registar Venta";
            this.btnRegistraVenta.UseVisualStyleBackColor = true;
            this.btnRegistraVenta.Click += new System.EventHandler(this.btnRegistraVenta_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(632, 509);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(165, 32);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpFecha);
            this.groupBox3.Controls.Add(this.cboTipoPago);
            this.groupBox3.Controls.Add(this.lblPago);
            this.groupBox3.Controls.Add(this.btnNuevoCliente);
            this.groupBox3.Controls.Add(this.cboCliente);
            this.groupBox3.Controls.Add(this.lblCliente);
            this.groupBox3.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(26, 67);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(916, 77);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Generales ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(706, 33);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(199, 31);
            this.dtpFecha.TabIndex = 23;
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(589, 36);
            this.cboTipoPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(97, 26);
            this.cboTipoPago.TabIndex = 22;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Location = new System.Drawing.Point(488, 36);
            this.lblPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(108, 19);
            this.lblPago.TabIndex = 21;
            this.lblPago.Text = "Tipo de pago:";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.BurlyWood;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Location = new System.Drawing.Point(350, 26);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(113, 38);
            this.btnNuevoCliente.TabIndex = 20;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(76, 33);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(252, 26);
            this.cboCliente.TabIndex = 4;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(13, 36);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(66, 19);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(373, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(320, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Formulario pos-Registro de venta:";
            // 
            // FrmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(976, 552);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistraVenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRegistrarVenta";
            this.Text = "FrmRegistrarVenta";
            this.Load += new System.EventHandler(this.FrmRegistrarVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProductos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetalle)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label llbBuscar;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.DataGridView dvgProductos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvgDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiarDetalle;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnRegistraVenta;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label6;
    }
}