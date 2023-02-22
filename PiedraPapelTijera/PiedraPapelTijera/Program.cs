while(true)
{
    Console.WriteLine("Estas listo'");
    Console.WriteLine("Empezamos!!");

    var seleccionusuario = SeleccionDeUsuario();
    var tuEleccion = char.Parse(seleccionusuario);

    Console.WriteLine($"Elegiste {tuEleccion}");

    var opcionDeOponente = OpcionOponente();

    Console.WriteLine($"Tu oponente eligió {opcionDeOponente}");

    decidirGanador(opcionDeOponente, tuEleccion);

}

string SeleccionDeUsuario()
{
    Console.WriteLine("Elige Piedra(R), Papel(P) o Tijera(T): ");
    var seleccionUsuario = Console.ReadLine();

    if (seleccionUsuario?.ToLower() != "r" && seleccionUsuario?.ToLower() != "p" && seleccionUsuario?.ToLower() != "t")
    {
        Console.WriteLine("Por favor seleciona solo una letra; R, P o T");
        seleccionUsuario = SeleccionDeUsuario();
    }

    return seleccionUsuario;
}

char OpcionOponente()
{
    char[] opciones = new char[] { 'R', 'P', 'T' };

    Random random = new Random();
    int randomIndex = random.Next(0, opciones.Length);

    return opciones[randomIndex];
}

void decidirGanador(char opcionDeOponente, char tuEleccion)
{
    if (opcionDeOponente == tuEleccion)
    {
        Console.WriteLine("Empate!!");
        return;
    }

    switch (tuEleccion)
    {
        case 'R':
        case 'r':
            if (opcionDeOponente == 'P')
                Console.WriteLine("Papel gana a piedra, Yo gano!!");
            else if (opcionDeOponente == 'T')
                Console.WriteLine("Piedra gana a tijeras, Tu ganas!!");
            break;

        case 'T':
        case 't':
            if (opcionDeOponente == 'P')
                Console.WriteLine("Tijeras gana a papel, Tu ganas!!");
            else if (opcionDeOponente == 'R')
                Console.WriteLine("Piedra gana a tijeras, Yo gano!!");
            break;

        case 'P':
        case 'p':
            if (opcionDeOponente == 'T')
                Console.WriteLine("Tijeras gana a papel, Yo gano!!");
            else if (opcionDeOponente == 'R')
                Console.WriteLine("Papel gana a piedra, Tu ganas!!");
            break;
    }
}