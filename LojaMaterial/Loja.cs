using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMaterial
{
    public class Loja
    {
        //Atributos da Classe
        public string NomeLoja { get; set; }
        public int IdLoja { get; set; }
        public string EnderecoLoja { get; set; }
        private int idLoja;
        private string nomeLoja;
        private string enderecoLoja;


        public void adicionarLoja()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Loja Cadastrado com Sucesso!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("ID: " + this.IdLoja);
            Console.WriteLine("Nome: " + this.NomeLoja);
            Console.WriteLine("Endereço: " + this.EnderecoLoja);
            Console.WriteLine("---------------------------------");
            Console.ReadLine();
        }
        public Loja consultarLoja(int idLoja)
        {
            Loja loja = new Loja();
            loja.idLoja = idLoja;
            loja.nomeLoja = nomeLoja;
            loja.enderecoLoja = enderecoLoja;

            return loja;

        }
        public void atualizarLoja()
        {

        }
        public void deletarLoja(int idLoja)
        {

        }

    }
}
