using Models;
using Services;
using System;

namespace Controllers
{
    public class GaragemController
    {
        private GaragemService garagemService;

        public GaragemController()
        {
            garagemService = new GaragemService();
        }

        public bool InserirCarro(List<Carro> carros)
        {
            return garagemService.InserirCarro(carros);
        }
        public bool InserirBoleto(List<Boleto> boletos)
        {
            return garagemService.InserirBoleto(boletos);
        }
        public bool InserirCargos(List<Cargo> carg)
        {
            return garagemService.InserirCargos(carg);
        }
        public bool InserirCartoes(List<Cartao> cart)
        {
            return garagemService.InserirCartoes(cart);
        }
        public bool InserirEndereco(List<Endereco> end)
        {
            return garagemService.InserirEndereco(end);
        }

        public bool InserirTipoPix(List<TipoPix> tp)
        {
            return garagemService.InserirTipoPix(tp);
        }
        public bool InserirServicos(List<Servico> servico)
        {
            return garagemService.InserirServicos(servico);
        }

        public bool InserirCarroServico(CarroServico carroServico)
        {
            if (garagemService.InserirCarroServico(carroServico))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Servico GetServico(int v) => garagemService.GetService(v);

        public Carro GetCarro(string? v) => garagemService.GetCarro(v);

        public TipoPix GetTipoPix(int v) => garagemService.GetTipoPix(v);

        public bool InserirPix(Pix pix)
        {
            if (garagemService.InserirPix(pix))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InjetarPagamento(Pagamento pagamento)
        {
            if (garagemService.InjetarPagamento(pagamento))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Pix GetPix(string? v) => garagemService.GetPix(v);
        

        public Boleto GetBoleto(string? v) => garagemService.GetBoleto(v);


        public Cartao GetCartao(string? v) => garagemService.GetCartao(v);

        public bool InjetarFuncionario(Funcionario fun)
        {
            if (garagemService.InjetarFuncionario(fun))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Endereco GetEnd(int v) => garagemService.GetEnd(v);

        public Cargo GetCargo(int v) => garagemService.GetCargo(v);

        public bool InjetarCliente(Cliente cliente)
        {
            if (garagemService.InjetarCliente(cliente))
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
            if (garagemService.InserirCompra(compra))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InserirVenda(Venda venda)
        {
            if (garagemService.InserirVenda(venda))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Pagamento GetPagamento(int v) => garagemService.GetPagamento(v);

        public Funcionario GetFuncionario(string? v) => garagemService.GetFuncionario(v);

        public Cliente GetCliente(string? v) => garagemService.GetCliente(v);
    }
}
