using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_complementar_programa_de_estagio
{
    public class VeiculoMotocicleta : Veiculo
    {
        public VeiculoMotocicleta(string placaVeiculo, string tipoVeiculo, DateTime dataEntrada)
            : base(placaVeiculo, tipoVeiculo, dataEntrada)
        {
        }
    }
}
