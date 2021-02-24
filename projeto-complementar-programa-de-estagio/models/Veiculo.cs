using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_complementar_programa_de_estagio
{
    public abstract class Veiculo
    {
        public string PlacaVeiculo { get; protected set; }
        public string TipoVeiculo { get; protected set; }
        public DateTime DataEntrada { get; protected set; }
        public DateTime DataSaida { get; protected set; }
        public float ValorPago { get; protected set; }

        public Veiculo(string placaVeiculo, string tipoVeiculo, DateTime dataEntrada)
        {
            PlacaVeiculo = placaVeiculo;
            TipoVeiculo = tipoVeiculo;
            DataEntrada = dataEntrada;
            DataSaida = DateTime.Parse("00/00/0000");
            ValorPago = 0;
        }
        public DateTime UpdateDataSaida(DateTime novaDataSaida)
        {
            DateTime ultimaDataSaida = DataSaida;
            DataSaida = novaDataSaida;
            return ultimaDataSaida;
        }
        public float UpdateValorPago(float novoValor)
        {
            float ultimoValor = ValorPago;
            ValorPago = novoValor;
            return ultimoValor;
        }
    }
}
