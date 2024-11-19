using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo
{

    // mudar nome da interface 
    public interface IDadosDaOrganizacao
    {
        List<Veiculo> Veiculos { get; set; }
        List<Contacto> Contactos { get; set; }


    }
}
