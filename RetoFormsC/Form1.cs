using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Entidad;
using Capa_Negocio;

namespace RetoFormsC
{
    public partial class Form1 : Form
    {
        ClassEntidad entidad = new ClassEntidad();
        ClassNegocio objnegocio = new ClassNegocio();
        public Form1()
        {
            InitializeComponent();
        }
        void mantenimiento(String accion)
        {
            entidad.codigo = txtCodigo.Text;
            entidad.titulo = txtTitulo.Text;
            entidad.editorial = txtEditorial.Text;
            entidad.autor = txtAutor.Text;
            entidad.precio = Convert.ToInt32(txtPrecio.Text);
            entidad.cantidad = Convert.ToInt32(txtCantidad.Text);
            entidad.accion = accion;
            String men = objnegocio.N_mantenimiento_libro(entidad);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiar()
        {
            txtCodigo.Text = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtEditorial.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtBucarAutor.Text = "";
            txtBuscarTitulo.Text = "";
            dataGridView1.DataSource = objnegocio.N_Listar_libros();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objnegocio.N_Listar_libros();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "")
            {
                if (MessageBox.Show("¿Desea registrar a " + txtTitulo + "?", "mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    limpiar();
                }
            }
        }

        private void btnModific_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (MessageBox.Show("¿Desea modificar a " + txtTitulo + "?", "mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (MessageBox.Show("¿Desea eliminar a " + txtTitulo + "?", "mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }
            }
        }

        private void txtBuscarTitulo_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarTitulo.Text != "")
            {
                entidad.titulo = txtBuscarTitulo.Text;
                DataTable dt = new DataTable();
                dt = objnegocio.N_Buscar_libros(entidad);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objnegocio.N_Listar_libros();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtCodigo.Text = dataGridView1[0,fila].Value.ToString();
            txtTitulo.Text = dataGridView1[1, fila].Value.ToString();
            txtEditorial.Text = dataGridView1[2, fila].Value.ToString();
            txtAutor.Text = dataGridView1[3, fila].Value.ToString();
            txtPrecio.Text = dataGridView1[4, fila].Value.ToString();
            txtCantidad.Text = dataGridView1[5, fila].Value.ToString();
        }

        private void txtBucarAutor_TextChanged(object sender, EventArgs e)
        {
            if (txtBucarAutor.Text != "")
            {
                entidad.autor = txtBucarAutor.Text;
                DataTable dt = new DataTable();
                dt = objnegocio.N_Buscar_Autor(entidad);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objnegocio.N_Listar_libros();
            }
        }
    }
}
