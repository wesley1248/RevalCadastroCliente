using System;

namespace CadastroDeClientes.Propriedades.ValidacaoDeEntradas {
    public class EntradaData {
        public static string EntradaFormatada() 
        {
            // Essa classe valida a entrada da data de nascimento.
            string formato = "dd/MM/yyyy";
            bool dataValida = false;
            DateTime dataValidada;

            do
            {
                Console.Write("Digite a data de nascimento: ");
                string data = Console.ReadLine();

                if (DateTime.TryParseExact(data, formato, null, System.Globalization.DateTimeStyles.None,
                    out dataValidada)) // Formato valido: 01/01/2000
                {
                    dataValida = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Data de nascimento inválida, por favor digite no formato (99/99/9999).");
                    Console.WriteLine();
                }
            } while (!dataValida);
            return dataValidada.ToString();
        }
        
    }
}
