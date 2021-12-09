using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace aplicacionContactosDB
{
    public partial class Form1 : Form
    {

        SqlConnection conexionDB = new SqlConnection("Data Source = localhost; Initial Catalog = Contactos; Integrated Security = True");
        string idEditar;
        string idUsuario;
        string idEditarAficion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexionDB.Open();
            SqlCommand comando = new SqlCommand("SELECT * FROM contactos;", conexionDB);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            /*DataGridViewButtonColumn columna = new DataGridViewButtonColumn();
            columna.HeaderText = "Borrar";
            columna.Width = 100;
            dataGridView1.Columns.Add(columna);*/
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;

            if (nombre != "" && telefono != "")
            {
                SqlCommand comando = new SqlCommand("INSERT INTO contactos VALUES ('" + nombre + "', '" + telefono + "');", conexionDB);
                int r = comando.ExecuteNonQuery();
                SqlCommand comand = new SqlCommand("SELECT * FROM contactos;", conexionDB);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comand;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
                txtNombre.Text = "";
                txtTelefono.Text = "";
            }
            else
            {
                MessageBox.Show("Tienes que rellenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM contactos;", conexionDB);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            /*SqlCommand comando = new SqlCommand("DELETE FROM usuarios WHERE nombre = '" + txtNombre.Text + "' AND telefono = '" + txtTelefono.Text + "'", conexionDB);
            int r = comando.ExecuteNonQuery();
            SqlCommand comand = new SqlCommand("SELECT * FROM usuarios;", conexionDB);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comand;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;*/
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                //int row = e.RowIndex;
                string idBorrar = fila.Cells[3].Value.ToString();
                SqlCommand comando = new SqlCommand("DELETE FROM contactos WHERE id = '" + idBorrar + "'", conexionDB);
                int r = comando.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand("DELETE FROM aficiones WHERE usuario_id = '" + idBorrar + "'", conexionDB);
                int q = cmd.ExecuteNonQuery();
                SqlCommand comand = new SqlCommand("SELECT * FROM contactos;", conexionDB);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comand;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
                SqlCommand comanded = new SqlCommand("SELECT * FROM aficiones WHERE usuario_id = '" + idBorrar + "';", conexionDB);
                SqlDataAdapter adaptader = new SqlDataAdapter();
                adaptader.SelectCommand = comanded;
                DataTable table = new DataTable();
                adaptader.Fill(table);
                DataGridViewAficiones.DataSource = table;
            }
            if (e.ColumnIndex == 1)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                string id = fila.Cells[3].Value.ToString();
                string query = "SELECT nombre FROM contactos WHERE id = '" + id + "'";
                SqlCommand comando = new SqlCommand(query, conexionDB);
                string nombre = comando.ExecuteScalar().ToString();
                SqlCommand comand = new SqlCommand("SELECT telefono FROM contactos WHERE id = '" + id + "'", conexionDB);
                string telefono = comand.ExecuteScalar().ToString();
                txtNombre.Text = nombre;
                txtTelefono.Text = telefono;
                idEditar = id;
            }
            if (e.ColumnIndex == 2)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                string id = fila.Cells[3].Value.ToString();
                SqlCommand comando = new SqlCommand("SELECT * FROM aficiones WHERE usuario_id = '" + id + "';", conexionDB);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                DataGridViewAficiones.DataSource = tabla;
                idUsuario = id;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtTelefono.Text != "")
            {
                string query = "UPDATE contactos SET nombre = '" + txtNombre.Text + "', telefono = '" + txtTelefono.Text + "' WHERE id = '" + idEditar + "'";
                SqlCommand comando = new SqlCommand(query, conexionDB);
                int r = comando.ExecuteNonQuery();
                SqlCommand comand = new SqlCommand("SELECT * FROM contactos;", conexionDB);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comand;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
                txtNombre.Text = "";
                txtTelefono.Text = "";
            }
            else
            {
                MessageBox.Show("Tienes que rellenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtTelefono.Text != "")
            {
                string query = "DELETE FROM contactos WHERE nombre = '" + txtNombre.Text + "' AND telefono ='" + txtTelefono.Text + "'";
                SqlCommand comando = new SqlCommand(query, conexionDB);
                int r = comando.ExecuteNonQuery();
                txtNombre.Text = "";
                txtTelefono.Text = "";
                SqlCommand comand = new SqlCommand("SELECT * FROM contactos;", conexionDB);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comand;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            else
            {
                MessageBox.Show("Tienes que rellenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///AFICIONES///

        private void btnInsertarAficion_Click(object sender, EventArgs e)
        {
            if (txtNombreAficion.Text != "")
            {
                string query = "INSERT INTO aficiones VALUES('" + txtNombreAficion.Text + "', '" + idUsuario + "');";
                SqlCommand comando = new SqlCommand(query, conexionDB);
                int r = comando.ExecuteNonQuery();
                SqlCommand comand = new SqlCommand("SELECT * FROM aficiones WHERE usuario_id = '" + idUsuario + "';", conexionDB);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comand;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                DataGridViewAficiones.DataSource = tabla;
            } 
            else
            {
                MessageBox.Show("Tienes que rellenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescarAficion_Click(object sender, EventArgs e)
        {
            SqlCommand comand = new SqlCommand("SELECT * FROM aficiones WHERE usuario_id = '" + idUsuario + "';", conexionDB);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comand;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DataGridViewAficiones.DataSource = tabla;
        }

        private void DataGridViewAficiones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow fila = DataGridViewAficiones.Rows[e.RowIndex];
                string idBorrar = fila.Cells[2].Value.ToString();
                SqlCommand comando = new SqlCommand("DELETE FROM aficiones WHERE id = '" + idBorrar + "'", conexionDB);
                int r = comando.ExecuteNonQuery();
                SqlCommand comand = new SqlCommand("SELECT * FROM aficiones WHERE usuario_id = '" + idUsuario + "';", conexionDB);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comand;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                DataGridViewAficiones.DataSource = tabla;
            }
            if(e.ColumnIndex == 1)
            {
                DataGridViewRow fila = DataGridViewAficiones.Rows[e.RowIndex];
                string id = fila.Cells[2].Value.ToString();
                string query = "SELECT aficion FROM aficiones WHERE id = '" + id + "'";
                SqlCommand comando = new SqlCommand(query, conexionDB);
                string nombre = comando.ExecuteScalar().ToString();
                txtNombreAficion.Text = nombre;
                idEditarAficion = id;
            }
        }

        private void btnActualizarAficion_Click(object sender, EventArgs e)
        {
            if (txtNombreAficion.Text != "")
            {
                string query = "UPDATE aficiones SET aficion = '" + txtNombreAficion.Text + "' WHERE id = '" + idEditarAficion + "';";
                SqlCommand comando = new SqlCommand(query, conexionDB);
                int r = comando.ExecuteNonQuery();
                SqlCommand comand = new SqlCommand("SELECT * FROM aficiones WHERE usuario_id = '" + idUsuario + "';", conexionDB);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comand;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                DataGridViewAficiones.DataSource = tabla;
            }
            else
            {
                MessageBox.Show("Tienes que rellenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
