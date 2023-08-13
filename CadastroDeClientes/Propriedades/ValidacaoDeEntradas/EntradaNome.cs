using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CadastroDeClientes.Propriedades.ValidacaoDeEntradas {
    public static class EntradaNome {
        public static string EntradaValida() 
        {
            // Esse codigo é responsável pelo formato do nome e validação.
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            string nome;
            Regex regex = new Regex("^[a-zA-Z]+$"); // Formato valido: João
                                                    // Formato inválido: joão (primeira letra não é maiúscula)
            do                                      // Formato invalido: João Silva (contém um espaço)
            {
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();

                
                if (!regex.IsMatch(nome))
                {
                    Console.WriteLine("Ops, esse campo aceita somente letras, digite novamente.");
                    Console.WriteLine();
                }
                
                else if (nome.Contains(" "))
                {
                    Console.WriteLine("Ops, esse campo aceita somente letras, digite novamente.");
                    nome = "";
                    Console.WriteLine();
                }
            } while (!regex.IsMatch(nome) || nome.Contains(" "));

            
            nome = char.ToUpper(nome[0]) + nome.Substring(1).ToLower(); // Formata deixando a primeira letra maiúsculas
                                                                           // e as demais minúsculas.
            return nome;

        }
    }
}
