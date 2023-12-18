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
        public string nome { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public bool edit { get; set; } = false;
        public int indicie { get; set; }
        public RegistrosForm()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private static int id = 0;
        Pessoa pessoa = new Pessoa();

        private void button1_Click(object sender, EventArgs e)
        {            
            if (edit == false)
            {
                if (txtfullName.Text == "" || txtPassword.Text == "" || txtEmail.Text == "")
                {
                    fullNameWarning.Visible = true;
                    senhaWarning.Visible = true;
                    emailWarning.Visible = true;
                }
                else
                {
                    edit = false;
                    fullNameWarning.Visible = false;
                    senhaWarning.Visible = false;
                    emailWarning.Visible = false;
                    id += 1;

                    pessoa = new Pessoa { nome = txtfullName.Text, senha = txtPassword.Text, email = txtEmail.Text, id = id };
                    Listagem.ListaPessoas.Add(pessoa);

                    txtfullName.Text = "";
                    txtPassword.Text = "";
                    txtEmail.Text = "";
                } 
            }else if (edit == true)
            {               
                pessoa = Listagem.ListaPessoas[indicie];
                pessoa.nome = txtfullName.Text;
                pessoa.email = txtEmail.Text;
                pessoa.senha = txtPassword.Text;
                new Listagem().RefreshData();
                new Listagem().Show();


                MessageBox.Show("Valores editados");
                
             

                this.Hide();                
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            if (edit == true)
            {                
                txtfullName.Text = nome;
                txtPassword.Text = senha;
                txtEmail.Text = email;                
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(edit == false)
            {
                this.Hide();
                new Menu().Show();

            } else
            {
                this.Hide();
                new Listagem().Show();
            }            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
