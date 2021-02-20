using CalcularDias.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WF.CalcularDiasTest
{
    [TestClass]
    public class BoCalculoDataTest
    {
        [TestMethod]
        public void CalcularDataAtualAntesDeHorarioInicioCalculandoAteHorarioFim()
        {
            var dataAtual = new DateTime(2021, 2, 20, 6, 0, 0);
            var qtdMinutos = 60;
            var horaInicio = new TimeSpan(7, 0, 0);
            var horaFim = new TimeSpan(8, 0, 0);
            var considerarApenasDiasUteis = false;

            var dataResultado = BoCalculoData.Calcular(dataAtual,
                                                       qtdMinutos,
                                                       horaInicio,
                                                       horaFim,
                                                       considerarApenasDiasUteis);

            Assert.IsTrue(dataResultado == new DateTime(2021, 2, 20, 8, 0, 0));
        }

        [TestMethod]
        public void CalcularDataAtualDentroDeHorarioInicioCalculandoDentroHorarioFim()
        {
            var dataAtual = new DateTime(2021, 2, 20, 10, 0, 0);
            var qtdMinutos = 40;
            var horaInicio = new TimeSpan(9, 0, 0);
            var horaFim = new TimeSpan(18, 0, 0);
            var considerarApenasDiasUteis = false;

            var dataResultado = BoCalculoData.Calcular(dataAtual,
                                                       qtdMinutos,
                                                       horaInicio,
                                                       horaFim,
                                                       considerarApenasDiasUteis);

            Assert.IsTrue(dataResultado == new DateTime(2021, 2, 20, 10, 40, 0));
        }

        [TestMethod]
        public void CalcularDataAtualDentroDeHorarioInicioCalculandoAteHorarioFim()
        {
            var dataAtual = new DateTime(2021, 2, 20, 14, 30, 0);
            var qtdMinutos = 210;
            var horaInicio = new TimeSpan(9, 0, 0);
            var horaFim = new TimeSpan(18, 0, 0);
            var considerarApenasDiasUteis = false;

            var dataResultado = BoCalculoData.Calcular(dataAtual,
                                                       qtdMinutos,
                                                       horaInicio,
                                                       horaFim,
                                                       considerarApenasDiasUteis);

            Assert.IsTrue(dataResultado == new DateTime(2021, 2, 20, 18, 0, 0));
        }

        [TestMethod]
        public void CalcularDataAtualAntesDeHorarioInicioCalculandoProximoDiaAteHorarioFim()
        {
            var dataAtual = new DateTime(2021, 2, 20, 7, 0, 0);
            var qtdMinutos = 902;
            var horaInicio = new TimeSpan(10, 0, 0);
            var horaFim = new TimeSpan(15, 0, 0);
            var considerarApenasDiasUteis = false;

            var dataResultado = BoCalculoData.Calcular(dataAtual,
                                                       qtdMinutos,
                                                       horaInicio,
                                                       horaFim,
                                                       considerarApenasDiasUteis);

            Assert.IsTrue(dataResultado == new DateTime(2021, 2, 23, 15, 0, 0));
        }

        [TestMethod]
        public void CalcularDataAtualAntesDeHorarioInicioCalculandoProximoDiaHorarioInicio()
        {
            var dataAtual = new DateTime(2021, 2, 20, 7, 0, 0);
            var qtdMinutos = 481;
            var horaInicio = new TimeSpan(8, 0, 0);
            var horaFim = new TimeSpan(12, 0, 0);
            var considerarApenasDiasUteis = false;

            var dataResultado = BoCalculoData.Calcular(dataAtual,
                                                       qtdMinutos,
                                                       horaInicio,
                                                       horaFim,
                                                       considerarApenasDiasUteis);

            Assert.IsTrue(dataResultado == new DateTime(2021, 2, 22, 12, 0, 0));
        }

        [TestMethod]
        public void CalcularDataAtualAposHorarioFimCalculandoProximoDiaHorarioInicio()
        {
            var dataAtual = new DateTime(2021, 2, 20, 19, 0, 0);
            var qtdMinutos = 541;
            var horaInicio = new TimeSpan(9, 0, 0);
            var horaFim = new TimeSpan(18, 0, 0);
            var considerarApenasDiasUteis = false;

            var dataResultado = BoCalculoData.Calcular(dataAtual,
                                                       qtdMinutos,
                                                       horaInicio,
                                                       horaFim,
                                                       considerarApenasDiasUteis);

            Assert.IsTrue(dataResultado == new DateTime(2021, 2, 23, 9, 0, 0));
        }

        [TestMethod]
        public void CalcularDataAtualAposHorarioFimCalculandoProximoDiaHorarioFim()
        {
            var dataAtual = new DateTime(2021, 2, 20, 19, 0, 0);
            var qtdMinutos = 2700;
            var horaInicio = new TimeSpan(9, 0, 0);
            var horaFim = new TimeSpan(18, 0, 0);
            var considerarApenasDiasUteis = false;

            var dataResultado = BoCalculoData.Calcular(dataAtual,
                                                       qtdMinutos,
                                                       horaInicio,
                                                       horaFim,
                                                       considerarApenasDiasUteis);

            Assert.IsTrue(dataResultado == new DateTime(2021, 2, 25, 17, 56, 0));
        }
    }
}
