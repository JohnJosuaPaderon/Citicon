using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Billing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm();
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            ProjectForm form = new ProjectForm();
            form.ShowDialog();
        }

        private void lblUserDisplay_Click(object sender, EventArgs e)
        {

        }

        private void HeaderText_Click(object sender, EventArgs e)
        {

        }

        private void btnDesigns_Click(object sender, EventArgs e)
        {
            DesignForm form = new DesignForm();
            form.ShowDialog();
        }
    }
}
