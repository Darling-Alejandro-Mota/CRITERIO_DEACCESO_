using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server =DESKTOP-C55CHJN ;database= Inicio_de_Sesion ; integrated security = true");
            conexion.Open();
            string Nombre = txt_nombre.Text;
            string Apellido = txt_apellido.Text;
            string Cedula = txt_cedula.Text;
              string Telefono = txt_telefono.Text;

            string cadena = "insert into cliente (Nombre, Apellido, Cedula,  Telefono) values('" + Nombre + "','" + Apellido + "','" + Cedula + "','" + Telefono + "')";


            SqlCommand comando = new SqlCommand(cadena, conexion); comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");

            conexion.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
