Console.WriteLine("Hello, World!");

while(true)
{
    Console.WriteLine("Estas listo'");
    Console.WriteLine("Empezamos!!");

    var seleccionusuario = SeleccionDeUsuario();
    var tuEleccion = char.Parse(seleccionusuario);

    Console.WriteLine($"Elegiste {tuEleccion}");

    var opcionDeOponente = OpcionOponente();

    Console.WriteLine($"Tu oponente eligió {opcionDeOponente}");
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