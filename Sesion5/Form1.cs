using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sesion5
{
    public partial class Form1 : Form
    {
        #region Constructor
        List<Cliente> listCliente = new List<Cliente>();
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region btnNuevo_Click
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilita(true);
        }
        #endregion

        #region btnGuardar_Click
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            listCliente.Add(getCliente());
            var source = new BindingSource();
            source.DataSource = listCliente;
            dgvResulltado.DataSource = source;
            habilita(false);
        }
        #endregion

        #region btnEliminar_Click
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtId.Text))
            {
                foreach (Cliente cliente in listCliente.Reverse<Cliente>())
                {
                    if (cliente.Id.Equals(txtId.Text))
                    {
                        listCliente.Remove(cliente);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var source = new BindingSource();
            source.DataSource = listCliente;
            dgvResulltado.DataSource = source;
        }
        #endregion

        #region btnSalir_Click
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
        #endregion

        #region habilita
        private void habilita(bool b)
        {
            btnGuardar.Enabled = b;
            btnNuevo.Enabled = !b;
            btnEliminar.Enabled = !b;
            txtId.Enabled = b;
            txtNombres.Enabled = b;
            txtApellidos.Enabled = b;
            txtCelular.Enabled = b;
            txtDireccion.Enabled = b;
            txtTelefono.Enabled = b;
            txtId.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }
        #endregion

        #region dgvResulltado_CellContentClick
        private void dgvResulltado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow rowp in dgvResulltado.Rows)
            {
                rowp.DefaultCellStyle.BackColor = Color.White;
                rowp.DefaultCellStyle.ForeColor = Color.Black;
            }
            dgvResulltado.CurrentRow.DefaultCellStyle.BackColor = Color.Maroon;
            dgvResulltado.CurrentRow.DefaultCellStyle.ForeColor = Color.White;
            setCliente((Cliente)dgvResulltado.CurrentRow.DataBoundItem);

            Cliente c = (Cliente)dgvResulltado.CurrentRow.DataBoundItem;
            txtId.Text = c.Id;
        }
        #endregion

        #region getCliente
        private Cliente getCliente()
        {
            Cliente cliente = new Cliente();
            cliente.Id = txtId.Text;
            cliente.Nombres = txtNombres.Text;
            cliente.Apellidos = txtApellidos.Text;
            cliente.Celular = txtCelular.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;
            return cliente;
        }
        #endregion

        #region setCliente
        private void setCliente(Cliente cliente)
        {
            txtId.Text = cliente.Id;
            txtNombres.Text = cliente.Nombres;
            txtApellidos.Text = cliente.Apellidos;
            txtCelular.Text = cliente.Celular;
            txtDireccion.Text = cliente.Direccion;
            txtTelefono.Text = cliente.Telefono;
        }
        #endregion
    }
}
