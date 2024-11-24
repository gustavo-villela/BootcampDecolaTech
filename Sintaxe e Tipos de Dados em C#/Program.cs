using Exemplo.Models;

DateTime dataAtual = DateTime.Now.AddDays(0);
Console.WriteLine("Data de hoje: " + dataAtual.ToString("MM/dd/yyyy HH:mm\n"));

// string variavel = "Bem vindo.";
// int quantidade = 2;
// double altura = 1.80;
// decimal preco = 1.85M;
// bool condicao = true;

// Console.WriteLine($"String: {variavel}");
// Console.WriteLine("Quantidade: " + quantidade);
// Console.WriteLine($"Altura: {altura.ToString("0.00")}");
// Console.WriteLine(preco);
// Console.WriteLine(condicao);

Pessoa pessoa = new Pessoa();

pessoa.Nome = "Gustavo";
pessoa.Idade = 27;
pessoa.Apresentar();

// int varival = 23;
// int total = varival / 2;
// varival = total;