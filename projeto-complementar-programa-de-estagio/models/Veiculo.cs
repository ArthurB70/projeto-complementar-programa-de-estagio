using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_complementar_programa_de_estagio
{
    public abstract class Veiculo
    {
        public int Codigo { get; protected set; } 
        public string PlacaVeiculo { get; protected set; }
        public string TipoVeiculo { get; protected set; }
        public DateTime DataEntrada { get; protected set; }
        public DateTime DataSaida { get; protected set; }
        public float ValorPago { get; protected set; }

        public Veiculo(int codigo, string placaVeiculo, string tipoVeiculo, DateTime dataEntrada)
        {
            Codigo = codigo;
            PlacaVeiculo = placaVeiculo;
            TipoVeiculo = tipoVeiculo;
            DataEntrada = dataEntrada;
            DataSaida = DateTime.Parse("00/00/0000");
            ValorPago = 0;
        }
        public string UpdatePlacaVeiculo(string novaPlacaVeiculo)
        {
            string ultimaPlacaVeiculo = novaPlacaVeiculo;
            PlacaVeiculo = novaPlacaVeiculo;
            return ultimaPlacaVeiculo;
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
