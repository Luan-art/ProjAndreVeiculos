using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IGaragemRepository
    {
        public bool InserirCarro(List<Carro> carros);

        public bool InserirEndereco(List<Endereco> enderecos);

        public bool InserirBoleto(List<Boleto> boletos);

        public bool InserirCartoes(List<Cartao> cartaos);

        public bool InserirServicos(List<Servico> servicos);

        public bool InserirCargos(List<Cargo> cargos);

        public bool InserirTipoPix(List<TipoPix> tiposPix);
        bool InserirCarroServico(CarroServico carroServico);
        Carro GetCarro(string? v);
        Servico GetService(int v);
        TipoPix GetTipoPix(int v);
        bool InserirPix(Pix pix);
        Pix GetPix(string? v);
        Boleto GetBoleto(string? v);
        Cartao GetCartao(string? v);
        bool InjetarPagamento(Pagamento pagamento);
        Endereco GetEnd(int v);
        Cargo GetCargo(int v);
        bool InjetarFuncionario(Funcionario fun);
        bool InjetarCliente(Cliente cliente);
        bool InserirCompra(Compra compra);
        Pagamento GetPagamento(int v);
        Funcionario GetFuncionario(string? v);
        Cliente GetCliente(string? v);
        bool InserirVenda(Venda venda);
    }
}
