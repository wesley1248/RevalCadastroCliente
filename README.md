---

# Documentação do Sistema de Cadastro de Clientes

## Visão Geral

O Sistema de Cadastro de Clientes é uma aplicação de console desenvolvida em C# para gerenciar informações de clientes, oferecendo funcionalidades de cadastro, pesquisa, alteração e exclusão.

## Estrutura do Projeto

- **CadastroDeClientes:**
  - **Propriedades:**
    - **Cliente:**
      - `PropriedadesDoCliente`: Contém a classe `DadosDoCliente` com as propriedades do cliente.
    - **ValidacaoDeEntradas:**
      - `EntradaCep`: Classe para validar entrada de CEP.
      - `EntradaCpf`: Classe para validar entrada de CPF.
      - `EntradaData`: Classe para validar entrada de data de nascimento.
      - `EntradaLetras`: Classe para validar entrada de letras.
      - `EntradaNome`: Classe para validar entrada de nome.
      - `EntradaNumeroCasa`: Classe para validar entrada de número de casa.
      - `EntradaOperacao`: Classe para validar entrada de operações.
      - `EntradaRua`: Classe para validar entrada de nome de rua.
      - `EntradaTelefone`: Classe para validar entrada de número de telefone.
  - **Program:**
    - `Program`: Contém o código principal com a lógica de cadastro e operações.

## Requisitos do Sistema

- **Ambiente de Desenvolvimento:**
  - [.NET Core SDK](https://dotnet.microsoft.com/download) (versão recomendada)

## Como Executar

1. Clone o repositório para o seu ambiente local.
   ```bash
   git clone https://github.com/seu-usuario/sistema-cadastro-clientes.git
   ```

2. Navegue até o diretório do projeto.
   ```bash
   cd sistema-cadastro-clientes/CadastroDeClientes
   ```

3. Execute o projeto.
   ```bash
   dotnet run
   ```

## Uso

1. Ao iniciar o programa, você será apresentado a um menu de operações.
2. Escolha a operação desejada digitando a palavra-chave correspondente.
3. Siga as instruções para preencher as informações do cliente.
4. Execute operações como incluir, pesquisar, alterar ou excluir conforme necessário.

## Licença

Este projeto está licenciado sob a MIT License - consulte o arquivo [LICENSE.md](LICENSE.md) para mais detalhes.

## Contato

- Autor: Wesley Thiago de Moraes Santos
- Email: wesleytms.es@gmail.com

---
