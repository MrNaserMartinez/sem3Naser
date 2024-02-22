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
}catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese un número válido.\n");
}

try
{
    Console.WriteLine("*3 Veamos tu servicio\n");
    Console.WriteLine("Ingrese el tipo de servicio (lavado de auto, cambio de aceite, revisión mecánica):");
    string servi = Console.ReadLine().ToLower();
    double importe;

    switch (servi)
    {
        case "lavado de auto":
            importe = 40.0; 
            break;
        case "cambio de aceite":
            importe = 120.0; 
            break;
        case "revisión mecánica":
            importe = 300.0; 
            break;
        default:
            Console.WriteLine("Servicio no reconocido.");
            return;
    }

    Console.WriteLine($"El importe a pagar por el servicio de {servi} es: Q{importe}");
}catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese un número válido.\n");
}

try
{
    Console.WriteLine("*4 Busquemos tu \n");
    Console.WriteLine("Ingrese el tipo de servicio (español, ingles, francés):");
    string idioma = Console.ReadLine().ToLower();
    string mensaje;

    switch (idioma)
    {
        case "español":
            mensaje = "BIEVENIDO AL SISTEMA DE SWITCH, ESPERO TE GUSTE";
            break;
        case "ingles":
            mensaje = "WELCOME TO THE SWITCH SYSTEM, I HOPE YOU LIKE IT";
            break;
        case "frances":
            mensaje = "frances";
            break;
        default:
            Console.WriteLine("BIENVENUE SUR LE SYSTÈME SWITCH, J'ESPÈRE QUE VOUS L'AIMEZ");
            return;
    }

    Console.WriteLine(mensaje);

}
catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese un número válido.\n");
}

