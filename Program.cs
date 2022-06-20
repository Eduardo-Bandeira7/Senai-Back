using er2.classes;

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

Console.WriteLine(@$"
    Nome: {novaPf.Nome}
    Endereço: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.Numero}
    Maior de Idade: {metodosPf.ValidarDataNasc(novaPf.DataNasc)}
");


// Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");//Interpolação
// Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome);//Concatenção


