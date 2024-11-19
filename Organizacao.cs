using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo
{
    public class Organizacao : IDadosDaOrganizacao
    {
        #region atributos 

        private string tipoDaOrganizacao;

        private bool disponibilidade;

        private List<Contacto> contactos = new List<Contacto>() { };

        private List<Veiculo> veiculos = new List<Veiculo>() { };

        #endregion

        #region encapsulamento

        public List<Contacto> Contactos
        {
            get
            {
                return contactos;
            }
            set
            {
                this.contactos = value;
            }
        }

        public List<Veiculo> Veiculos
        {
            get
            {
                return veiculos;
            }

            set
            {
                this.veiculos = value;
            }


        }

        public string TipoDaOrganizacao
        {
            get
            {
                return tipoDaOrganizacao;
            }

            set
            {
                this.tipoDaOrganizacao = value;
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

        //inem ??

        #endregion

        #region metodos
        bool disponival()
        {
            return true;
        }

        void ir_com_veiculo(string tipo_de_ocrencia)
        {

        }

        #endregion






    }
}
