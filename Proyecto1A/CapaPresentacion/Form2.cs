using Proyecto1A.CapaEdentidad;
using System;
using System.Collections;
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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        public static List<Clientes> listaClientes = new List<Clientes>();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

            //Cargar los datos iniciales
            if (!listaClientes.Any())
            {// cada vez que se cargue el formulario, si la lista esta vacia,
             // se agregan los productos iniciales
                listaClientes.Add(new Clientes
                {
                    Id = 1,
                    Nombre = "Carlos miguel",
                    Apellido = "alvadaro cruz",
                    Telefono = "(503+)3234-4545",
                    Estado = true
                });
                listaClientes.Add(new Clientes
                {
                    Id = 2,
                    Nombre = "josefina menendez",
                    Apellido = "valle torrez",
                    Telefono = "(503+)7655-4324",
                    Estado = true
                });
                listaClientes.Add(new Clientes
                {
                    Id = 3,
                    Nombre = "Raul menedez",
                    Apellido = "Valle Torrez",
                    Telefono = "(503+)5466-5453",
                    Estado = true
                });
            }
            RefrescarGrid();//mando a llamar el metodo para refrescar el datagridview
        }
        //asignar la lista como DataSOurce al datagridview
        private void RefrescarGrid()
        {
            dvgClientes.DataSource = null; // Limpiar el DataSource antes de reasignarlo
            dvgClientes.DataSource = listaClientes; // Asignar la lista como DataSource
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            //Validaciones basicas
            //valida que el nombre no este vacio
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la persona es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }

            {
                //Validaciones basicas
                //valida que el nombre no este vacio
                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MessageBox.Show("El Apellido de la persona es obligatorio.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                    return;
                }

                //Validaciones basicas
                //valida que el nombre no este vacio
                if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("El Telefono de la persona es obligatorio.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                    return;
                }

            }
            int nuevoId = listaClientes.Any() ? listaClientes.Max(x => x.Id) + 1 : 1;
            var p = new Clientes
            {
                Id = nuevoId,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Estado = Estado.Checked
            };
            //Agregar a la lista
            listaClientes.Add(p);
            RefrescarGrid();//refrescar el datagridview
            //Limpiar los controles
            LimpiarCampos();
        }
        //Metodo para limpiar los controles
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            Estado.Checked = true;
            txtNombre.Focus();

        }



        private void dvgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgClientes.CurrentRow == null) return;
            txtId.Text = dvgClientes.CurrentRow.Cells["Id"].Value.ToString();
            txtNombre.Text = dvgClientes.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = dvgClientes.CurrentRow.Cells["Apellido"].Value.ToString();
            txtTelefono.Text = dvgClientes.CurrentRow.Cells["Telefono"].Value.ToString();
            Estado.Checked = (bool)dvgClientes.CurrentRow.Cells["Estado"].Value;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Seleccione un Cliente válido para eliminar.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var prod = listaClientes.FirstOrDefault(x => x.Id == id);
            if (prod == null)
            {
                MessageBox.Show("Producto no Cliente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("¿Está seguro de eliminar el Cliente seleccionado?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listaClientes.Remove(prod);//con remove elimino el producto de la lista
                RefrescarGrid();//refrescar el datagridview
                LimpiarCampos();//limpiar los controles
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            //valido que el id sea un entero
            if (!int.TryParse(txtId.Text, out int Id))
            {
                MessageBox.Show("Seleccione un cliente válido para eliminar.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //busco el producto en la lista
            var prod = listaClientes.FirstOrDefault(x => x.Id == Id);
            //si lo encuentro, actualizo sus propiedades
            if (prod == null)
            {
                MessageBox.Show("Cliente no encontrado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Validaciones identicas a las del boton guardar
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del cliente es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }//valida que el precio ingresado sea un decimal
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El Apellido del cliente es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return;
            }//valida que el stock ingresado sea un entero
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("el telefono del cliente es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return;
            }
            //Actualizar los campos en memoria
            prod.Nombre = txtNombre.Text.Trim();
            prod.Apellido = txtApellido.Text.Trim();
            prod.Telefono = txtTelefono.Text.Trim();
            prod.Estado = Estado.Checked;
            MessageBox.Show("Producto actualizado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrescarGrid();//refrescar el datagridview
            LimpiarCampos();//limpiar los controles
        }


            

        


        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
             LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
