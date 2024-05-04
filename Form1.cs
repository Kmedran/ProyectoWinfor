using ProyectoWinfor.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoWinfor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Bienvenido a mi App");
        }

        private void botonpru_Click(object sender, EventArgs e)
        {
         
        }

        private void comboBoxFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistro reg = new FrmRegistro();
            reg.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String usr = textBox1.Text.ToLower();
            String pwd = textBox2.Text.ToLower();

            if (usr == null || pwd == null)
            {
                MessageBox.Show("No puede Ingresar");
                
            }else
            {
                if (usr.Equals("admin") && pwd.Equals("admin"))
                {
                    
                    FrmRegistro registro = new FrmRegistro();
                    registro.Show();
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("Usuario y Contraseña Erroneos");
                    
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
