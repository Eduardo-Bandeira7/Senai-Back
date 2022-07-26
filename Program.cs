using er2.classes;

Console.Clear();
Console.WriteLine(@$"
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
|    Bem vindo ao Sistema de Cadastro de |
|       Pessosas Físicas e Jurídcas      |
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~    
");

Utils.LoadingBar("Iniciando", 100, 40);

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
            PessoaFisica novaPf = new PessoaFisica();
            PessoaFisica metodosPf = new PessoaFisica();
            Endereco novoEndPf = new Endereco();

            novaPf.Nome = "Eduardo";
            novaPf.DataNasc = new DateTime(2000, 01, 01);
            novaPf.Cpf = "1234567890";
            novaPf.Rendimento = 3500.5f;

            novoEndPf.Logradouro = "Ruas dos Alfaiates";
            novoEndPf.Numero = 445;
            novoEndPf.Complemento = "Loja de Jóias";
            novoEndPf.endComercial = true;

            novaPf.Endereco = novoEndPf;

            Console.Clear();
            Console.WriteLine(@$"
    Nome: {novaPf.Nome}
    Endereço: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.Numero}
    Maior de Idade: {metodosPf.ValidarDataNasc(novaPf.DataNasc)}
");
            //          Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");//Interpolação
            //           Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome);//Concatenção

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();
            Console.ResetColor();


            break;

        case "2":

            PessoaJuridica novaPj = new PessoaJuridica();
            PessoaJuridica metodosPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.Nome = "Carlos";
            novaPj.Cnpj = "13.654.897/0001-52";
            novaPj.RazaoSocial = "Mais Sabor Salgados";
            novaPj.Rendimento = 20120.8f;

            novoEndPj.Logradouro = "Avenida das flores";
            novoEndPj.Numero = 2125;
            novoEndPj.Complemento = "Padaria";
            novoEndPj.endComercial = true;

            novaPj.Endereco = novoEndPj;

            Console.Clear();
            Console.WriteLine(@$"
    Nome: {novaPj.Nome}
    Endereço: {novaPj.Endereco.Logradouro} N°: {novaPj.Endereco.Numero}
    Razão Social: {novaPj.RazaoSocial}
    CNPJ: {novaPj.Cnpj}, Valido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
    Complemento: {novaPj.Endereco.Complemento}
");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();
            Console.ResetColor();
            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso Sistema!");
            Thread.Sleep(3000);
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