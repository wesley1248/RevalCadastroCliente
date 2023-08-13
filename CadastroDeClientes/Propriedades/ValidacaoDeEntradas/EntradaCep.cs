using System;
using System.Text.RegularExpressions;

namespace CadastroDeClientes.Propriedades.ValidacaoDeEntradas {
    public class EntradaCep {
        public static string EntradaValida() 
        {
            // Essa classe valida a entrada do CEP.
            Regex formato = new Regex(@"^\d{5}-\d{3}$"); //formato valido: 12345-678
            string cep = "";
            bool validacao = false;
            do
            {
                Console.Write("Digite seu CEP: ");
                cep = Console.ReadLine();

                if (formato.IsMatch(cep))
                {
                    validacao = true;
                }
                else
                {
                    Console.WriteLine("Entrada invalida.");
                    Console.WriteLine();
                }
            } while (!validacao);

            return cep;
        }
    }
}
