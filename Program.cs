//menú
Console.WriteLine("Seleccione una opción: ");
Console.WriteLine("1. Opción 1");
Console.WriteLine("2. Opción 2");
Console.WriteLine("3. Opción 3");   

//mostrar la opción seleccionada entre 1 y 3 y mostrar error si no existe la opción y repetir hasta que se seleccione una opción válida
int opcion;
bool opcionValida = false;

while (!opcionValida)
{
    opcion = int.Parse(Console.ReadLine());
    if (opcion >= 1 && opcion <= 3)
    {
        Console.WriteLine($"Opción seleccionada: {opcion}");
        opcionValida = true;
    }
    else
    {
        Console.WriteLine("¡Error! Seleccione una opción válida.");
    }
}
