using System.Runtime.InteropServices.Marshalling;
using Acao_12_09.Classes;

string opcao = "";
do{
Console.WriteLine(@"

1 - Cadastrar PJ
2 - Sair

");

opcao = Console.ReadLine();

if (opcao == "1"){
PessoaJuridica pj = new PessoaJuridica();

Console.WriteLine("Digite o nome da Empresa");
pj.Nome = Console.ReadLine();

Console.WriteLine("Digite o rendimento da Empresa");
pj.Rendimento = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o CNPJ da Empresa");
pj.CNPJ = Console.ReadLine();

pj.Inserir(pj);

}
}while (opcao != "2");


