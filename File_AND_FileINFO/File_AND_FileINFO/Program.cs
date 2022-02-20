CriarDiretoriosGlobo();
CriarArquivo();

var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory, "globo", "America do Sul", "Brasil", "brasil.txt");

MoverArquivo(origem, destino);
CopiarArquivo(origem, destino);

static void CopiarArquivo(string pathOrigem, string pathDestino)
{
    File.Copy(pathOrigem, pathDestino);
}

static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe");
        return;
    }
    if (File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo de destino já existe");
        return;
    }

    File.Move(pathOrigem, pathDestino);
}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 213MM");
        sw.WriteLine("IDH: 0,901");
        sw.WriteLine("Dados Atualizados em: 20/04/1985");
    }
}
static void CriarDiretoriosGlobo()
{

    var path = Path.Combine(Environment.CurrentDirectory, "globo");
    if (!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path);
        var dirAmNorte = dirGlobo.CreateSubdirectory("america do norte");
        var dirAmCentral = dirGlobo.CreateSubdirectory("america do Central");
        var dirAmSul = dirGlobo.CreateSubdirectory("america do Sul");

        dirAmNorte.CreateSubdirectory("USA");
        dirAmNorte.CreateSubdirectory("Mexico");
        dirAmNorte.CreateSubdirectory("Canada");

        dirAmCentral.CreateSubdirectory("Costa rica");
        dirAmCentral.CreateSubdirectory("Panama");

        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Paraguai");

    }
}






