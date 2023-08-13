# Documentação do Programa de Cadastro de Clientes

## Visão Geral

Este programa permite aos usuários cadastrar, pesquisar, alterar e excluir informações de clientes. Ele interage com o usuário por meio de mensagens no console e valida as entradas do usuário usando várias classes de validação.

## Estrutura do Programa

O programa é dividido em várias classes que possuem funções específicas:

1. **`DadosDoCliente`**: Define as propriedades de um cliente, como nome, sobrenome, data de nascimento, CPF, endereço, telefone e email.

2. **`EntradaNome`**: Realiza a validação da entrada do nome, permitindo somente letras e garantindo que o nome não contenha espaços em branco.

3. **`EntradaData`**: Valida a entrada da data de nascimento no formato "dd/MM/yyyy".

4. **`EntradaCpf`**: Valida a entrada do CPF no formato "999.999.999-99".

5. **`EntradaRua`**: Valida a entrada do nome da rua, permitindo somente letras e garantindo que o nome tenha pelo menos 4 caracteres.

6. **`EntradaNumeroCasa`**: Valida a entrada do número da casa, permitindo somente números inteiros positivos.

7. **`EntradaLetras`**: Valida a entrada de um complemento, garantindo que contenha somente letras e tenha mais de 1 caractere.

8. **`EntradaCep`**: Valida a entrada do CEP no formato "99999-999".

9. **`EntradaTelefone`**: Valida a entrada de um número de telefone, permitindo somente números.

10. **`EntradaOperacao`**: Valida a entrada da operação a ser realizada, como "encerrar", "incluir", "pesquisar", "alterar" ou "excluir".

11. **`CadastroGerenciamento`**: Gerencia as operações de cadastro, pesquisa, alteração e exclusão de clientes.

12. **`Program`**: Ponto de entrada do programa, que interage com o usuário e coordena as operações.

## Fluxo de Execução

1. O programa começa exibindo a mensagem "CADASTRAMENTO" no console.

2. O programa coleta informações do cliente por meio de interações no console, usando as classes de validação para garantir a entrada correta.

3. As informações do cliente são armazenadas em objetos da classe `DadosDoCliente` e adicionadas à lista de clientes.

4. Após o registro do cliente, o programa exibe detalhes de todos os clientes registrados.

5. O programa oferece opções para "Encerrar", "Incluir", "Pesquisar", "Alterar" ou "Excluir" clientes.

6. Dependendo da opção selecionada, o programa realiza a ação correspondente, interagindo novamente com o usuário.

7. O programa permite que o usuário execute várias operações até escolher a opção "Encerrar".

8. Quando a opção "Encerrar" é escolhida, o programa exibe uma mensagem de agradecimento e encerra a execução.

## Utilização

Para usar o programa, siga as instruções exibidas no console. Insira informações solicitadas para cada cliente, selecione uma operação e siga interações do programa. Certifique-se de inserir informações válidas de acordo com os formatos especificados.

## Exemplos

Aqui estão alguns exemplos de interações do programa:

1. **Cadastrar Cliente:**
   - Nome: John
   - Sobrenome: Doe
   - Data de Nascimento: 01/01/1990
   - CPF: 123.456.789-00
   - Rua: Main Street
   - Número da Casa: 123
   - Complemento: Apartamento 4B
   - CEP: 12345-678
   - Telefone: 987654321
   - Email: john@example.com

2. **Pesquisar Cliente:**
   - Pesquisar pelo nome: John
   - Exibir detalhes do cliente John Doe

3. **Alterar Cliente:**
   - Pesquisar pelo nome: John
   - Alterar informações do cliente
   - Exibir detalhes atualizados do cliente John Doe

4. **Excluir Cliente:**
   - Pesquisar pelo nome: John
   - Confirmar exclusão do cliente John Doe

## Considerações Finais

Esta documentação fornece visão geral do programa de cadastro de clientes, suas classes e funcionalidades. Certifique-se de seguir instruções do programa e inserir informações válidas para obter resultados esperados. Sempre verifique mensagens exibidas
