using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_complementar_programa_de_estagio.repositories
{
    public class RepositorioVeiculosEstacionados
    {
        List<Veiculo> listaVeiculosEstacionados;
        public RepositorioVeiculosEstacionados()
        {
            listaVeiculosEstacionados = new List<Veiculo>();
        }
        public bool InsertVeiculo(Veiculo veiculo)
        {
            if (listaVeiculosEstacionados.Contains(veiculo))
            {
                return false;
            }
            listaVeiculosEstacionados.Add(veiculo);
            return true;
        }
        public Veiculo DeleteVeiculo(Veiculo veiculo) /*CORRIGIR*/
        {
           var retorno_veiculo =  ConsultaVeiculo(veiculo);
            if(retorno_veiculo != null)
            {
                listaVeiculosEstacionados.Remove(retorno_veiculo);
                return retorno_veiculo;               
            }
            retorno_veiculo.UpdatePlacaVeiculo("");
            return retorno_veiculo;
        }
        public List<Veiculo> ConsultaTodosVeiculos()
        {
            return listaVeiculosEstacionados;
        }
        public Veiculo ConsultaVeiculo(Veiculo veiculo)
        {
            return listaVeiculosEstacionados.FirstOrDefault(x => x.Codigo == veiculo.Codigo);
        }

        public Veiculo AtualizaVeiculo(Veiculo veiculo)
        {
            Veiculo ultimoVeiculo = veiculo;
            return ultimoVeiculo;
        }
    }
}
