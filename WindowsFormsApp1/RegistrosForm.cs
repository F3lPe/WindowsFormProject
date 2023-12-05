using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegistrosForm : Form
    {
        public RegistrosForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(fullName.Text == "" || password.Text == "" || email.Text == ""){
                fullNameWarning.Visible = true;
                senhaWarning.Visible = true;
                emailWarning.Visible = true;

            } else
            {
                fullNameWarning.Visible = false;
                senhaWarning.Visible = false;
                emailWarning.Visible = false;

                int id = 0;
                
                Pessoa pessoa = new Pessoa { nome = fullName.Text, senha = password.Text, email = email.Text ,id = id++};
                Listagem.ListaPessoas.Add(pessoa);

                fullName.Text = "";
                password.Text = "";
                email.Text = "";
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
