using System;

namespace Financeiro.Boleto.Domain.Entities
{
    public class Boleto
    {
        public int Id { get; set; }
        public string NumeroBoleto { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public string CPF_CNPJ { get; set; }
        public string NomePagador { get; set; }
        public string Endereco { get; set; }
        public bool IsPago { get; set; }

        public Boleto(string numeroBoleto, decimal valor, DateTime dataVencimento, string cpf_cnpj, string nomePagador, string endereco)
        {
            NumeroBoleto = numeroBoleto;
            Valor = valor;
            DataVencimento = dataVencimento;
            CPF_CNPJ = cpf_cnpj;
            NomePagador = nomePagador;
            Endereco = endereco;
            IsPago = false;
        }

        public void Pagar(DateTime dataPagamento)
        {
            if (IsPago)
                throw new InvalidOperationException("Este boleto já foi pago");

            DataPagamento = dataPagamento;
            IsPago = true;
        }
    }
}