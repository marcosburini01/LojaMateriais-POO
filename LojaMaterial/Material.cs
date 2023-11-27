using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMaterial
{
    public class Material
    {
        private int idMaterial;
        private string nomeMaterial;
        private int qtd;
        private double valorUnitario;

        public void adicionarMaterial(int idMaterial, string nomeMaterial, int qtd, double valorUnitario)
        {
            this.idMaterial = idMaterial;
            this.nomeMaterial = nomeMaterial;
            this.qtd = qtd;
            this.valorUnitario = valorUnitario;
        }
        public Material consultarMaterial()
        {
            Material material = new Material();
            material.idMaterial = idMaterial;
            material.nomeMaterial = nomeMaterial;
            material.qtd = qtd;
            material.valorUnitario = valorUnitario;

            return material;
        }
        public void atualizarMaterial()
        {

        }
        public void deletarMaterial(int idMaterial)
        {

        }

    }
}
