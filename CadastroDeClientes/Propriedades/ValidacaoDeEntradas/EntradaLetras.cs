using System;
using System.Text.RegularExpressions;

namespace CadastroDeClientes.Propriedades.ValidacaoDeEntradas {
    public class EntradaLetras {
        public static string EntradaValida()
        {
            // Essa classe aceita somente letras.
            Regex formatoInvalido = new Regex("[0-9]"); // Formato valido: ApenasLetras
            bool validado = false;
            string complementoValidado = "";
            do
            {
                Console.Write("Digite o  complemento: ");
                string complemento = Console.ReadLine();

                bool validacao = formatoInvalido.IsMatch(complemento);

                if (validacao == false && complemento.Length > 1)
                {
                    complementoValidado = complemento;
                    validado = true;
                }
                else
                {
                    Console.WriteLine("Esse campo so aceita letras!.");
                    Console.WriteLine();
                }
            } while (!validado);

            return complementoValidado;
        }
    }
}
