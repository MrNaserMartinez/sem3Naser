using System;
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
            Console.WriteLine("Número no reconocido.\n");
            return;
    }

    Console.WriteLine($"El número en dígitos es: {digi}\n");
}catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese un número válido.\n");
}

try
{
    Console.WriteLine("*2 El día de la semana\n");
    Console.WriteLine("Pon un numero del 1 al 7 para ver tu día");
    int dian = Convert.ToInt32(Console.ReadLine());
    string dayfinal;

    switch (dian)
    {
        case 1:
            dayfinal = "lunes";
            break;
        case 2:
            dayfinal = "martes";
            break;
        case 3:
            dayfinal = "miercoles";
            break;
        case 4:
            dayfinal = "jueves";
            break;
        case 5:
            dayfinal = "viernes";
            break;
        case 6:
            dayfinal = "sabado";
            break;
        case 7:
            dayfinal = "domingo";
            break;
        default:
            Console.WriteLine("Número no reconocido.\n");
            return;
    }
    Console.WriteLine($"El día que dijiste es: {dayfinal}\n");
}
catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese un número válido.\n");
}

