using DesafioPOO.Models;

var smartphoneNokia = new Nokia("+55 11 91111-2222", "Nokia1", "7777/8888", 1024);
var smartphoneApple = new Iphone("+55 11 93333-4444", "Iphone1", "9999/9090", 2048);

ExecutarMenuPrincipal(smartphoneNokia, smartphoneApple);


static void ExecutarMenuPrincipal(Smartphone smartphone, Smartphone smartphone2)
{
    string opcao = string.Empty;
    bool exibirMenu = true;

    // Realiza o loop do menu
    while (exibirMenu)
    {
        Console.Clear();
        Console.WriteLine("Digite a sua opção:");
        Console.WriteLine($"1 - Escolher smartphone: {smartphone}");
        Console.WriteLine($"2 - Escolher smartphone: {smartphone2}");
        Console.WriteLine("3 - Encerrar");

        switch (Console.ReadLine())
        {
            case "1":
                ExecutarSubMenu(smartphone);
                break;

            case "2":
                ExecutarSubMenu(smartphone2);
                break;

            case "3":
                exibirMenu = false;
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
    }

    Console.WriteLine("O programa se encerrou");
}

static void ExecutarSubMenu(Smartphone smartphone)
{
    string opcao = string.Empty;
    bool exibirMenu = true;

    // Realiza o loop do menu
    while (exibirMenu)
    {
        Console.Clear();
        Console.WriteLine($"Smartphone: {smartphone}");
        Console.WriteLine("Digite a sua opção:");
        Console.WriteLine($"4 - Para Ligar");
        Console.WriteLine($"5 - Para Receber Ligação");
        Console.WriteLine($"6 - Instalar App");
        Console.WriteLine("7 - Encerrar submenu");

        switch (Console.ReadLine())
        {
            case "4":
                smartphone.Ligar();
                break;

            case "5":
                smartphone.ReceberLigacao();
                break;

            case "6":
                Console.WriteLine("Digite o nome do aplicativo:");
                var app = Console.ReadLine();
                smartphone.InstalarAplicativo(app);
                break;

            case "7":
                return;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
    }
}