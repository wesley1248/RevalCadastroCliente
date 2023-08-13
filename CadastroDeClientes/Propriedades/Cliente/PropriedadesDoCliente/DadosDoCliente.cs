using System;

namespace CadastroDeClientes.Propriedades.Cliente.PropriedadesDoCliente {
    internal class DadosDoCliente {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Cpf { get; set; }
        public string Rua { get; set; }
        public int NumeroDaCasa { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
