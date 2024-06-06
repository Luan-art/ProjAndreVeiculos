using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SQLRepository : IGaragemRepository
    {
        public Boleto GetBoleto(string? v)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";

            using (var connection = new SqlConnection(strConn))
            {
                connection.Open();

                try
                {
                    var boleto = connection.QueryFirstOrDefault<Boleto>("SELECT Id, Numero, DataVencimento FROM Boleto WHERE Id = @id",
                        new { id = v });

                    Console.WriteLine(boleto);

                    return boleto;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public Cargo GetCargo(int v)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";

            using (var connection = new SqlConnection(strConn))
            {
                connection.Open();

                try
                {
                    var boleto = connection.QueryFirstOrDefault<Cargo>("SELECT Id, Descricao FROM CARGO WHERE Id = @id",
                        new { id = v });

                    Console.WriteLine(boleto);

                    return boleto;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public Carro GetCarro(string? v)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";

            using (var connection = new SqlConnection(strConn))
            {
                connection.Open();

                try
                {
                    var carro = connection.QueryFirstOrDefault<Carro>("SELECT Placa, nome, AnoModelo, Cor, Vendido FROM CARRO WHERE Placa = @Placa",
                        new { Placa = v });

                    Console.WriteLine(carro);

                    return carro;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public Cartao GetCartao(string? v)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";

            using (var connection = new SqlConnection(strConn))
            {
                connection.Open();

                try
                {
                    var cartao = connection.QueryFirstOrDefault<Cartao>("SELECT NumeroCartao, CodigoSeguranca, DataValidade, NomeCartao FROM Cartao WHERE NumeroCartao = @id",
                        new { id = v });

                    Console.WriteLine(cartao);

                    return cartao;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public Cliente GetCliente(string? v)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";

            using (var connection = new SqlConnection(strConn))
            {
                connection.Open();

                try
                {
                    var cliente = connection.QueryFirstOrDefault<Cliente>("SELECT Documento, Renda, Nome, DataNascimento, EnderecoId, Telefone, Email" +
                        " FROM Cliente WHERE Documento = @Documento",
                        new { Documento = v });

                    Console.WriteLine(cliente);

                    return cliente;
                }
                catch (Exception ex)    
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public Endereco GetEnd(int v)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";

            using (var connection = new SqlConnection(strConn))
            {
                connection.Open();

                try
                {
                    var boleto = connection.QueryFirstOrDefault<Endereco>("SELECT Id, Logradouro, CEP, Bairro, TipoLogradouro, Complemento, Numero," +
                        " UF, Cidade FROM Endereco WHERE Id = @id",
                        new { id = v });

                    Console.WriteLine(boleto);

                    return boleto;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public Funcionario GetFuncionario(string? v)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";

            using (var connection = new SqlConnection(strConn))
            {
                connection.Open();

                try
                {
                    var cliente = connection.QueryFirstOrDefault<Funcionario>("SELECT Documento, CargoId, ValorComissao," +
                        " Comissao, Nome, EnderecoId, Telefone, Email" +
                        " FROM Funcionario WHERE Documento = @Documento",
                        new { Documento = v });

                    Console.WriteLine(cliente);

                    return cliente;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public Pagamento GetPagamento(int v)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";

            using (var connection = new SqlConnection(strConn))
            {
                connection.Open();

                try
                {
                    var pagamento = connection.QueryFirstOrDefault<Pagamento>("SELECT Id, CartaoNumero, BoletoId, PixId, DataPagamento" +
                        " FROM Pagamento WHERE Id = @Id",
                        new { Id = v });

                    Console.WriteLine(pagamento);

                    return pagamento;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public Pix GetPix(string? v)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";

            using (var connection = new SqlConnection(strConn))
            {
                connection.Open();

                try
                {
                    var boleto = connection.QueryFirstOrDefault<Pix>("SELECT Id, TipoPixId, ChavePix FROM Pix WHERE Id = @id",
                        new { id = v });

                    Console.WriteLine(boleto);

                    return boleto;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public Servico GetService(int v)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";

            using (var connection = new SqlConnection(strConn))
            {
                connection.Open();

                try
                {
                    var servico = connection.QueryFirstOrDefault<Servico>("SELECT Id, Descricao FROM SERVICO WHERE Id = @id",
                        new { id = v });

                    Console.WriteLine(servico);
                    return servico;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public TipoPix GetTipoPix(int v)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";

            using (var connection = new SqlConnection(strConn))
            {
                connection.Open();

                try
                {
                    var tp = connection.QueryFirstOrDefault<TipoPix>("SELECT Id, Nome FROM TipoPix WHERE Id = @id",
                        new { id = v });

                    Console.WriteLine(tp);
                    return tp;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public bool InjetarCliente(Cliente cliente)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
            bool result = false;
            string sql = "INSERT INTO Cliente ( Documento, Renda, Nome, DataNascimento, EnderecoID, Telefone, Email) " +
                "VALUES (  @Documento, @Renda, @Nome, @DataNascimento, @EnderecoID, @Telefone, @Email);";
            try
            {
                using (var db = new SqlConnection(strConn))
                {
                    db.Open();

                    db.Execute(sql, new
                    {
                        Documento = cliente.Documento,
                        Renda = cliente.Renda,
                        Nome = cliente.Nome,
                        DataNascimento = cliente.DataNascimento,
                        EnderecoId = cliente.Endereco.Id,
                        Telefone = cliente.Telefone,
                        Email = cliente.Email
                    });

                }

                result = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public bool InjetarFuncionario(Funcionario fun)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
            bool result = false;
            string sql = "INSERT INTO Funcionario ( Documento, CargoId, ValorComissao, Comissao, Nome, DataNascimento, EnderecoID, Telefone, Email) " +
                "VALUES (  @Documento, @CargoId, @ValorComissao, @Comissao, @Nome, @DataNascimento, @EnderecoID, @Telefone, @Email);";
            try
            {
                using (var db = new SqlConnection(strConn))
                {
                    db.Open();

                    db.Execute(sql, new
                    {
                        Documento = fun.Documento,
                        CargoId = fun.Cargo.Id,
                        ValorComissao = fun.ValorComissao,
                        Comissao = fun.Comissao,
                        Nome = fun.Nome,
                        DataNascimento = fun.DataNascimento,
                        EnderecoId = fun.Endereco.Id,
                        Telefone = fun.Telefone,
                        Email = fun.Email
                    });

                }

                result = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public bool InjetarPagamento(Pagamento pagamento)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
            bool result = false;
            string sql = "INSERT INTO Pagamento ( CartaoNumero, BoletoId, PixId, DataPagamento) VALUES ( @CartaoNumero, @BoletoId, @PixId, @DataPagamento);";
            try
            {
                using (var db = new SqlConnection(strConn))
                {
                    db.Open();

                    db.Execute(sql, new { CartaoNumero = pagamento.Cartao.NumeroCartao, BoletoId = pagamento.Boleto.Id
                    ,PixId = pagamento.Pix.Id ,DataPagamento = pagamento.DataPagamento});

                }

                result = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public bool InserirBoleto(List<Boleto> boletos)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
            bool result = false;
            string sql = "INSERT INTO Boleto ( Numero, DataVencimento) VALUES ( @Numero, @DataVencimento);";
            try
            {
                using (var db = new SqlConnection(strConn))
                {
                    db.Open();

                    foreach (Boleto boleto in boletos)
                    {
                        db.Execute(sql, boleto);

                    }
                }

                result = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public bool InserirCargos(List<Cargo> cargos)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
            bool result = false;
            string sql = "INSERT INTO Cargo (Descricao) VALUES (@Descricao);";
            try
            {
                using (var db = new SqlConnection(strConn))
                {
                    db.Open();

                    foreach (Cargo cargo in cargos)
                    {
                        db.Execute(sql, cargo);

                    }
                }

                result = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public bool InserirCarro(List<Carro> carros)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
            bool result = false;
            string sql = "INSERT INTO CARRO (Placa, Nome, AnoModelo, AnoFabricacao, Cor, Vendido) VALUES (@Placa, @Nome, @AnoModelo, @AnoFabricacao, @Cor, @Vendido)";
            try
            {
                using (var db = new SqlConnection(strConn))
                {
                    db.Open();

                    foreach (Carro carro in carros)
                    {
                        db.Execute(sql, carro);

                    }
                }

                result = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public bool InserirCarroServico(CarroServico carroServico)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
            bool result = false;
            string sql = "INSERT INTO CarroServico (CarroPlaca, ServicoId) VALUES (@CarroPlaca, @ServicoId)";
            try
            {
                using (var db = new SqlConnection(strConn))
                {
                    db.Open();

                    db.Execute(sql, new { CarroPlaca = carroServico.Carro.Placa, ServicoId = carroServico.Servico.Id });

                }

                result = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public bool InserirCartoes(List<Cartao> cartaos)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
            bool result = false;
            string sql = "INSERT INTO Cartao (NumeroCartao, CodigoSeguranca, DataValidade, NomeCartao) VALUES (@NumeroCartao, @CodigoSeguranca, @DataValidade, @NomeCartao);";
            try
            {
                using (var db = new SqlConnection(strConn))
                {
                    db.Open();

                    foreach (Cartao cartao in cartaos)
                    {
                        db.Execute(sql, cartao);

                    }
                }

                result = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public bool InserirCompra(Compra compra)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
            bool result = false;
            string sql = "INSERT INTO Compra (CarroPlaca, Preco, DataCompra) VALUES (@CarroPlaca, @Preco, @DataCompra)";
            try
            {
                using (var db = new SqlConnection(strConn))
                {
                    db.Open();

                    db.Execute(sql, new { CarroPlaca = compra.Carro.Placa, Preco = compra.Preco, DataCompra = compra.DataCompra });

                }

                result = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public bool InserirEndereco(List<Endereco> enderecos)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
            bool result = false;
            string sql = "INSERT INTO Endereco (Logradouro, CEP, Bairro, TipoLogradouro, Complemento, Numero, Uf, Cidade) VALUES (@Logradouro, @CEP, @Bairro, @TipoLogradouro, @Complemento, @Numero, @Uf, @Cidade);";
            try
            {
                using (var db = new SqlConnection(strConn))
                {
                    db.Open();

                    foreach (Endereco end in enderecos)
                    {
                        db.Execute(sql, end);

                    }
                }

                result = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public bool InserirPix(Pix pix)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
            bool result = false;
            string sql = "INSERT INTO Pix (TipoPixId, ChavePix) VALUES (@TipoPixId, @ChavePix)";
            try
            {
                using (var db = new SqlConnection(strConn))
                {
                    db.Open();

                    db.Execute(sql, new { TipoPixId = pix.Tipo.Id, ChavePix = pix.ChavePix });

                }

                result = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public bool InserirServicos(List<Servico> servicos)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
            bool result = false;
            string sql = "INSERT INTO Servico (Descricao) VALUES (@Descricao);";
            try
            {
                using (var db = new SqlConnection(strConn))
                {
                    db.Open();

                    foreach (Servico servico in servicos)
                    {
                        db.Execute(sql, servico);

                    }
                }

                result = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public bool InserirTipoPix(List<TipoPix> tiposPix)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
            bool result = false;
            string sql = "INSERT INTO TipoPix (Nome) VALUES (@Nome);";
            try
            {
                using (var db = new SqlConnection(strConn))
                {
                    db.Open();

                    foreach (TipoPix tipo in tiposPix) { db.Execute(sql, tipo); }

                }

                result = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public bool InserirVenda(Venda venda)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=DBAndresGaragem; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
            bool result = false;
            string sql = "INSERT INTO Venda (CarroPlaca, DataVenda, ValorVenda, ClienteDocumento, FuncionarioDocumento, PagamentoId)" +
                " VALUES (@CarroPlaca, @DataVenda, @ValorVenda, @ClienteDocumento, @FuncionarioDocumento, @PagamentoId);";
            try
            {
                using (var db = new SqlConnection(strConn))
                {
                    db.Open();

                    db.Execute(sql, new
                    {
                        CarroPlaca = venda.Carro.Placa,
                        DataVenda = venda.DataVenda,
                        ValorVenda = venda.ValorVenda,
                        ClienteDocumento = venda.Cliente.Documento,
                        FuncionarioDocumento = venda.Funcionario.Documento,
                        PagamentoId = venda.Pagamento.Id
                    }); 

                }

                result = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }
    }
}
