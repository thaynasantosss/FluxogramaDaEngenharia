Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("*** Fluxograma Da Engenharia ***");
Console.WriteLine();


Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("O objeto está se movendo ?(digite Sim ou Não) ");
bool estaSeMovendo = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";


Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Deveria? ");
bool deveria = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

string mensagem;

if (!estaSeMovendo)
{
    if (!deveria)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        mensagem = "Ótimo!";
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        mensagem = "Use WD-40.";
    }
}
else
{
    if (deveria)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        mensagem = "Ótimo!";
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        mensagem = "Use Silver Tape.";
    }
}
Console.ResetColor();
Console.WriteLine();
Console.WriteLine(mensagem);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("clique para brincar novamente");
Console.ReadKey();
Console.ResetColor();
Console.Clear();

