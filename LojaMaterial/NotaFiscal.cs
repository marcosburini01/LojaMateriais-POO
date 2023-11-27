using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMaterial
{
    public class NotaFiscal
    {
        private int idNotaFiscal;
        private int numNotaFiscal;
        private string nomeCliente;
        private DateTime data;
        private double valorTotal;

        public void adicionarNotaFiscal(int idNotaFiscal, int numNotaFiscal, string nomeCliente, DateTime data, double valorTotal)
        {
            this.data = data;
            this.valorTotal = valorTotal;
            this.nomeCliente = nomeCliente;
            this.idNotaFiscal = idNotaFiscal;
            this.numNotaFiscal = numNotaFiscal;
        }
        public NotaFiscal consultarNotaFiscal()
        {
            NotaFiscal notaFiscal = new NotaFiscal();
            notaFiscal.idNotaFiscal = idNotaFiscal;
            notaFiscal.numNotaFiscal = numNotaFiscal;
            notaFiscal.nomeCliente = nomeCliente;
            notaFiscal.data = data;
            notaFiscal.valorTotal = valorTotal;
            return notaFiscal;
        }
        public void atualizarNotaFiscal()
        {

        }
        public void deletarNotaFiscal(int idNotaFiscal)
        {

        }

    }
}
