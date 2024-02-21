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
    Console.WriteLine("FELICIDADES, SI PUEDES ENTRAR\n"); 
}
else
{
    Console.WriteLine("NO, NO PUEDES ENTRAR (estas muy chavo)\n");
}

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

