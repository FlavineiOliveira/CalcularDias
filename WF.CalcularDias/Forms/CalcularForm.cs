using CalcularDias.BLL;
using System;
using System.Windows.Forms;

namespace CalcularDias.Forms
{
    public partial class CalcularForm : Form
    {
        public CalcularForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var data = Convert.ToDateTime(mtxtData.Text);
            var minutos = Convert.ToInt32(mtxtMinutos.Text);
            var horaInicio = TimeSpan.Parse(mtxtHoraInicio.Text);
            var horaFim = TimeSpan.Parse(mtxtHoraFim.Text);
            var apenasDiasUteis = ckbDiaUtil.Checked;

            mtxtResultado.Text = BoCalculoData.Calcular(data, minutos, horaInicio, horaFim, apenasDiasUteis).ToString();
        }
    }
}
