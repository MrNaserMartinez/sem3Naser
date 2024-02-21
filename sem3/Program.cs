Console.WriteLine("BIEVENIDO AL SISTEMA DE CONDICIONES\n\n");

Console.WriteLine("*1 El mayor de 3 números\n");
Console.WriteLine("Ingrese el primer numero: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el tercer numero: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2 && n1>n3) {
    Console.WriteLine($"El número mayor es: {n1}\n\n"); }
else if (n2 > n1 && n2 > n3)
    {
    Console.WriteLine($"El mayor es: {n2}\n\n"); }
else
{
    Console.WriteLine($"El mayor es : {n3}\n\n");
}

Console.WriteLine("*2 Entrar al club\n");
Console.WriteLine("Ingresa tu edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

if (edad >= 18)
{
    Console.WriteLine("FELICIDADES, SI PUEDES ENTRAR"); 
}
else
{
    Console.WriteLine("NO, NO PUEDES ENTRAR (estas muy chavo)");
}


