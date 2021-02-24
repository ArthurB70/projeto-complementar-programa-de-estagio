using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_complementar_programa_de_estagio.models.Calculo
{
    public class CalculaHorasTotais
    {
        public static double CalculaHoras(Veiculo veiculo) =>
            (veiculo.DataSaida - veiculo.DataEntrada).TotalHours;
    }
}
