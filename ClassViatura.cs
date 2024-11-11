using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP
{
    internal class Viatura
    {//para identificarf exatamente a viatura em questão
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public int CapacidadeDeIndividuos { get; set; }
        //capacidade de individuos por veiculol
        public string TipoDeVeiculo { get; set; }
        //para saber qual a viatura a ser eviada (ambulancias, bombeiros, policias)
        public string Equipamentos { get; set; }
        //equipamentos especificos necessarios na viatura
        public (double, double) LocalizacaoAtual { get; set; }
        //localizaçao atual da viatura, critério para a esolha da
        //viatura em caso de emergencia (latitude e longitude)
        public string Status { get; set; }
        //indica se a viatura está disponivel ou em utilização

        
        public Viatura(string modelo, string marca, int ano, int capacidadeDeIndividuos, string tipoDeVeiculo, string equipamentos, (double, double) localizacaoAtual, string status)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            CapacidadeDeIndividuos = capacidadeDeIndividuos;
            TipoDeVeiculo = tipoDeVeiculo;
            Equipamentos = equipamentos;
            LocalizacaoAtual = localizacaoAtual;
            Status = status;

        }



    }
}

