using System;
using System.Text.RegularExpressions;

namespace CadastroDeClientes.Propriedades.ValidacaoDeEntradas {
    public class EntradaOperacao {
        public static string EntradaFormatada() 
        {
            // Classe responsável por formatar a decisao do usuario, evitando erros por char diferentes!.
            bool validacao = false;
            string operacaoFormatada = "";

            do
            {
                string auxiliarOperaçao = Console.ReadLine();
                auxiliarOperaçao = Regex.Replace(auxiliarOperaçao, @"[^\p{L}]", "").ToLower();
                Console.WriteLine();

                if (auxiliarOperaçao == "encerrar" || auxiliarOperaçao == "incluir" || auxiliarOperaçao == "pesquisar"
                    || auxiliarOperaçao == "alterar" || auxiliarOperaçao == "excluir")
                {
                    operacaoFormatada = auxiliarOperaçao;
                    validacao = true;
                }
                else
                {
                    Console.WriteLine("Opçao inexistente.");
                    Console.Write("Digite novamente: ");
                }
            } while (!validacao);
            return operacaoFormatada;
        }
    }
}
