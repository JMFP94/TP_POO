using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo
{
    public class Bombeiro : IdadosObrigatorios
    {
        #region atributos 

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

        //inem ??

        #endregion

    }
}
