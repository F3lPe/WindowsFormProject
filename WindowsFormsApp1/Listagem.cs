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
        int indicie;

        public static List<Pessoa> ListaPessoas { get; } = new List<Pessoa> ();

        private List<Pessoa> tableValues()
        {
            return Listagem.ListaPessoas;
        } 
        public void usuarios()
        {
            dataGridView1.DataSource = tableValues();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            usuarios();            
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Selecione uma linha para remover.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaClicada = e.RowIndex;
            indicie = linhaClicada;
            int colunaClicada = e.ColumnIndex;
            MessageBox.Show($"linha: {linhaClicada} coluna: {colunaClicada} posicao: {indicie} rowIndex: {dataGridView1.SelectedCells[0].RowIndex}");
        }
    }
}
