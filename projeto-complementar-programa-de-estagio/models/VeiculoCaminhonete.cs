using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_complementar_programa_de_estagio
{
    public class VeiculoCaminhonete : Veiculo
    {
        public VeiculoCaminhonete(string placaVeiculo, string tipoVeiculo, DateTime dataEntrada)
            : base(placaVeiculo, tipoVeiculo, dataEntrada)
        {
        }
    }
}
