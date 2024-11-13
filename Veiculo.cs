using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo
{
    public class Veiculo
    {
        #region atributos

        // tipo veiclus ,org que pretence
        private string tipoDeVeiculo;
        private string organizacaoQuePertence;
        private bool disponibilidade;
        private List<string> equipamentos;
        private int capacidadep;
        private string localizacao;



        #endregion

        #region construtor

        public Veiculo()
        {

        }
        public Veiculo(string tipoDeVeiculo, string organizacaoQuePertence,bool disponibilidade)
        {

            this.tipoDeVeiculo = tipoDeVeiculo;
            this.organizacaoQuePertence = organizacaoQuePertence;
            this.disponibilidade = disponibilidade;

        }

        

        

        #endregion

        #region Encapslulamento

            
        public string TipoDeVeiculo
        {
            get
            {
                return tipoDeVeiculo;
            }

            set
            {
                this.tipoDeVeiculo = value;
            }

        }
        public string OrganizacaoQuePertence
        {
            get
            {

                return organizacaoQuePertence;

            }

            set
            {
                this.organizacaoQuePertence = value;
            }

        }
        public bool Disponibilidade
        {
            get
            {
                return disponibilidade;
            }

            set
            {
                this.disponibilidade = value;
            }

        }

        #endregion

    }
}
