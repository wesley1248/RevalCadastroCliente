using CadastroDeClientes.Propriedades.Cliente.PropriedadesDoCliente;
using CadastroDeClientes.Propriedades.ValidacaoDeEntradas;
using System;
using System.Collections.Generic;

namespace CadastroDeClientes {
    internal class Program {
        static void Main(string[] args)
        {
            // Primeira parte do programa.
            Console.WriteLine("CADASTRAMENTO");
            Console.WriteLine();
            #region
            List<DadosDoCliente> clientes = new List<DadosDoCliente>();

            string gerarId = Guid.NewGuid().ToString().Substring(0, 4); //Gera um ID e pega os 4 primeiros digitos.

            Console.WriteLine("REGISTRO DO PRIMEIRO NOME.");
            string auxiliarNome = EntradaNome.EntradaValida();
            Console.WriteLine();

            Console.WriteLine("REGISTRO DO SOBRENOME.");
            string auxiliarSobreNome = EntradaNome.EntradaValida();
            Console.WriteLine();

            Console.WriteLine("REGISTRO DA DATA DE NASCIMENTO.");
            DateTime auxiliarData = DateTime.Parse(EntradaData.EntradaFormatada());
            Console.WriteLine();

            Console.WriteLine("REGISTRO DO CPF.");
            string auxiliarCpf = EntradaCpf.ValidarCpf();
            Console.WriteLine();

            Console.WriteLine("REGISTRO DA RUA.");
            string auxiliarRua = EntradaRua.EntradaValida();
            Console.WriteLine();

            Console.WriteLine("REGISTRO DO NUMERO DA CASA.");
            int auxiliarNumeroDaCasa = int.Parse(EntradaNumeroCasa.EntradaValida());
            Console.WriteLine();

            Console.WriteLine("REGISTRO DO COMPLEMENTO.");
            string auxiliarComplemento = EntradaLetras.EntradaValida();
            Console.WriteLine();

            Console.WriteLine("REGISTRO DO CEP.");
            string auxiliarCep = EntradaCep.EntradaValida();
            Console.WriteLine();
            
            Console.WriteLine("REGISTRO DO TELEFONE.");
            string auxiliarTelefone = EntradaTelefone.EntradaValida();
            Console.WriteLine();
            
            Console.WriteLine("REGISTRO DO EMAIL.");
            Console.Write("Digite seu Email: ");
            string auxiliarEmail = Console.ReadLine();
            Console.WriteLine();

            clientes.Add(new DadosDoCliente
            {
                Id = gerarId,
                Nome = auxiliarNome,
                SobreNome = auxiliarSobreNome,
                DataDeNascimento = auxiliarData,
                Cpf = auxiliarCpf,
                Rua = auxiliarRua,
                NumeroDaCasa = auxiliarNumeroDaCasa,
                Complemento = auxiliarComplemento,
                Cep = auxiliarCep,
                Telefone = auxiliarTelefone,
                Email = auxiliarEmail
            });

            Console.WriteLine("Clientes registrados:");
            Console.WriteLine();

            foreach (DadosDoCliente cliente in clientes)
            {
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"Sobrenome: {cliente.SobreNome}");
                Console.WriteLine($"Data de Nascimento: {cliente.DataDeNascimento}");
                Console.WriteLine($"CPF: {cliente.Cpf}");
                Console.WriteLine($"Rua: {cliente.Rua}");
                Console.WriteLine($"Número da Casa: {cliente.NumeroDaCasa}");
                Console.WriteLine($"Complemento: {cliente.Complemento}");
                Console.WriteLine($"CEP: {cliente.Cep}");
                Console.WriteLine($"Telefone: {cliente.Telefone}");
                Console.WriteLine($"E-mail: {cliente.Email}");
                Console.WriteLine();
            }
            #endregion

            // Segunda parte do programa.
            #region
            bool validacaoOperacao = false;
            do
            {
                Console.WriteLine("Digite a baixo a operação que deseja fazer!");
                Console.WriteLine();
                Console.WriteLine("Encerrar");
                Console.WriteLine("Incluir");
                Console.WriteLine("Pesquisar");
                Console.WriteLine("Alterar");
                Console.WriteLine("Excluir");
                Console.WriteLine();
                string operacao = EntradaOperacao.EntradaFormatada();
                Console.WriteLine();

                if (operacao == "encerrar")
                {
                    Console.WriteLine("Selecionado ENCERRAR");
                    validacaoOperacao = true;
                }
                else
                {
                    switch (operacao)
                    {
                        case "incluir":
                            #region
                            Console.WriteLine("Selecionado INCLUIR");
                            Console.WriteLine();

                            Console.WriteLine("REGISTRO DO PRIMEIRO NOME.");
                             auxiliarNome = EntradaNome.EntradaValida();
                            Console.WriteLine();

                            Console.WriteLine("REGISTRO DO SOBRENOME.");
                             auxiliarSobreNome = EntradaNome.EntradaValida();
                            Console.WriteLine();

                            Console.WriteLine("REGISTRO DA DATA DE NASCIMENTO.");
                             auxiliarData = DateTime.Parse(EntradaData.EntradaFormatada());
                            Console.WriteLine();

                            Console.WriteLine("REGISTRO DO CPF.");
                             auxiliarCpf = EntradaCpf.ValidarCpf();
                            Console.WriteLine();

                            Console.WriteLine("REGISTRO DA RUA.");
                             auxiliarRua = EntradaRua.EntradaValida();
                            Console.WriteLine();

                            Console.WriteLine("REGISTRO DO NUMERO DA CASA.");
                             auxiliarNumeroDaCasa = int.Parse(EntradaNumeroCasa.EntradaValida());
                            Console.WriteLine();

                            Console.WriteLine("REGISTRO DO COMPLEMENTO.");
                             auxiliarComplemento = EntradaLetras.EntradaValida();
                            Console.WriteLine();

                            Console.WriteLine("REGISTRO DO CEP.");
                             auxiliarCep = EntradaCep.EntradaValida();
                            Console.WriteLine();

                            Console.WriteLine("REGISTRO DO TELEFONE.");
                             auxiliarTelefone = EntradaTelefone.EntradaValida();
                            Console.WriteLine();

                            Console.WriteLine("REGISTRO DO EMAIL.");
                            Console.Write("Digite seu Email: ");
                             auxiliarEmail = Console.ReadLine();
                            Console.WriteLine();

                            clientes.Add(new DadosDoCliente
                            {
                                Nome = auxiliarNome,
                                SobreNome = auxiliarSobreNome,
                                DataDeNascimento = auxiliarData,
                                Cpf = auxiliarCpf,
                                Rua = auxiliarRua,
                                NumeroDaCasa = auxiliarNumeroDaCasa,
                                Complemento = auxiliarComplemento,
                                Cep = auxiliarCep,
                                Telefone = auxiliarTelefone,
                                Email = auxiliarEmail
                            });

                            Console.WriteLine("Clientes registrados:");
                            foreach (DadosDoCliente cliente in clientes)
                            {
                                Console.WriteLine($"Nome: {cliente.Nome}");
                                Console.WriteLine($"Sobrenome: {cliente.SobreNome}");
                                Console.WriteLine($"Data de Nascimento: {cliente.DataDeNascimento.ToString("dd/MM/yyyy")}");
                                Console.WriteLine($"CPF: {cliente.Cpf}");
                                Console.WriteLine($"Rua: {cliente.Rua}");
                                Console.WriteLine($"Número da Casa: {cliente.NumeroDaCasa}");
                                Console.WriteLine($"Complemento: {cliente.Complemento}");
                                Console.WriteLine($"CEP: {cliente.Cep}");
                                Console.WriteLine($"Telefone: {cliente.Telefone}");
                                Console.WriteLine($"E-mail: {cliente.Email}");
                                Console.WriteLine();
                            }
                            #endregion
                            break;

                        case "pesquisar":
                            #region
                            Console.WriteLine("Selecionado PESQUISAR");
                            bool pessoaEncontradaPesquisa = false;

                            do
                            {
                                Console.WriteLine("Digite o primeiro nome para a pesquisa.");
                                string nomePesquisa = EntradaNome.EntradaValida();

                                foreach (DadosDoCliente cliente in clientes)
                                {
                                    if (cliente.Nome.Contains(nomePesquisa))
                                    {
                                        Console.WriteLine("Cliente encontrado:");
                                        Console.WriteLine();

                                        Console.WriteLine($"Nome: {cliente.Nome}");
                                        Console.WriteLine($"Sobrenome: {cliente.SobreNome}");
                                        Console.WriteLine($"Data de Nascimento: {cliente.DataDeNascimento.ToString("dd/MM/yyyy")}");
                                        Console.WriteLine($"CPF: {cliente.Cpf}");
                                        Console.WriteLine($"Rua: {cliente.Rua}");
                                        Console.WriteLine($"Número da Casa: {cliente.NumeroDaCasa}");
                                        Console.WriteLine($"Complemento: {cliente.Complemento}");
                                        Console.WriteLine($"CEP: {cliente.Cep}");
                                        Console.WriteLine($"Telefone: {cliente.Telefone}");
                                        Console.WriteLine($"E-mail: {cliente.Email}");
                                        pessoaEncontradaPesquisa = true;
                                        Console.WriteLine();
                                    }
                                }

                                if (!pessoaEncontradaPesquisa)
                                {
                                    Console.WriteLine("Cliente não encontrado, verifique o nome.");
                                    Console.WriteLine();
                                }
                            } while (!pessoaEncontradaPesquisa);
                            #endregion
                            break;

                        case "alterar":
                            #region
                            Console.WriteLine("Selecionado ALTERAR");
                            bool validacao = false;
                            do
                            {
                                Console.WriteLine("Digite o primeiro nome para alterar os dados");
                                string nome = EntradaNome.EntradaValida();
                                Console.WriteLine();

                                DadosDoCliente AlterarCliente = null;
                                foreach (DadosDoCliente cliente in clientes)
                                {
                                    if (cliente.Nome.Contains(nome))
                                    {
                                        AlterarCliente = cliente;
                                        break;
                                    }
                                }

                                if (AlterarCliente != null)
                                {
                                    Console.WriteLine("Cliente encontrado:");
                                    Console.WriteLine();
                                    Console.WriteLine($"Nome: {AlterarCliente.Nome}");
                                    Console.WriteLine($"Sobrenome: {AlterarCliente.SobreNome}");
                                    Console.WriteLine($"Data de Nascimento: {AlterarCliente.DataDeNascimento.ToString("dd/MM/yyyy")}");
                                    Console.WriteLine($"CPF: {AlterarCliente.Cpf}");
                                    Console.WriteLine($"Rua: {AlterarCliente.Rua}");
                                    Console.WriteLine($"Número da Casa: {AlterarCliente.NumeroDaCasa}");
                                    Console.WriteLine($"Complemento: {AlterarCliente.Complemento}");
                                    Console.WriteLine($"CEP: {AlterarCliente.Cep}");
                                    Console.WriteLine($"Telefone: {AlterarCliente.Telefone}");
                                    Console.WriteLine($"E-mail: {AlterarCliente.Email}");
                                    Console.WriteLine();

                                    Console.WriteLine("Digite as novas informações");
                                    Console.WriteLine();

                                    Console.WriteLine("Nome");
                                    AlterarCliente.Nome = EntradaNome.EntradaValida();
                                    Console.WriteLine();

                                    Console.WriteLine("Sobrenome");
                                    AlterarCliente.SobreNome = EntradaNome.EntradaValida();
                                    Console.WriteLine();

                                    Console.WriteLine("Data de Nascimento");
                                    AlterarCliente.DataDeNascimento = DateTime.Parse(EntradaData.EntradaFormatada());
                                    Console.WriteLine();

                                    Console.WriteLine("CPF");
                                    AlterarCliente.Cpf = EntradaCpf.ValidarCpf();
                                    Console.WriteLine();

                                    Console.WriteLine("Rua");
                                    AlterarCliente.Rua = EntradaRua.EntradaValida();
                                    Console.WriteLine();

                                    Console.WriteLine("Numero da casa");
                                    AlterarCliente.NumeroDaCasa = int.Parse(EntradaNumeroCasa.EntradaValida());
                                    Console.WriteLine();

                                    Console.WriteLine("Complemento");
                                    AlterarCliente.Complemento = EntradaLetras.EntradaValida();
                                    Console.WriteLine();

                                    Console.WriteLine("CEP");
                                    AlterarCliente.Cep = EntradaCep.EntradaValida();
                                    Console.WriteLine();

                                    Console.WriteLine("Telefone");
                                    AlterarCliente.Telefone = EntradaTelefone.EntradaValida();
                                    Console.WriteLine();

                                    Console.WriteLine("Email");
                                    Console.Write("Digite seu Email: ");
                                    AlterarCliente.Email = Console.ReadLine();

                                    Console.WriteLine("Cliente atualizado com sucesso!");
                                    Console.WriteLine();

                                    Console.WriteLine("Cliente encontrado:");
                                    Console.WriteLine($"Nome: {AlterarCliente.Nome}");
                                    Console.WriteLine($"Sobrenome: {AlterarCliente.SobreNome}");
                                    Console.WriteLine($"Data de Nascimento: {AlterarCliente.DataDeNascimento.ToString("dd/MM/yyyy")}");
                                    Console.WriteLine($"CPF: {AlterarCliente.Cpf}");
                                    Console.WriteLine($"Rua: {AlterarCliente.Rua}");
                                    Console.WriteLine($"Número da Casa: {AlterarCliente.NumeroDaCasa}");
                                    Console.WriteLine($"Complemento: {AlterarCliente.Complemento}");
                                    Console.WriteLine($"CEP: {AlterarCliente.Cep}");
                                    Console.WriteLine($"Telefone: {AlterarCliente.Telefone}");
                                    Console.WriteLine($"E-mail: {AlterarCliente.Email}");
                                    Console.WriteLine();

                                    validacao = true;
                                }
                                else
                                {
                                    Console.WriteLine("Cliente não encontrado, digite novamente.");
                                }
                            } while (!validacao);

                            #endregion
                            break;

                        case "excluir":
                            #region

                            Console.WriteLine("Selecionado EXCLUIR");
                            bool pessoaEncontradaExclusao = false;
                            do
                            {
                                Console.WriteLine("Digite o primeiro nome para a exclusão dos dados");
                                string nome = EntradaNome.EntradaValida();

                                DadosDoCliente clienteExcluir = null;
                                foreach (DadosDoCliente cliente in clientes)
                                {
                                    if (cliente.Nome.Contains(nome))
                                    {
                                        clienteExcluir = cliente;
                                        break;
                                    }
                                }

                                if (clienteExcluir != null)
                                {
                                    Console.WriteLine("Cliente encontrado:");
                                    Console.WriteLine();

                                    Console.WriteLine($"Nome: {clienteExcluir.Nome}");
                                    Console.WriteLine($"Sobrenome: {clienteExcluir.SobreNome}");
                                    Console.WriteLine($"Data de Nascimento: {clienteExcluir.DataDeNascimento.ToString("dd/MM/yyyy")}");
                                    Console.WriteLine($"CPF: {clienteExcluir.Cpf}");
                                    Console.WriteLine($"Rua: {clienteExcluir.Rua}");
                                    Console.WriteLine($"Número da Casa: {clienteExcluir.NumeroDaCasa}");
                                    Console.WriteLine($"Complemento: {clienteExcluir.Complemento}");
                                    Console.WriteLine($"CEP: {clienteExcluir.Cep}");
                                    Console.WriteLine($"Telefone: {clienteExcluir.Telefone}");
                                    Console.WriteLine($"E-mail: {clienteExcluir.Email}");
                                    pessoaEncontradaExclusao = true;
                                    Console.WriteLine();

                                    Console.Write("Confirme a exclusão Sim/Não: ");
                                    string decisao = Console.ReadLine().ToLower();

                                    if (decisao == "sim")
                                    {
                                        Console.WriteLine("Exclusão executada com sucesso.");
                                        clientes.Remove(clienteExcluir);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Exclusão cancelada.");
                                        Console.WriteLine();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Cliente não encontrado, digite novamente.");
                                }

                            } while (!pessoaEncontradaExclusao);
                            #endregion
                            break;
                    }
                }

            } while (!validacaoOperacao);
            #endregion
            Console.WriteLine("Obrigado pela oportunidade!");
            Console.WriteLine();

            Console.WriteLine("APERTE QUALQUER TECLA.");
            Console.ReadKey();
        }
    }
}
