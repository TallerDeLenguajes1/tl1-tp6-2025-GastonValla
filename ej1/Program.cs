// See https://aka.ms/new-console-template for more information

string a;
int b, c=0;
do
{
    Console.WriteLine("Hello, World! Ingresa un numero entero positivo ahora. ");
    a = Console.ReadLine();
} while (!int.TryParse(a, out b)||b<=0);
    Console.WriteLine("numero ingresado: "+b);
    Console.WriteLine("\n PROCEDIENDO CON LA INVERSION DE DIGITOS");
    while(b/10 > 0)
    {
        c = c*10 + b%10;
        b= b/10;
    }
    c=c*10+b;
    Console.WriteLine("\n Numero invertido: "+c);