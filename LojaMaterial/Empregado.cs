using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMaterial
{
    public class Empregado
    {
        //Atributos da Classe
        public string Nome { get; set; }
        public int IdEmpregado { get; set; }
        public double Salario { get; set; }
        private int idEmpregado;
        private string nome;
        private double salario;


        public void adicionarEmpregado()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Empregado Cadastrado com Sucesso!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("ID: " + this.IdEmpregado);
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Salario: " + this.Salario);
            Console.WriteLine("---------------------------------");
            Console.ReadLine();
        }
        public Empregado consultarEmpregado(int idEmpregado)
        {
            Empregado empregado = new Empregado();
            empregado.idEmpregado = idEmpregado;
            empregado.nome = nome;
            empregado.salario = salario;

            return empregado;

        }
        public void atualizarEmpregado()
        {

        }
        public void deletarEmpregado(int idEmpregado)
        {

        }

    }
}
