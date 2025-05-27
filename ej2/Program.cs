// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string a, num1, num2;
do
{
    a=console.ReadLine();
switch (a)
{
    case "1";
    {
        console.WriteLine("\n Ingrese el primer numero: ");
        num1 = console.ReadLine();
        console.WriteLine("\n Ingrese el segundo numero: ");
        num2 = console.ReadLine();
        num2 = num1+num2;
    }break;
    case "2";
    {
        console.WriteLine("\n Ingrese el primer numero: ");
        num1 = console.ReadLine();
        console.WriteLine("\n Ingrese el segundo numero: ");
        num2 = console.ReadLine();
        num2 = num1-num2;
    }break;
    case "3";
    {
        console.WriteLine("\n Ingrese el primer numero: ");
        num1 = console.ReadLine();
        console.WriteLine("\n Ingrese el segundo numero: ");
        num2 = console.ReadLine();
        num2 = num1*num2;
    }break;
    case "4";
    {
        console.WriteLine("\n Ingrese el primer numero: ");
        num1 = console.ReadLine();
        console.WriteLine("\n Ingrese el segundo numero: ");
        num2 = console.ReadLine();
        num2 = num1/num2;
    }break;

    default:
}
}while(a!=0);
