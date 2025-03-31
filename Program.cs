string PalavraSecreta = "";

Console.Write("Palavra Secreta: ");
PalavraSecreta = Console.ReadLine()!;

Console.Write("Letra: ");
char Letra = char.Parse(Console.ReadLine()!.Trim().Substring(0,1).ToLower());

Console.WriteLine($"A letra {Letra} existe na palavra secreta? => {PalavraSecreta.Contains(Letra)}");
