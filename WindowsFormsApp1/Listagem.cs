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
        }

        public static List<Pessoa> ListaPessoas { get; } = new List<Pessoa> ();

        private List<Pessoa> tableValues()
        {
            return Listagem.ListaPessoas;
        } 
        public void usuarios()
        {
            dataGridView1.DataSource = tableValues();
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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
