using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public class Ocorrencia
    {
        public string Local;
        public int QuantidadeDeVitimas;
        public enum Gravidade
        {
            Leve = 1,
            Moderado = 2,
            Grave = 3,
            MuitoGrave = 4,

        };



        public enum TipoDeOcorrencia 
        {
            Incendio = 1,            
            AcidenteDeTransito = 2,  
            Assalto = 3,             
            EmergenciaMedica = 4,    
            DesastreNatural = 5,     
            Afogamento = 6,          
            Queda = 7,               
            VazamentoDeGas = 8,      
            Outros = 9

        };

        public Ocorrencia(string local, TipoDeOcorrencia tOcorrencia, int quantidadeDeVitimas, Gravidade gravidade)
        {
            Local = local;
            TipoDeOcorrencia t = tOcorrencia;
            QuantidadeDeVitimas = quantidadeDeVitimas;
            Gravidade g = gravidade;
        }

        public Gravidade AtualizarGravidade(Gravidade novagravidade)
        {
            Gravidade g = novagravidade;

            return g;

        }

        public void DetalhesOcorrencia()
        {
            // futuras implementações
        }


      
    }
}
