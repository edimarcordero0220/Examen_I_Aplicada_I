using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace Examen_I_Aplicada_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LlenarClase(Usuarios u)
        {
            //u.ClienteId = ClientetextBox.Text;
            u.Nombre = NombretextBox.Text;
            u.FechaNacimiento = FechaNacimientotextBox.Text;
            u.limiteCredit = LimiteCreditotextBox.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            LlenarClase(usuario);
            UsuariosBLL.Insertar(usuario);
            MessageBox.Show("Guardado Jevi!!");
        }
        private void NombretextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
