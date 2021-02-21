using System;

namespace CalcularDias.MethodExtensions
{
    public static class ExtensaoDatetime
    {
        public static DateTime SomarDiasUteis(this DateTime data, int qtdDias)
        {
            //  Valida se inicialmente a data já está começando no final de semana
            //  se sim, inicia o dia num dia útil e subtrai um dia da soma
            switch (data.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    data = data.AddDays(2);
                    qtdDias--;
                    break;
                case DayOfWeek.Sunday:
                    data = data.AddDays(1);
                    qtdDias--;
                    break;
            }

            while (qtdDias > 0)
            {
                switch (data.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                        data = data.AddDays(2);
                        break;
                    case DayOfWeek.Sunday:
                        data = data.AddDays(1);
                        break;
                    default:
                        {
                            data = data.AddDays(1);
                            qtdDias--;
                        }
                        break;
                }
            }

            return data;
        }
    }
}
