Console.WriteLine("BIEVENIDO AL SISTEMA DE CONDICIONES\n\n");

Console.WriteLine("*1 El mayor de 3 números\n");
Console.WriteLine("Ingrese el primer numero: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
    Console.WriteLine($"El número mayor es: {n1}");
else
    Console.WriteLine($"El mayor es: {n2}");

