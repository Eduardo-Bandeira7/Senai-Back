using er2.classes;

Console.Clear();
Console.WriteLine(@$"
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
|    Bem vindo ao Sistema de Cadastro de |
|       Pessosas Físicas e Jurídcas      |
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    
");

Utils.LoadingBar("Iniciando", 100, 40);

List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
|       Escolha uma das opções abaixo    |
|----------------------------------------|
|           1) Pessoa Fisica             |
|           2) Pessoa Juridica           |
|                                        |
|           0) Sair                      |
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
");

    opcao = Console.ReadLine();


    switch (opcao)
    {
        case "1":

            string? opcaoPF;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
|       Escolha uma das opções abaixo    |
|----------------------------------------|
|           1)Cadastrar Pessoa Fisica    |
|           2)Listar Pessoas Fisicas     |
|                                        |
|           0) Voltar                    |
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
");

                opcaoPF = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPF)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa fisica que deseja cadastrar:");
                        novaPf.Nome = Console.ReadLine();

                        bool DataValida;
                        do
                        {
                            Console.WriteLine($"Digite sua data de nascimento: Ex:dd/mm/aaaa");
                            string? DataNascimento = Console.ReadLine();

                            DataValida = metodosPf.ValidarDataNasc(DataNascimento);

                            if (DataValida)
                            {
                                DateTime DataConvertida;
                                DateTime.TryParse(DataNascimento, out DataConvertida);
                                novaPf.DataNasc = DataConvertida;

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digitada inválida, por favor digite uma data válida");
                                Console.ResetColor();
                                Thread.Sleep(3000);
                            }

                        } while (DataValida == false);

                        Console.WriteLine($"Digite o número do CPF:");
                        novaPf.Cpf = Console.ReadLine();

                        Console.WriteLine($"Digite seu rendimento mensal:(SOMENTE NÚEMROS)");
                        novaPf.Rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Sigite seu logradouro:");
                        novoEndPf.Logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número:");
                        novoEndPf.Numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Complemento: (ENTER PARA VAZIO)");
                        novoEndPf.Complemento = Console.ReadLine();

                        Console.WriteLine($"O endereço é comercial? S/N");
                        string EndCom = Console.ReadLine().ToUpper();
                        if (EndCom == "S")
                        {
                            novoEndPf.endComercial = true;
                        }
                        else
                        {
                            novoEndPf.endComercial = false;
                        }
                        novaPf.Endereco = novoEndPf;

                        listaPf.Add(novaPf);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;

                    case "2":
                        Console.Clear();

                        if (listaPf.Count > 0)
                        {
                            foreach (PessoaFisica CadaPessoa in listaPf)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
    Nome: {CadaPessoa.Nome}
    Endereço: {CadaPessoa.Endereco.Logradouro}, {CadaPessoa.Endereco.Numero}
    Imposto a ser pago: {metodosPf.PagarImposto(CadaPessoa.Rendimento).ToString("C")}
");

                                Console.WriteLine($"Aperte ENTER para continuar");
                                Console.ReadLine();

                            }
                        }
                        else
                        {
                            Console.WriteLine($"Lista vazia :/");
                            Thread.Sleep(3000);
                        }
                        break;

                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção inválida");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }
            } while (opcaoPF != "0");

            // IF TERNÁRIO = Consição ? "Sim" : "Não" só verifica se for verdadeiro ou falso

            //          Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");//Interpolação
            //           Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome);//Concatenção


            break;

        case "2":

            string? OpcaoPj;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
|       Escolha uma das opções abaixo    |
|----------------------------------------|
|           1)Cadastrar Pessoa Jurídica  |
|           2)Listar Pessoas Jurídias    |
|                                        |
|           0) Voltar                    |
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
");

                OpcaoPj = Console.ReadLine();
                PessoaJuridica metodosPj = new PessoaJuridica();

                switch (OpcaoPj)
                {
                    case "1":

                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEndPj = new Endereco();

                        Console.WriteLine($"Digite Seu Nome:");
                        novaPj.Nome = Console.ReadLine();

                        Console.WriteLine($"Digite seu CNPJ:");
                        novaPj.Cnpj = Console.ReadLine();

                        Console.WriteLine($"Digite a razão social:");
                        novaPj.RazaoSocial = Console.ReadLine();

                        Console.WriteLine($"Agora, seu rendimento mensal:");
                        novaPj.Rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Insira seu logradouro:");
                        novoEndPj.Logradouro = Console.ReadLine();

                        Console.WriteLine($"n° do endereço:");
                        novoEndPj.Numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Complemento do endereço:(ENTER PARA VAZIO)");
                        novoEndPj.Complemento = Console.ReadLine();

                        Console.WriteLine($"Endereço comercial? S/N");
                        string EndCom = Console.ReadLine().ToUpper();

                        if (EndCom == "S")
                        {
                            novoEndPj.endComercial = true;
                        }
                        else
                        {
                            novoEndPj.endComercial = false;
                        }

                        novaPj.Endereco = novoEndPj;

                        listaPj.Add(novaPj);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;

                    case "2":
                        Console.Clear();

                        if (listaPj.Count > 0)
                        {
                            foreach (PessoaJuridica PessoaPj in listaPj)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
    Nome: {PessoaPj.Nome}
    Endereço: {PessoaPj.Endereco.Logradouro} N°: {PessoaPj.Endereco.Numero}
    Razão Social: {PessoaPj.RazaoSocial}
    CNPJ: {PessoaPj.Cnpj}, Valido: {(metodosPj.ValidarCnpj(PessoaPj.Cnpj) ? "Sim" : "Não")} 
    Complemento: {PessoaPj.Endereco.Complemento}
");

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"Aperte ENTER para continuar");
                                Console.ReadLine();
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Lista vazia :/");
                            Thread.Sleep(3000);
                        }
                        break;
                        case "0":

                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção inválida");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }


            } while (OpcaoPj != "0");
            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso Sistema!");
            Thread.Sleep(2000);
            Utils.LoadingBar("Finalizando", 500, 6);
            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção inválida");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }
} while (opcao != "0");

// static void LoadingBar(string texto, int tempo, int quantidade)
// {
//     Console.BackgroundColor = ConsoleColor.Black;
//     Console.ForegroundColor = ConsoleColor.Green;
//     Console.Write(texto);
//     for (var contador = 0; contador < quantidade; contador++)
//     {
//         Console.Write(".");
//         Thread.Sleep(tempo);
//     }
//     Console.ResetColor();
// }