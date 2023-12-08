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
    public partial class Listagem : Form
    {
        public Listagem()
        {
            InitializeComponent();
            CenterToScreen();
        }
        int indicie = 0;
        string nome, email, senha;
        RegistrosForm registrosForm = new RegistrosForm();

        public static List<Pessoa> ListaPessoas { get; } = new List<Pessoa> ();
        public bool thisVisible { get; set; } = false;
        
        public List<Pessoa> dataSource()
        {
            return Listagem.ListaPessoas;
        } 
        public void usuarios()
        {
            dataGridView1.DataSource = dataSource();
        }
        public void refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataSource();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            usuarios();         
        }
        private void button_back(object sender, EventArgs e)
        {
            registrosForm.Close();
            this.Hide();
            new Menu().Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_click(object sender, EventArgs e)
        {
            Listagem.ListaPessoas.RemoveAt(indicie);
            btnRemove.Enabled = false;
            btnEditar.Enabled = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataSource();
        }

        private  void btnEdit_click(object sender, EventArgs e)
        {
            Pessoa pessoaEncontrada = Listagem.ListaPessoas[indicie];
            nome = pessoaEncontrada.nome;
            email = pessoaEncontrada.email;
            senha = pessoaEncontrada.senha;

            registrosForm = new RegistrosForm()
            {
                nome = nome,
                senha = senha,
                email = email,
                edit = true
            };

            registrosForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaClicada = e.RowIndex;
            indicie = linhaClicada;            

            if (indicie >=0)
            {
                btnRemove.Enabled = true;
                btnEditar.Enabled = true;
            } else
            {
                btnRemove.Enabled = false;
                btnEditar.Enabled = false;
            }
        }

        private void Listagem_Load(object sender, EventArgs e)
        {

        }
    }
}
