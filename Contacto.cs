using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo
{
    public class Contacto
    {
        #region atributo

        private string numero;
        private string organizacao;

        #endregion

        #region construtor
        public Contacto()
        {

        }

        public Contacto(string numero,string organizacao)
        {
            this.numero = numero;
            this.organizacao = organizacao;
        }

        #endregion

        #region encapsluamento

        public string Numero
        {

            get
            {
                return numero;
            }
           
            set
            {
                this.numero = value;
            }
        }
        
        public string Organizacao
        {
            get
            {
                return organizacao;
            }

            set
            {
                this.organizacao = value;
            }


        }


        #endregion

    }
}
