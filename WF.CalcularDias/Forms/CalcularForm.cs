using CalcularDias.BLL;
using System;
using System.Text.RegularExpressions;
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
            try
            {
                Criticar();

                var data = Convert.ToDateTime(mtxtData.Text);
                var minutos = Convert.ToInt32(mtxtMinutos.Text);
                var horaInicio = TimeSpan.Parse(mtxtHoraInicio.Text);
                var horaFim = TimeSpan.Parse(mtxtHoraFim.Text);
                var apenasDiasUteis = ckbDiaUtil.Checked;

                mtxtResultado.Text = BoCalculoData.Calcular(data, minutos, horaInicio, horaFim, apenasDiasUteis).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Criticar()
        {
            if (!FormatoDataIsValido(mtxtData.Text))
                throw new Exception("Data está no formato inválido.");

            int.TryParse(mtxtMinutos.Text, out int minutos);

            if(minutos < 1)
                throw new Exception("Minutos está inválido.");

            if (!FormatoHoraIsValido(mtxtHoraInicio.Text))
                throw new Exception("Hora inicial está no formato inválido.");

            if (!FormatoHoraIsValido(mtxtHoraFim.Text))
                throw new Exception("Hora final está no formato inválido.");

            if(mtxtHoraInicio.Text == mtxtHoraFim.Text)
                throw new Exception("Hora inicial não pode ser igual a hora final.");
        }

        private bool FormatoDataIsValido(string data)
        {
            return Regex.IsMatch(data, @"^[0-3][0-9]/[0-1][1-9]/[1-2][0-9]{3}\s([0-1]?[0-9]|2[0-3]):[0-5][0-9]$");
        }

        private bool FormatoHoraIsValido(string hora)
        {
            return Regex.IsMatch(hora, @"^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$");
        }
    }
}
