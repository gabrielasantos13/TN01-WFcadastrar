using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01_WFcadastrar
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrar form = new FormCadastrar();
            form.ShowDialog();
        }
    }
}
