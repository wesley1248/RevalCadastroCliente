using System;
using System.Linq;

namespace CadastroDeClientes.Propriedades.ValidacaoDeEntradas {
    public class EntradaTelefone {
        public static string EntradaValida() 
        {
            // Classe responsável pelo numero de telefone.
            bool validacao = false;
            string numeroValidado = "0";

            do
            {
                Console.Write("Digite o numero de telefone: ");
                string numero = Console.ReadLine();

                bool numeroValido = numero.Any(char.IsLetter); // verifica se tem letras

                if (numero.Length >= 11 && numeroValido == false) // Tem que ter 11 dígitos, contando com o DDD
                {
                    numeroValidado = numero;
                    validacao = true;
                }
                else
                {
                    Console.WriteLine("Numero invalido, digite o DDD seguindo do numero");
                    Console.WriteLine();
                }

            } while (!validacao);

            return numeroValidado.ToString();
        }
    }
}
