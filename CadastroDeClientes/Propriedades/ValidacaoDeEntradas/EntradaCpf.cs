using System;
using System.Text.RegularExpressions;

namespace CadastroDeClientes.Propriedades.ValidacaoDeEntradas {
    public class EntradaCpf {
        public static string ValidarCpf()
        {
            // Essa classe valida o CPF.
            Regex formatoCpf = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$"); // Formato valido: 123.456.789-09
            string cpfValidado = "";
            bool validacao = false;

            do
            {
                Console.Write("Digite o número do CPF: ");
                string cpf = Console.ReadLine();

                if (formatoCpf.IsMatch(cpf))
                {
                    cpfValidado = cpf;
                    validacao = true;
                }
                else
                {
                    Console.WriteLine("CPF inválido!, Certifique-se de digitar no formato correto (999.999.999-99).");
                    Console.WriteLine();
                }
            } while (!validacao);

            return cpfValidado;
        }
    }
}

