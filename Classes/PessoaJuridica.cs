using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acao_12_09.Classes
{
    public class PessoaJuridica : Pessoa
    {
        public string? CNPJ { get; set; }
        
        
        public void Inserir(PessoaJuridica pj){
            using (StreamWriter sw = new StreamWriter(pj.Nome + ".txt")){
                sw.WriteLine($" A empresa com o CNPJ:{pj.CNPJ}, possui o nome de {pj.Nome} e tem um rendimento de {pj.Rendimento}");
            }
        }
    }
}