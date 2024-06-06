using Microsoft.Data.SqlClient;
using Models;
using Repositories;
using System;

namespace Services
{
    public class GaragemService
    {
        private IGaragemRepository iGaragemRepository;

        public GaragemService()
        {
            iGaragemRepository = new SQLRepository();
        }

        public Servico GetService(int v) => iGaragemRepository.GetService(v);

        public Carro GetCarro(string? v) => iGaragemRepository.GetCarro(v);

        public bool InserirBoleto(List<Boleto> boletos)
        {
            try
            {
                iGaragemRepository.InserirBoleto(boletos);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir dados: " + ex.Message);
                return false;
            }
        }

        public bool InserirCargos(List<Cargo> cargos)
        {
            try
            {
                iGaragemRepository.InserirCargos(cargos);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir dados: " + ex.Message);
                return false;
            }

        }
            
        public bool InserirCarro(List<Carro> carros)
        {
            try
            {
                iGaragemRepository.InserirCarro(carros);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir dados: " + ex.Message);
                return false;
            }
        }

        public bool InserirCarroServico(CarroServico carroServico)
        {
            if (iGaragemRepository.InserirCarroServico(carroServico))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InserirCartoes(List<Cartao> cartaos)
        {
            try
            {
                iGaragemRepository.InserirCartoes(cartaos);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir dados: " + ex.Message);
                return false;
            }
        }

        public bool InserirEndereco(List<Endereco> enderecos)
        {
            try
            {
                iGaragemRepository.InserirEndereco(enderecos);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir dados: " + ex.Message);
                return false;
            }

        }

        public bool InserirServicos(List<Servico> servicos)
        {
            try
            {
                iGaragemRepository.InserirServicos(servicos);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir dados: " + ex.Message);
                return false;
            }
        }

        public bool InserirTipoPix(List<TipoPix> tiposPix)
        {
            try
            {
                iGaragemRepository.InserirTipoPix(tiposPix);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir dados: " + ex.Message);
                return false;
            }
        }

        public TipoPix GetTipoPix(int v) => iGaragemRepository.GetTipoPix(v);

        public bool InserirPix(Pix pix)
        {
            if (iGaragemRepository.InserirPix(pix))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Pix GetPix(string? v) => iGaragemRepository.GetPix(v);

        public Boleto GetBoleto(string? v) => iGaragemRepository.GetBoleto(v);


        public Cartao GetCartao(string? v) => iGaragemRepository.GetCartao(v);

        public bool InjetarPagamento(Pagamento pagamento)
        {
            if (iGaragemRepository.InjetarPagamento(pagamento))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Endereco GetEnd(int v) => iGaragemRepository.GetEnd(v);
        public Cargo GetCargo(int v) => iGaragemRepository.GetCargo(v);

        public bool InjetarFuncionario(Funcionario fun)
        {
            if (iGaragemRepository.InjetarFuncionario(fun))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InjetarCliente(Cliente cliente)
        {
            if (iGaragemRepository.InjetarCliente(cliente))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InserirCompra(Compra compra)
        {
            if (iGaragemRepository.InserirCompra(compra))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Pagamento GetPagamento(int v) => iGaragemRepository.GetPagamento(v);

        public Funcionario GetFuncionario(string? v) => iGaragemRepository.GetFuncionario(v);

        public Cliente GetCliente(string? v) => iGaragemRepository.GetCliente(v);

        public bool InserirVenda(Venda venda)
        {
            if (iGaragemRepository.InserirVenda(venda))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
