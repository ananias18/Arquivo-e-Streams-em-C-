using static System.Console;

WriteLine("digite o nome do aquivo:");

var nome = ReadLine();

nome = LimparNome(nome);

foreach (var @char in Path.GetInvalidFileNameChars())
{
    nome = nome.Replace(@char, '-');
}
var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path);

WriteLine("Digite enter para finalizar");
ReadLine();

static string LimparNome(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
{
    nome = nome.Replace(@char, '-');
}
return nome;
}
static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("escreva aqui 1");
        sw.WriteLine("escreva aqui 2");
        sw.WriteLine("escreva aqui 3");

    }
    catch
    {
        WriteLine("O nome do arquivo esta invalido!");
    }
}