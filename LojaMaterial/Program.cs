
#region Pagina_Inicial
using LojaMaterial;
using System.Runtime.CompilerServices;
Tela tela = new Tela();
string opcao;
#endregion

#region Listas_de_Dados
List<Empregado> empregados = new List<Empregado>();
List<Loja> lojas = new List<Loja>();
List<Material> materiais = new List<Material>();

List<string> menuPrincipal = new List<string>();
menuPrincipal.Add("1 - Cadastrar Empregado");
menuPrincipal.Add("2 - Cadastrar Loja     ");
menuPrincipal.Add("3 - Cadastrar Material ");
menuPrincipal.Add("4 - Cadastrar Nota Fiscal ");
menuPrincipal.Add("0 - Sair        ");
#endregion

#region Principal
tela.configurarTela();

while (true)
{
    tela.montarTelaSistema();
    opcao = tela.mostrarMenu(menuPrincipal, 24, 6);
    switch (opcao)
    {
        case "1":
            Console.Clear();
            empregados.Add(cadastrarFuncionario());
            break;
        case "2":
            Console.Clear();
            lojas.Add(cadastrarLoja());
            break;
        case "3":

            break;
        case "4":

            break;
        default:

            break;

    }
    if (opcao == "0") break;
    //if (opcao == "1") 
}
//tela.montarMoldura(5,5,40,10);
//tela.montarMoldura(10,7,50,20);
Console.Clear();
#endregion

#region Cadastro_Empregado
Empregado cadastrarFuncionario()
{
    Empregado empregado = new Empregado();
    Console.WriteLine("Digite o Nome:");
    empregado.Nome = Console.ReadLine();
    Console.WriteLine("Digite o Salario:");
    empregado.Salario = double.Parse(Console.ReadLine());
    Console.Clear();
    empregado.IdEmpregado = empregados.Count();
    empregado.adicionarEmpregado();


    return empregado;

}


#endregion

#region Cadastro_Loja
Loja cadastrarLoja()
{
    Loja loja = new Loja();
    Bd_Lojas bdLojas = new Bd_Lojas("caminho/do/arquivo.txt");
    Console.WriteLine("Digite o nome(Loja):");
    loja.NomeLoja = Console.ReadLine();
    Console.WriteLine("Digite Endereço:");
    loja.EnderecoLoja = Console.ReadLine();
    Console.Clear();
    loja.IdLoja = lojas.Count();
    loja.adicionarLoja();
    // Gravar dados no arquivo
    bdLojas.GravarDados(loja);


    return loja;

}


#endregion