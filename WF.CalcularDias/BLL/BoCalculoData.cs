using CalcularDias.MethodExtensions;
using System;

namespace CalcularDias.BLL
{
    public class BoCalculoData
    {
        public static DateTime Calcular(DateTime dataAtual, int qtdMinutos, TimeSpan horaInicio, TimeSpan horaFim, bool considerarApenasDiasUteis)
        {
            DateTime primeiraDataValida;

            if ((dataAtual.Hour >= horaInicio.Hours && dataAtual.Hour <= horaFim.Hours) ||
                (dataAtual.Hour == horaFim.Hours && dataAtual.Minute <= horaFim.Minutes))
            {
                //  Data atual está dentro do horário definido como inicial e final

                primeiraDataValida = dataAtual;
            }
            else if((dataAtual.Hour < horaInicio.Hours) ||
                    (dataAtual.Hour == horaInicio.Hours && dataAtual.Minute <= horaInicio.Minutes))
            {
                //  Data atual está fora do horário definido como início, então considera o horário mínimo configurado
                //  para a primeira data válida

                primeiraDataValida = new DateTime(dataAtual.Year,
                                                  dataAtual.Month,
                                                  dataAtual.Day,
                                                  horaInicio.Hours,
                                                  horaInicio.Minutes,
                                                  0);
            }
            else
            {
                if (considerarApenasDiasUteis)
                    primeiraDataValida = dataAtual.SomarDiasUteis(1);
                else
                    primeiraDataValida = dataAtual.AddDays(1);
            }

            var dataReferenciaInicio = new DateTime(primeiraDataValida.Year,
                                                    primeiraDataValida.Month,
                                                    primeiraDataValida.Day,
                                                    horaInicio.Hours,
                                                    horaInicio.Minutes,
                                                    0);

            var dataReferenciaFim = new DateTime(primeiraDataValida.Year,
                                                 primeiraDataValida.Month,
                                                 primeiraDataValida.Day,
                                                 horaFim.Hours,
                                                 horaFim.Minutes,
                                                 0);

            var dataAuxiliarRetorno = primeiraDataValida.AddMinutes(qtdMinutos);

            //  Valida se os minutos somados não ultrapassam o intervalo de período
            //  de um dia
            if (dataAuxiliarRetorno >= dataReferenciaInicio
                &&
                dataAuxiliarRetorno <= dataReferenciaFim
                &&
                (dataAuxiliarRetorno.Hour > horaInicio.Hours ||
                    (dataAuxiliarRetorno.Hour == horaInicio.Hours &&
                     dataAuxiliarRetorno.Minute >= horaInicio.Minutes)) &&
                     (dataAuxiliarRetorno.Hour < horaFim.Hours ||
                     (dataAuxiliarRetorno.Hour == horaFim.Hours && dataAuxiliarRetorno.Minute <= horaFim.Minutes)))
            {
                return dataAuxiliarRetorno;
            }
            else
            {
                var minutosPeriodo = ((horaFim.Hours - horaInicio.Hours) * 60) - (horaFim.Minutes - horaInicio.Minutes);

                int qtdDiasMinutos = 0;

                while((qtdMinutos - minutosPeriodo) > -1)
                {
                    qtdDiasMinutos++;

                    qtdMinutos -= minutosPeriodo;

                    if (qtdMinutos > 1)
                        qtdMinutos--;    
                }

                int minutosExcedentes = qtdMinutos;

                dataAuxiliarRetorno = dataReferenciaInicio;

                if(minutosExcedentes == 0)
                {
                    dataAuxiliarRetorno = dataReferenciaFim;
                }
                else if (minutosExcedentes == 1)
                {
                    if (considerarApenasDiasUteis)
                        dataAuxiliarRetorno = dataAuxiliarRetorno.SomarDiasUteis(1);
                    else
                        dataAuxiliarRetorno = dataAuxiliarRetorno.AddDays(1);

                    minutosExcedentes--;
                }

                if (considerarApenasDiasUteis)
                    dataAuxiliarRetorno = dataAuxiliarRetorno.SomarDiasUteis(qtdDiasMinutos);
                else
                    dataAuxiliarRetorno = dataAuxiliarRetorno.AddDays(qtdDiasMinutos);

                dataAuxiliarRetorno = dataAuxiliarRetorno.AddMinutes(minutosExcedentes);

                return dataAuxiliarRetorno;
            }
        }
    }
}
