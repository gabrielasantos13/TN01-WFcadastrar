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
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
            cbxEscolaridade.SelectedIndex = 0;
        }
        private void limparFormulario()
        {
            txtNomeCompleto.Clear();
            mkdTelefone.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            cbxEscolaridade.SelectedIndex = 0;
            rdbMasculino.Checked = false;
            rdbFeminino.Checked = false;
            rdbNaoInformar.Checked = false;
            nudRendaMensal.Value = 0;
            chkPossuiFilhos.CheckState = CheckState.Indeterminate;
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa();
            p1.NomeCompleto = txtNomeCompleto.Text;
            p1.DddTelefone = mkdTelefone.Text;
            p1.DataNascimento = dtpDataNascimento.Value;
            p1.Escolaridade = cbxEscolaridade.Text;
            p1.RendaMensal = Convert.ToDouble(nudRendaMensal.Text);
            p1.Sexo = 'n';
            p1.PossuiFilhos = chkPossuiFilhos.Checked;
            if (rdbMasculino.Checked)
            {
                p1.Sexo = 'm';
            }
            else if (rdbFeminino.Checked)
            {
                p1.Sexo = 'f';
            }
            else if (rdbNaoInformar.Checked)
            {
                p1.Sexo = 'n';
            }
            else
            {
                MessageBox.Show("o sexo não definido");
                return;
            }
            if (chkPossuiFilhos.CheckState == CheckState.Unchecked)
            {
                p1.PossuiFilhos = true;
            }
            else if (!chkPossuiFilhos.Checked)
            {
                p1.PossuiFilhos = false;
            }
            else
            {
                MessageBox.Show("faltou marcar se tem filhos");
                return;
            }

            Pessoa.ListaPessoas.Add(p1);

            MessageBox.Show("cadastro realizado com sucesso!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
