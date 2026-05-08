
Console.WriteLine("Digite sua Idade");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Você é maior de Idade");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Você é menor de Idade");
}
Console.ResetColor();
