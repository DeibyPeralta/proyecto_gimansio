using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace WindowsFormsApp1
{
    public partial class Usuarios : Form
    {
        Deportistas usuario = new Deportistas();
        databaseService servicio = new databaseService();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!textBox.Equals(string.Empty))
                {
                    usuario.Identificacion = textBox.Text;
                    usuario.Nombre = textBox1.Text;
                    usuario.Apellido = textBox2.Text;
                    usuario.Direccion = textBox3.Text;
                    usuario.Telefono = textBox4.Text;
                    usuario.Fecha_inscripcion = textBox5.Text;
                    usuario.Genero = textBox6.Text;

                    limpiar();
                    servicio.Guardar(usuario);

                    /*
                    empleado.Nombre = Txt_Nombre.Text;
                    empleado.Apellido = Txt_Apellido.Text;
                    empleado.Sueldo = Convert.ToDecimal(Txt_Sueldo.Text);
                    empleado.Identificacion = Txt_Identificacion.Text;

                    servicio.Guardar(empleado);

                    Limpiar();
                    Txt_Identificacion.Focus();
                    */
                }
                else
                {
                    MessageBox.Show("Digite una identificacion", "titulo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error " + error);
            }
        }

        public void limpiar()
        {
            textBox.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
