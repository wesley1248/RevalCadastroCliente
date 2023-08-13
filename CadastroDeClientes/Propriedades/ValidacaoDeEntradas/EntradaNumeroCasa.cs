using System;

namespace CadastroDeClientes.Propriedades.ValidacaoDeEntradas {
    public class EntradaNumeroCasa {
        public static string EntradaValida()
        {
            // Classe responsável por receber o numero da casa.
            bool entradaValida = false;
            int numeroValidado = 0;
            do
            {
                Console.Write("Digite o numero da casa: ");
                string entradaNumero = Console.ReadLine();

                bool validacao = Int32.TryParse(entradaNumero, out numeroValidado);

                if (validacao == true && numeroValidado > -1) // Formato valido: 123 e 12
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada invalida.");
                    Console.WriteLine();
                }
            }
            while (!entradaValida);
            return numeroValidado.ToString();
        }
    }
}
