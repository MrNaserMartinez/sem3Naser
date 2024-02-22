using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("BIEVENIDO AL SISTEMA DE CONDICIONES\n\n");

try
{

    Console.WriteLine("*1 El mayor de 3 números\n");
    Console.WriteLine("Ingrese el primer numero: ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero: ");
    int n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el tercer numero: ");
    int n3 = Convert.ToInt32(Console.ReadLine());

    if (n1 > n2 && n1 > n3)
    {
        Console.WriteLine($"El número mayor es: {n1}\n\n");
    }
    else if (n2 > n1 && n2 > n3)
    {
        Console.WriteLine($"El mayor es: {n2}\n\n");
    }
    else
    {
        Console.WriteLine($"El mayor es : {n3}\n\n");
    }
}catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese un número válido.");
}

try
{
    Console.WriteLine("*2 Entrar al club\n");
    Console.WriteLine("Ingresa tu edad: ");
    int edad = Convert.ToInt32(Console.ReadLine());

    if (edad >= 18)
    {
        Console.WriteLine("FELICIDADES, SI PUEDES ENTRAR\n");
    }
    else
    {
        Console.WriteLine("NO, NO PUEDES ENTRAR (estas muy chavo)\n");
    }

}catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese un número válido.");
}

try
{
    Console.WriteLine("*3 Oferta del 10%\n");
    Console.WriteLine("Ingresa el precio del producto para aplicar oferta 10%");
    int precio = Convert.ToInt32(Console.ReadLine());

    if (precio >= 100)
    {
        float descuento = (precio * 0.10f);
        float pfinal = (precio - descuento);
        Console.WriteLine($"Tu producto queda como: {pfinal}\n");
    }
    else
    {
        Console.WriteLine($"Tu producto queda en {precio} no aplica descuento\n");
    }

}catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese un número válido.");
}

try
{
    Console.WriteLine("*4 Validar usuario y contraseña\n");
    string usuarioValido = "Naser";
    string contrasenaValida = "Holacariño123";

    Console.WriteLine("4 Ingrese su nombre de usuario: \n");
    string usuario = Console.ReadLine();
    Console.WriteLine("Ingrese su contraseña: \n");
    string contrasena = Console.ReadLine();

    if (usuario == usuarioValido && contrasena == contrasenaValida)
    {
        Console.WriteLine("¡Acceso concedido! Bienvenido.\n");
    }
    else
    {
        Console.WriteLine("Acceso denegado. Usuario o contraseña incorrectos.\n");
    }

}catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese un número válido.");
}

try { 
Console.WriteLine("*5 Determinar si tu numero es par o impar\n");


    Console.WriteLine("* Determinar si tu numero es par o impar\n");
    Console.WriteLine("Ingresa tu numero:");
    int pexs = Convert.ToInt32(Console.ReadLine());

    if (pexs % 2 == 0)
    {
        Console.WriteLine($"El número {pexs} es par.\n");
    }
    else
    {
        Console.WriteLine($"El número {pexs} es impar.\n");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingresa un número válido.");
}


try
{
    Console.WriteLine("*6 Aprobacion de prestamos \n");
    Console.WriteLine("Ingresa el monto que deseas de préstamo:");
    int prestamo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresa tu edad:");
    int edad1 = Convert.ToInt32(Console.ReadLine());

    if (edad1 > 60 || prestamo < 5000)
    {
        Console.WriteLine("FELICIDADES, ¡PRÉSTAMO APROBADO!\n");
    }
    else
    {
        Console.WriteLine("Lo sentimos, préstamo no aprobado.\n");
    }

}catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese un número válido.");
}

try
{
    Console.WriteLine("*7 Area de figuras geometricas \n");
    Console.WriteLine("Ingresa la figura que deseas (triángulo, cuadrado o círculo):\n");
    string tipoFigura = Console.ReadLine().ToLower();

    if (tipoFigura == "triangulo")
    {
        Console.WriteLine("Veamos tu triangulo\n");
        Console.WriteLine("Ingresa la base");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa la altura");
        int h = Convert.ToInt32(Console.ReadLine());
        int resul = (b * h) / 2;
        Console.WriteLine($"El area es de {resul}");
    }
    else if (tipoFigura == "cuadrado")
    {
        Console.WriteLine("Veamos tu cuadrado\n");
        Console.WriteLine("Ingresa la base");
        int b1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa la altura");
        int h1 = Convert.ToInt32(Console.ReadLine());
        int resul2 = (b1 * h1);
        Console.WriteLine($"El area es de {resul2}");
    }
    else if (tipoFigura == "circulo")
    {
        Console.WriteLine("Veamos tu circulo\n");
        Console.WriteLine("Ingresa el radio");
        int r1 = Convert.ToInt32(Console.ReadLine());
        double pif = 3.1416;
        double resul3 = (pif * (r1 * r1));
        Console.WriteLine($"El area es de {resul3}");
    }
    else
    {
        Console.WriteLine("Figura geométrica no reconocida.");
    }
}catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese un número válido.");
}