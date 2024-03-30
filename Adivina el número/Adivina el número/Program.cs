using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Adivina el número");

        StartGame();
    }

    static void StartGame()
    {
        Console.WriteLine("Hola, Bienvenido al juego de Adivina el número...");
        Console.WriteLine("Como te llamas?");

        var namePlayer = Console.ReadLine();
        WantToPlay(namePlayer);
    }

    static void WantToPlay(string? namePlayer)
    {
        Console.WriteLine($"Hola {namePlayer}, ¿estás listo? (Escribe SI/NO)");

        var wantToPlay = Console.ReadLine();

        switch (wantToPlay?.ToLower())
        {
            case "si":
                Play();
                break;
            case "no":
                DontPlay();
                break;
            default:
                Console.WriteLine("Por favor, deja de hacer el troll y escribe sólo SI o NO");
                WantToPlay(namePlayer);
                break;
        }
    }

    static void Play()
    {
        // Aquí debes implementar la lógica del juego
        // Genera un número aleatorio y pide al jugador que adivine
        // Proporciona pistas y sigue iterando hasta que adivinen o se rindan
        Console.WriteLine("¡Comencemos a jugar!");
        // Agrega aquí la lógica para adivinar el número
    }

    static void DontPlay()
    {
        Console.WriteLine("¡Hasta luego! Gracias por jugar.");
    }
}



