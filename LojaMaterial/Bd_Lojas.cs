using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMaterial
{
    using System;
    using System.IO;

    public class Bd_Lojas
    {
        
        private string filePath;

        public Bd_Lojas(string arquivo)
        {
            filePath = arquivo;

            // Verificar se o arquivo existe e criar se não existir
            if (!File.Exists(filePath))
            {
                CriarNovoArquivo();
            }
        }

        public void GravarDados(Loja loja)
        {
            //loja.adicionarLoja();
            // Adicionar dados ao arquivo (sem substituir o conteúdo existente)
            File.AppendAllText(filePath, loja.NomeLoja + Environment.NewLine);
            File.AppendAllText(filePath, loja.EnderecoLoja + Environment.NewLine);
            File.AppendAllText(filePath, loja.IdLoja + Environment.NewLine);
        }

        public string LerDados()
        {
            // Ler todos os dados do arquivo
            return File.ReadAllText(filePath);
        }

        public void EditarDados()
        {
            Loja loja = new Loja();
            // Sobrescrever todos os dados do arquivo com os novos dados
            File.WriteAllText(filePath, loja.NomeLoja);
            File.WriteAllText(filePath, loja.EnderecoLoja);
        }

        public void ExcluirArquivo()
        {
            // Excluir o arquivo
            File.Delete(filePath);
        }

        private void CriarNovoArquivo()
        {
            // Criar um novo arquivo vazio
            File.WriteAllText(filePath, string.Empty);
        }
    }
}