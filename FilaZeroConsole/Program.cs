Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Title = "FilaZero - Sistema de Login" ;



DesenharTela();
ExecutarLogin();

static void DesenharTela()
{
    Console.Clear();
    Console.WriteLine("=====================================");
    Console.WriteLine("         Fila Zero - Login           ");
    Console.WriteLine("=====================================");
}

static void ExecutarLogin()
{
    Console.Write("Digite seu nome de usuário: ");
    string username = Console.ReadLine();

    Console.Write("Digite sua senha: ");
    string password = Console.ReadLine();

    // Simulação de validação de login
    if (username == "admin" && password == "senha123")
    {
        Console.WriteLine("\nLogin bem-sucedido! Bem-vindo, admin.");
    }
    else
    {
        Console.WriteLine("\nLogin falhou! Nome de usuário ou senha incorretos.");
    }
}
Console.ReadLine();