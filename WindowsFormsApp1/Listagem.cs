using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Listagem : Form
    {
        public Listagem()
        {
            InitializeComponent();
        }
        Label labelNome = new Label();
        Label labelSenha = new Label();
        Label labelEmail = new Label();
        Pessoa usuario;

        public List<Pessoa> ListaPessoas = new List<Pessoa>();
        
        public void usuarios()
        {
            usuario = ArmazenamentoValores.ValoresCriados.Find(e => e.id == 0);
            labelNome.Text = usuario.nome;
            labelSenha.Text = usuario.email;
            labelEmail.Text = usuario.senha;
            tabelaRegistros.Controls.Add(labelNome, 0, 1);
            tabelaRegistros.Controls.Add(labelSenha, 1, 1);
            tabelaRegistros.Controls.Add(labelEmail, 2, 1);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            usuarios();            
            // Coloque o código que deseja executar quando o formulário é carregado aqui
        }

        private void button_back(object sender, EventArgs e)
        {
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
            int index = ArmazenamentoValores.ValoresCriados.FindIndex(item => item.id == 0);
            Debug.WriteLine($"{index}");
            ArmazenamentoValores.ValoresCriados.RemoveAt(index);
            Console.ReadLine();             
        }
    }
}
