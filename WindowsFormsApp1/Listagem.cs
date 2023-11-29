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
        public static List<string> userValues { get; set; }
        public string usuarios()
        {            
            return userValues[0];
        }

        public string ValorDoTextBox
        {
            get { return textBox1.Text; }
        }
        public Listagem()
        {
            InitializeComponent();
        }
      
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button_back(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }
    }
}
