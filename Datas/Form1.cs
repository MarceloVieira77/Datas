using System;
using System.Windows.Forms;

namespace Datas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LimparForm();
            dtpData.Value = DateTime.Today;
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            AddDias();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void LimparForm()
        {
            lblDataFinal.Text = string.Empty;
            txtDias.Text = string.Empty;
            txtDias.Focus();
        }

        private void AddDias()
        {
            try
            {
                var dataInformada = dtpData.Value;
                var dataCalculada = dataInformada.AddDays(Convert.ToInt32(txtDias.Text));
                lblDataFinal.Text = dataCalculada.ToShortDateString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite somente números(negativos são aceitos).", "Atenção!", MessageBoxButtons.OK);
                LimparForm();
            }
            catch(Exception)
            {
                MessageBox.Show("Erro ao calcular data. Verifique o valor digitado.", "Atenção!", MessageBoxButtons.OK);
                LimparForm();
            }

        }

    }
}
