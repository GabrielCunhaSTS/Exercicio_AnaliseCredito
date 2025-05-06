double valorEmprestimo, rendaMensal;
int quantidadeParcelas;

Console.WriteLine("------ Bem-vindo(a) ao programa para solicitação de empréstimo ------");

Console.Write("Digite o valor do empréstimo desejado em R$: ");
while (!double.TryParse(Console.ReadLine(), out valorEmprestimo) || valorEmprestimo <= 0)
{
    Console.Write("Valor inválido. Digite novamente (um valor positivo em R$): ");
}

Console.Write("Digite a quantidade de parcelas que deseja: ");
while (!int.TryParse(Console.ReadLine(), out quantidadeParcelas) || quantidadeParcelas <= 0)
{
    Console.Write("Quantidade de parcelas inválida. Digite um número inteiro positivo: ");
}

Console.Write("Digite sua renda mensal comprovada em R$: ");
while (!double.TryParse(Console.ReadLine(), out rendaMensal) || rendaMensal <= 0)
{
    Console.Write("Renda inválida. Digite um valor positivo em R$: ");
}

double valorParcela = valorEmprestimo / quantidadeParcelas;
double limiteParcela = rendaMensal * 0.30;

Console.WriteLine($"\nValor de cada parcela das {quantidadeParcelas}: R$ {valorParcela:F2}");
Console.WriteLine($"30% da sua renda mensal é: R$ {limiteParcela:F2}");

if (valorParcela <= limiteParcela)
{
    Console.WriteLine("Empréstimo autorizado!");
}else{
  
    Console.WriteLine("Empréstimo negado. O valor da parcela é maior que 30% da sua renda");
}

Console.Write("Digite qualquer tecla para finalizar o programa!");
Console.ReadKey();
Console.Clear();