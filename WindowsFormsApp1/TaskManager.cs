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
    public partial class TaskManager : Form
    {
        public TaskManager()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void TaskManager_Load(object sender, EventArgs e)
        {

        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
