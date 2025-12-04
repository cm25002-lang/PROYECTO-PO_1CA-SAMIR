using Proyecto1A.CapaDatos;
using Proyecto1A.CapaEdentidad;
using Proyecto1A.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1A.CapaPresentacion
{
    public partial class FrmRegistrarVenta : Form
    {
        public FrmRegistrarVenta()
        {
            InitializeComponent();
        }

        private void FrmRegistrarVenta_Load(object sender, EventArgs e)
        {
            // --- CLIENTES ---
            cboCliente.DataSource = ClienteDAL.ListarActivos();
            cboCliente.DisplayMember = "Nombre";

            cboCliente.ValueMember = "Id";

            // --- TIPO PAGO ---
            cboTipoPago.DataSource = TipoPagoDAL.Listar(); //asiganmos datos al desplegable
            cboTipoPago.DisplayMember = "Nombre"; //lo que muestra
            cboTipoPago.ValueMember = "Id"; //el valor que nos importa ID

            // --- FECHA ---
            dtpFecha.Value = DateTime.Now;//obtiene la fecha de ahora

            // --- CONFIGURAR COLUMNAS DEL DETALLE ---
            ConfigurarTablaDetalles();

        }


        private void ConfigurarTablaDetalles()
        {
            dvgDetalle.Columns.Clear();

            // ID PRODUCTO
            DataGridViewTextBoxColumn colIdProd = new DataGridViewTextBoxColumn();
            colIdProd.Name = "Id_Producto";
            colIdProd.HeaderText = "ID";
            colIdProd.Visible = false;
            dvgDetalle.Columns.Add(colIdProd);

            // NOMBRE PRODUCTO
            dvgDetalle.Columns.Add("NombreProducto", "Producto");

            // CANTIDAD
            DataGridViewTextBoxColumn colCant = new DataGridViewTextBoxColumn();
            colCant.Name = "Cantidad";
            colCant.HeaderText = "Cant.";
            dvgDetalle.Columns.Add(colCant);

            // PRECIO UNITARIO
            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.Name = "PrecioUnitario";
            colPrecio.HeaderText = "Precio Unitario";
            dvgDetalle.Columns.Add(colPrecio);

            // SUBTOTAL
            DataGridViewTextBoxColumn colSub = new DataGridViewTextBoxColumn();
            colSub.Name = "SubTotal";
            colSub.HeaderText = "Subtotal";
            colSub.ReadOnly = true;
            dvgDetalle.Columns.Add(colSub);
            // Asegurar permisos de edición
            dvgDetalle.ReadOnly = false;

            // Columnas NO editables
            dvgDetalle.Columns["SubTotal"].ReadOnly = true;
            dvgDetalle.Columns["PrecioUnitario"].ReadOnly = true;
            dvgDetalle.Columns["NombreProducto"].ReadOnly = true;
            dvgDetalle.Columns["Id_Producto"].ReadOnly = true;

            // ÚNICA columna editable:
            dvgDetalle.Columns["Cantidad"].ReadOnly = false;


            CargarProductos(string.Empty);

        }

        //Meétodo que trae los datos al dgv, colocado fuera del LOAD
        private void CargarProductos(string filtro)
        {
            // Obtenemos la lista desde DAL
            var tabla = ProductoDAL.Listar(); // ya lo creamos en Paso 2

            // Filtrar si hay texto
            if (!string.IsNullOrWhiteSpace(filtro))
            {
                var dv = tabla.DefaultView;
                dv.RowFilter = $"Nombre LIKE '%{filtro}%'";
                dvgProductos.DataSource = dv;
            }
            else
            {
                dvgProductos.DataSource = tabla;
            }

            dvgProductos.Columns["Id"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscarProducto.Text.Trim();
            CargarProductos(texto);

        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (dvgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            DataGridViewRow row = dvgProductos.SelectedRows[0];

            int idProducto = Convert.ToInt32(row.Cells["Id"].Value);
            string nombre = row.Cells["Nombre"].Value.ToString();
            decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);

            // Cantidad inicial = 1
            int cantidad = 1;

            decimal subTotal = precio * cantidad;

            // Agregar al detalle
            dvgDetalle.Rows.Add(
                idProducto,
                nombre,
                cantidad,
                precio,
                subTotal
            );
            RecalcularTotal();//dará error, mas adelante se creará el método, comenta esta linea cuando ejecutes
        }

        private void dvgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgregarProducto_Click(sender, e);

        }


        private void RecalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dvgDetalle.Rows)
            {
                total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
            }

            lblTotal.Text = "Total: $" + total.ToString("0.00");
        }

        private void dvgDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Si editaron la columna Cantidad
            if (dvgDetalle.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                DataGridViewRow row = dvgDetalle.Rows[e.RowIndex];

                int cantidad;
                bool ok = int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out cantidad);

                if (!ok || cantidad <= 0)
                {
                    MessageBox.Show("Cantidad inválida.");
                    row.Cells["Cantidad"].Value = 1;
                    cantidad = 1;
                }

                decimal precio = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                decimal subTotal = cantidad * precio;

                row.Cells["SubTotal"].Value = subTotal;

                // Recalcular total general
                RecalcularTotal();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dvgDetalle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para quitar.");
                return;
            }

            dvgDetalle.Rows.RemoveAt(dvgDetalle.SelectedRows[0].Index);

            RecalcularTotal();
        }

        private void btnLimpiarDetalle_Click(object sender, EventArgs e)
        {
            dvgDetalle.Rows.Clear();
            RecalcularTotal();

        }

        private void btnRegistraVenta_Click(object sender, EventArgs e)
        {

            try
            {
                if (dvgDetalle.Rows.Count == 0)
                {
                    MessageBox.Show("La venta no tiene productos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ---------------------------------------------------
                // 1) CREAR OBJETO VENTA
                // ---------------------------------------------------
                Venta venta = new Venta()
                {
                    Fecha = dtpFecha.Value,
                    MontoTotal = ObtenerTotalVenta(), // lo creamos abajo
                    Id_Cliente = Convert.ToInt32(cboCliente.SelectedValue),
                    Id_TipoPago = Convert.ToInt32(cboTipoPago.SelectedValue)
                };


                // ---------------------------------------------------
                // 2) CREAR LISTA DE DETALLES
                // ---------------------------------------------------
                List<DetalleVenta> detalles = new List<DetalleVenta>();

                foreach (DataGridViewRow row in dvgDetalle.Rows)
                {
                    detalles.Add(new DetalleVenta()
                    {
                        Id_Producto = Convert.ToInt32(row.Cells["Id_Producto"].Value),
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        PrecioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value),
                        SubTotal = Convert.ToDecimal(row.Cells["SubTotal"].Value)
                    });



                }

                // ---------------------------------------------------
                // 3) VALIDAR EN BLL
                // ---------------------------------------------------
                var validacion = VentaBLL.ValidarVenta(venta, detalles);

                if (!validacion.Exito)
                {
                    MessageBox.Show(validacion.Mensaje, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ---------------------------------------------------
                // 4) GUARDAR EN BASE DE DATOS (TRANSACCIÓN)
                // ---------------------------------------------------
                var resultado = VentaDAL.RegistrarVentaTransaccional(venta, detalles);

                if (resultado.Exito)
                {
                    MessageBox.Show(resultado.Mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show(resultado.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }
        //metodo calcular el total de la venta
        private decimal ObtenerTotalVenta()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dvgDetalle.Rows)
                total += Convert.ToDecimal(row.Cells["SubTotal"].Value);

            return total;
        }
        private void LimpiarFormulario()
        {
            dvgDetalle.Rows.Clear();
            lblTotal.Text = "Total: $0.00";
            txtBuscarProducto.Clear();
            CargarProductos(string.Empty); // recarga lista completa

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                CargarProductos(txtBuscarProducto.Text.Trim());
            }

        }
    }

    }









