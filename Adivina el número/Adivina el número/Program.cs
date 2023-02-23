Console.WriteLine("Adivina el nùmero");

StartGame();

void StartGame()
{
    Console.WriteLine("Hola, Bienvenido al juego de Adivina el número...");
    Console.WriteLine("Como te llamas?");

    var namePlayer = Console.ReadLine();
    Console.WriteLine($"Hola {namePlayer} estás listo? (Escribe SI/NO)");

    var wantToPlay = Console.ReadLine();

    switch (wantToPlay?.ToLower())
    {
        case "yes":
            Play();
            break;
        case "no":
            DontPlay();
            break;
        default:
            Console.WriteLine("Por favor, deja de hacer el troll y escribe sólo SI o NO");
            break;
    }
}

void Play()
{

}

void DontPlay()
{

}

