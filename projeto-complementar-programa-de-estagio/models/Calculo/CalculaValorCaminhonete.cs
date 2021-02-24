using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_complementar_programa_de_estagio.models.Calculo
{
    public class CalculaValorCaminhonete : ICalculaVeiculo
    {
        public float CalculaValor(Veiculo veiculo)
        {
            double totalHoras = CalculaHorasTotais.CalculaHoras(veiculo);
            if (totalHoras <= 0.25)
            {
                veiculo.UpdateValorPago(0);
                return 0;
            }
            veiculo.UpdateValorPago(((float)(3.0 + 1.5 * (Math.Ceiling(totalHoras) - 1))));
            return ((float)(3.0 + 1.5 * (Math.Ceiling(totalHoras) - 1)));
        }
    }
}

