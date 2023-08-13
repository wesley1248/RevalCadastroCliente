using System;
using System.Text.RegularExpressions;

namespace CadastroDeClientes.Propriedades.ValidacaoDeEntradas {
    public class EntradaRua {
        public static string EntradaValida() 
        {
            // Classe respondavel pela formatação do endereço 
            Regex formato = new Regex(@"^[a-zA-Z\s,áéíóúÁÉÍÓÚãõÃÕçÇ]*$"); // Formato Valido: Rua das Flores 
            string rua = "";                                                // Invalido: R. Principal (contém ponto) 
            bool validacao = false;                                            // Rua, São Jorge 123 (contém dígitos numéricos)
            do
            {
                Console.Write("Digite sua Rua: ");
                rua = Console.ReadLine();

                if (formato.IsMatch(rua) && rua.Length > 3)
                {
                    validacao = true;
                }
                else
                {
                    Console.WriteLine("Entrada invalida, nao entre com numeros, apenas o nome da rua.");
                    Console.WriteLine();
                }
            } while (!validacao);

            // Deixa a primeira letra de todas as palavras maiúsculas, independente de espaços ou virgulas.
            rua = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(rua.ToLower());
            return rua;
        }
    }
}
