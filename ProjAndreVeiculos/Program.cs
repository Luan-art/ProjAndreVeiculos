using Controllers;
using Models;
using System;

Console.WriteLine("Inicio...");

int op = 0;

while (true)
{
    Console.WriteLine("Digite se deseja Inserir os Dados Iniciais ou Dados especificos ( 1 ou 2 ) respectivamente");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            InjetarDadosIniciais();
            break;
        case 2:
            AdcionarDadosAMao();
            break;
        default:
            Console.WriteLine("Invalido");
            break;
    }
}

void AdcionarDadosAMao()
{
    while (true)
    {
        Console.WriteLine("Digite se deseja inserir Cliente, Funcionario, CargoServico, PIX , Pagamento, Compra e Venda ( 1, 2, 3, 4, 5, 6 ,7)");
        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                InjetarCliente();
                break;
            case 2:
                InjetarFuncionario();
                break;
            case 3:
                InjetarCargoServico();
                break;
            case 4:
                InjetarPix();
                break;
            case 5:
                InjetarPagamento();
                break;
            case 6:
                InserirCompra();
                break;
            case 7:
                InserirVenda();
                break;
            default:
                Console.WriteLine("Invalido");
                break;
        }
    }
}

void InserirVenda()
{
    Venda venda = new Venda();

    Console.WriteLine("Digite a Placa");
    venda.Carro = GetCarro(Console.ReadLine());

    venda.DataVenda = DateTime.Now;

    Console.WriteLine("Digite o valor da Venda");
    venda.ValorVenda = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Digite o documento do cliente");
    venda.Cliente = GetCliente(Console.ReadLine());

    Console.WriteLine("Digite o documento do Funcionario");
    venda.Funcionario = GetFuncionario(Console.ReadLine());

    Console.WriteLine("Digite o Id do pagamento");
    venda.Pagamento = GetPagamento(int.Parse(Console.ReadLine()));

    if (new GaragemController().InserirVenda(venda))
    {
        Console.WriteLine("Inserido");
    }
    else
    {
        Console.WriteLine("Erro");
    }
}

Pagamento GetPagamento(int v)
{
    Pagamento pix = new GaragemController().GetPagamento(v);

    return pix;
}

Funcionario GetFuncionario(string? v)
{
    Funcionario pix = new GaragemController().GetFuncionario(v);

    return pix;
}

Cliente GetCliente(string? v)
{
    Cliente pix = new GaragemController().GetCliente(v);

    return pix;
}

void InserirCompra()
{
    Compra compra = new Compra();

    Console.WriteLine("Digite a Placa");
    compra.Carro = GetCarro(Console.ReadLine());

    Console.WriteLine("Digite o Preco");
    compra.Preco = decimal.Parse(Console.ReadLine());

    compra.DataCompra = DateTime.Now;

    if (new GaragemController().InserirCompra(compra))
    {
        Console.WriteLine("Inserido");
    }
    else
    {
        Console.WriteLine("Erro");
    }
}

void InjetarCliente()
{
    Cliente cliente = new Cliente();

    Console.WriteLine("Escreva seu CPF");
    cliente.Documento = Console.ReadLine();

    Console.WriteLine("Escrava a Renda do Cliente");
    cliente.Renda = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Escrava o Id do Endereco");
    cliente.Endereco = GetEnd(int.Parse(Console.ReadLine()));

    Console.WriteLine("Digite o Nome");
    cliente.Nome = Console.ReadLine();

    Console.WriteLine("Digite o ano de nascimento");
    cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Digite o Telefone");
    cliente.Telefone = Console.ReadLine();

    Console.WriteLine("Digite o Email");
    cliente.Email = Console.ReadLine();

    if (new GaragemController().InjetarCliente(cliente))
    {
        Console.WriteLine("Inserido");
    }
    else
    {
        Console.WriteLine("Erro");
    }
}

void InjetarFuncionario()
{
    Funcionario fun = new Funcionario();

    Console.WriteLine("Escreva seu CPF");
    fun.Documento = Console.ReadLine();

    Console.WriteLine("Escrava o Id do Cargo");
    fun.Cargo = GetCargo(int.Parse(Console.ReadLine()));

    Console.WriteLine("Escrava o Id do Endereco");
    fun.Endereco = GetEnd(int.Parse(Console.ReadLine()));

    Console.WriteLine("Digite o Valor da Comissao");
    fun.ValorComissao = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Digite a Comissao");
    fun.Comissao = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Digite o Nome");
    fun.Nome = Console.ReadLine();

    Console.WriteLine("Digite o ano de nascimento");
    fun.DataNascimento = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Digite o Telefone");
    fun.Telefone = Console.ReadLine();

    Console.WriteLine("Digite o Email");
    fun.Email = Console.ReadLine();

    if (new GaragemController().InjetarFuncionario(fun))
    {
        Console.WriteLine("Inserido");
    }
    else
    {
        Console.WriteLine("Erro");
    }
}

Endereco GetEnd(int v)
{
    Endereco pix = new GaragemController().GetEnd(v);

    return pix;
}

Cargo GetCargo(int v)
{
    Cargo pix = new GaragemController().GetCargo(v);

    return pix;
}

void InjetarPagamento()
{
    Pagamento pagamento = new Pagamento();

    Console.WriteLine("Insira o numero do cartão");
    pagamento.Cartao = GetCartao(Console.ReadLine());

    Console.WriteLine("Insira o id do Boleto");
    pagamento.Boleto = GetBoleto(Console.ReadLine());

    Console.WriteLine("Insira o id do Pix");
    pagamento.Pix = GetPix(Console.ReadLine());

    pagamento.DataPagamento = DateTime.Now;

    if (new GaragemController().InjetarPagamento(pagamento))
    {
        Console.WriteLine("Inserido");
    }
    else
    {
        Console.WriteLine("Erro");
    }
}

Pix GetPix(string? v)
{
    Pix pix = new GaragemController().GetPix(v);

    return pix;
}

Boleto GetBoleto(string? v)
{
    Boleto pix = new GaragemController().GetBoleto(v);

    return pix;
}

Cartao GetCartao(string? v)
{
    Cartao pix = new GaragemController().GetCartao(v);

    return pix;
}

void InjetarPix()
{
    Pix pix = new Pix();

    Console.WriteLine("Digite a chave Pix");
    pix.ChavePix = Console.ReadLine();

    Console.WriteLine("Digite o Id do Tipo Pix");
    pix.Tipo = GetTipoPix(int.Parse(Console.ReadLine()));

    if (new GaragemController().InserirPix(pix))
    {
        Console.WriteLine("Inserido");
    }
    else
    {
        Console.WriteLine("Erro");
    }
}

TipoPix GetTipoPix(int v)
{
    TipoPix pix = new GaragemController().GetTipoPix(v);

    return pix;
}

void InjetarCargoServico()
{
    CarroServico carroServico = new CarroServico();

    Console.WriteLine("Digite a placa do carro");

    carroServico.Carro = GetCarro(Console.ReadLine());

    Console.WriteLine("Digite o id do Servico");

    carroServico.Servico = GetServico(int.Parse(Console.ReadLine()));

    if (new GaragemController().InserirCarroServico(carroServico))
    {
        Console.WriteLine("Inserido");
    }
    else
    {
        Console.WriteLine("Erro");
    }
}

Servico GetServico(int v)
{
    Servico servico = new GaragemController().GetServico(v);

    return servico;
}

Carro GetCarro(string? v)
{
    Carro carro = new GaragemController().GetCarro(v);

    return carro;

}

void InjetarDadosIniciais()
{
    List<Carro> carros = new List<Carro>();

    List<Boleto> boletos = new List<Boleto>();

    List<Cartao> cartoes = new List<Cartao>();

    List<Endereco> enderecos = new List<Endereco>();

    List<Servico> servicos = new List<Servico>
            {
                new Servico {  Descricao = "Lavagem" },
                new Servico {  Descricao = "Pintura" },
                new Servico {  Descricao = "Manutenção" },
                new Servico {  Descricao = "Troca de Óleo" },
                new Servico {  Descricao = "Revisão de Freios" },
                new Servico {  Descricao = "Alinhamento e Balanceamento" },
                new Servico {  Descricao = "Substituição de Pneus" },
                new Servico {  Descricao = "Troca de Bateria" },
                new Servico {  Descricao = "Revisão Elétrica" },
                new Servico {  Descricao = "Revisão de Suspensão" }
            };

    List<Cargo> cargos = new List<Cargo>
            {
                new Cargo { Descricao = "Gerente" },
                new Cargo { Descricao = "Vendedor" },
                new Cargo { Descricao = "Mecânico" },
                new Cargo { Descricao = "Lavador de Carros" },
                new Cargo { Descricao = "Recepcionista" },
                new Cargo { Descricao = "Auxiliar de Serviços Gerais" },
                new Cargo { Descricao = "Contador" }
            };

    List<TipoPix> tiposPix = new List<TipoPix>
            {
                new TipoPix { Nome = "CPF" },
                new TipoPix { Nome = "Telefone" },
                new TipoPix { Nome = "E-mail" },
                new TipoPix { Nome = "Chave Aleatória" },
                new TipoPix { Nome = "CNPJ" },
                new TipoPix { Nome = "Chave Pix" },
                new TipoPix { Nome = "Outro" }
            };

    for (int i = 0; i < 30; i++)
    {
        carros.Add(GerarCarro());
        boletos.Add(GerarBoleto());
        cartoes.Add(GerarCartoes());
        enderecos.Add(GerarEnderecos());
    }

    new GaragemController().InserirCarro(carros);
    new GaragemController().InserirBoleto(boletos);
    new GaragemController().InserirCartoes(cartoes);
    new GaragemController().InserirEndereco(enderecos);
    new GaragemController().InserirServicos(servicos);
    new GaragemController().InserirCargos(cargos);
    new GaragemController().InserirTipoPix(tiposPix);

}

Endereco GerarEnderecos()
{
    Endereco endereco = new Endereco
    {
        Logradouro = $" {GerarNomeAleatorio()}",
        CEP = $"{new Random().Next(10000000, 99999999)}",
        Bairro = GerarNomeAleatorio(),
        TipoLogradouro = new Random().Next(2) == 0 ? "Rua" : "Avenida",
        Complemento = GerarComplementoAleatorio(),
        Numero = new Random().Next(1, 1000),
        Uf = GerarEstado(),
        Cidade = GerarCidade()
    };

    return endereco;
}
string GerarCidade()
{
    string[] nomes = { "São Paulo","Curitiba", "Belo Horizonte", "Vitória", "Rio de Janeiro" };
    Random random = new Random();
    return nomes[random.Next(nomes.Length)];
}
string GerarEstado()
{
    string[] nomes = { "SP", "MG", "ES", "RJ" };
    Random random = new Random();
    return nomes[random.Next(nomes.Length)];
}
string GerarNomeAleatorio()
{
    string[] nomes = { "Rua A", "Rua B", "Rua C", "Rua D", "Rua E", "Rua F", "Rua G", "Rua H", "Rua I", "Rua J" };
    Random random = new Random();
    return nomes[random.Next(nomes.Length)];
}
string GerarComplementoAleatorio()
{
    string[] complementos = { "Casa", "Apartamento", "Loja", "Sala", "Bloco A", "Bloco B", "Bloco C" };
    Random random = new Random();
    return complementos[random.Next(complementos.Length)];
}
Cartao GerarCartoes()
{
    List<string> nomesCartao = GerarNomesCartao();

    Cartao cartao = new Cartao
    {
        NumeroCartao = GerarNumeroCartao(),
        CodigoSeguranca = new Random().Next(100, 999).ToString(),
        DataValidade = new Random().Next(1990, DateTime.Now.Year + 2).ToString(),
        NomeCartao = nomesCartao[new Random().Next(nomesCartao.Count)]
    };


    return cartao;
}
string GerarNumeroCartao()
{
    string numeroCartao = "";
    for (int i = 0; i < 4; i++)
    {
        numeroCartao += new Random().Next(1000, 9999).ToString();
        if (i < 3)
        {
            numeroCartao += " ";
        }
    }
    return numeroCartao;
}
string GerarCor()
{
    string[] cores = {
            "Preto",
            "Branco",
            "Cinza",
            "Prata",
            "Vermelho",
            "Azul",
            "Verde",
            "Amarelo",
            "Roxo",
            "Marrom"
    };
    return cores[new Random().Next(0, cores.Length)];
}
string GerarNome()
{
    string[] nomes = new string[]
    {
            "Ford Mustang",
            "Chevrolet Camaro",
            "Dodge Charger",
            "Toyota Corolla",
            "Honda Civic",
            "BMW 3 Series",
            "Audi A4",
            "Mercedes-Benz C-Class",
            "Volkswagen Golf",
            "Nissan Altima",
            "Hyundai Elantra",
            "Kia Optima",
            "Subaru Impreza",
            "Mazda 3",
            "Tesla Model 3",
            "Lexus IS",
            "Jaguar XE",
            "Infiniti Q50",
            "Acura TLX",
            "Cadillac ATS",
            "Alfa Romeo Giulia",
            "Volvo S60",
            "Mitsubishi Lancer",
            "Mini Cooper",
            "Porsche 911",
            "Ferrari 488",
            "Lamborghini Huracan",
            "McLaren 720S",
            "Aston Martin Vantage",
            "Rolls-Royce Phantom"
    };

    return nomes[new Random().Next(0, nomes.Length)];
}
string GerarPlaca()
{
    string placa = "";
    string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    placa += letras[new Random().Next(0, letras.Length)];
    placa += letras[new Random().Next(0, letras.Length)];
    placa += letras[new Random().Next(0, letras.Length)];
    placa += new Random().Next(0, 10).ToString();
    placa += letras[new Random().Next(0, letras.Length)];
    placa += new Random().Next(0, 10).ToString();
    placa += new Random().Next(0, 10).ToString();

    return placa;
}
Carro GerarCarro()
{
    int anoModelo = new Random().Next(1990, DateTime.Now.Year + 2);
    int anoFabricacao = new Random().Next(anoModelo - 1, DateTime.Now.Year);

    Carro carro = new Carro
    {
        Placa = GerarPlaca(),
        Nome = GerarNome(),
        AnoModelo = anoModelo,
        AnoFabricacao = anoFabricacao,
        Cor = GerarCor(),
        Vendido = new Random().Next(2) == 0
    };
    return carro;
}
Boleto GerarBoleto()
{
    Boleto boleto = new Boleto
    {
        Numero = new Random().Next(100000, 999999),
        DataVencimento = (DateTime.Today).AddDays(new Random().Next(1, 365))
    };
    return boleto;
}
static List<string> GerarNomesCartao()
{
    return new List<string>
            {
                "João Silva", "Maria Souza", "Carlos Pereira", "Ana Oliveira", "Pedro Santos",
                "Lucas Lima", "Fernanda Costa", "Juliana Almeida", "Marcos Fernandes", "Carla Rodrigues",
                "Roberto Dias", "Patricia Mendes", "Ricardo Gonçalves", "Tatiana Moraes", "Claudio Martins",
                "Cristina Araujo", "Fábio Ribeiro", "Sabrina Ferreira", "Renato Carvalho", "Amanda Castro",
                "Felipe Teixeira", "Monica Rocha", "Gabriel Barros", "Elaine Nascimento", "Igor Duarte",
                "Alice Cardoso", "Rafael Monteiro", "Aline Rezende", "Gustavo Farias", "Camila Souza",
                "Daniel Costa", "Larissa Gomes", "Thiago Almeida", "Bianca Fernandes", "Leandro Lopes",
                "Renata Correia", "Eduardo Azevedo", "Vitoria Braga", "César Moreira", "Tatiane Santana",
                "Fernando Oliveira", "Luciana Silva", "Rodrigo Souza", "Mariana Barros", "André Almeida",
                "Julio Santos", "Tatiana Lima", "Carlos Rodrigues", "Sofia Mendes", "Rafael Ferreira"
            };
}
