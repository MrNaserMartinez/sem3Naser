using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("BIEVENIDO AL SISTEMA DE SWITCH\n\n");

try
{
    Console.WriteLine("*1 De Numero a letra");
    Console.WriteLine("Ingresa un número del 1 al 5 en letras (uno, dos, tres, cuatro, cinco):");
    string numero = Console.ReadLine().ToLower();
    int digi;

    switch (numero)
    {
        case "uno":
            digi = 1;
            break;
        case "dos":
            digi = 2;
            break;
        case "tres":
            digi = 3;
            break;
        case "cuatro":
            digi = 4;
            break;
        case "cinco":
            digi = 5;
            break;
        default:
            Console.WriteLine("Número no reconocido.");
            return;
    }

    Console.WriteLine($"El número en dígitos es: {digi}");
}
catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese un número válido.");
}