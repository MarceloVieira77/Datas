using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            limparForm();
            dtpData.Value = DateTime.Today;
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            calculaData();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparForm();
        }

        private void limparForm()
        {
            //dtpData.Value = DateTime.Today;
            lblDataFinal.Text = string.Empty;
            txtDias.Text = string.Empty;
            txtDias.Focus();
        }

        private void calculaData()
        {
            try
            {
                var dataInformada = dtpData.Value;
                var dataCalculada = dataInformada.AddDays(int.Parse(txtDias.Text));
                lblDataFinal.Text = dataCalculada.ToShortDateString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite somente números.", "Atenção!", MessageBoxButtons.OK);
                limparForm();
            }
            catch(Exception)
            {
                MessageBox.Show("Erro ao calcular data. Verifique o valor digitado.", "Atenção!", MessageBoxButtons.OK);
                limparForm();
            }

        }

    }
}
