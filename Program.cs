using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Veiculo> dunas = new List<Veiculo>() { };
         
            dunas.Add(new Veiculo("carro","Taipca",true));
            dunas.Add(new Veiculo("penis", "Taipca", false));

            Console.WriteLine("a organização que pertence e {0},o veiculo e {1},disponibelidade {2} ", dunas[1].OrganizacaoQuePertence, dunas[1].TipoDeVeiculo, dunas[1].Disponibilidade);

        }
    }
}
