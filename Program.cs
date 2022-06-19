using er2.classes;

PessoaFisica novaPf = new PessoaFisica();
novaPf.Nome = "Eduardo";

Console.WriteLine(novaPf.Nome);
Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");//Interpolação
Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome);//Concatenção


