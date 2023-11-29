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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button_registros(Object sander, EventArgs e)
        {
            new Listagem().Show();
            this.Hide();
        }
        private void button_criar(Object sander, EventArgs e)
        {
            new RegistrosForm().Show();
            this.Hide();
        }
        private void button_editar(Object sander, EventArgs e)
        {

        }
    }
}
