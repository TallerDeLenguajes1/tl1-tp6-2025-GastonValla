// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World! Ingrese una cadena de texto: ");

string? str1, str2, str3, str4, palabra;
int pos;

str1 = Console.ReadLine();

Console.WriteLine("\n Longitud del string ingresado: " + str1.Length);
Console.WriteLine("\n Ingrese otra cadena de texto... \n");
str2 = Console.ReadLine();
str3 = str1 + str2;
Console.WriteLine("\n CONCATENACION DE CADENAS: " + str3);

str4 = str3.Substring(str1.Length);

Console.WriteLine("\n Segunda cadena extraida de la concatenacion: " + str4 +"\n");
Console.WriteLine("\n Concatenacion representada por foreach: ");

foreach (char i in str3)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n Ingrese una palabra para buscar en la concatenacion: ");

palabra = Console.ReadLine();
pos = str3.IndexOf(palabra);
if(pos != -1){Console.WriteLine("\n La palabra se encuentra en el texto en la posicion " + pos);}
else {Console.WriteLine("\n La palabra NO ESTA en el texto. Emoji triste");}

str2 = str3.ToUpper();
Console.WriteLine("\n Cadena en MAYUSCULAS: " +str2);
str2 = str3.ToLower();
Console.WriteLine("\n Cadena en minusculas: " +str2);

Console.WriteLine("\n Ingrese una cadena con palabras separadas por espacio: ");
string? entrada = Console.ReadLine();
string[] partes;
    partes = entrada.Split(' ');
else { Console.WriteLine("ERROR: Linea nula ingresada"); }

Console.WriteLine("\n Partes encontradas:");
int i = 0;
foreach (string parte in partes)
{
    i++;
    Console.WriteLine(i+" "+parte);
}

Console.WriteLine("\n Ingrese una operacion simple de un operando entre dos numeros");
entrada = Console.ReadLine();
char separador = ' ';
int a = 0, b = 0, c =0;
if (entrada.Contains("+")) { partes = entrada.Split('+'); separador = '+';}
else if (entrada.Contains("-")) { partes = entrada.Split('-'); separador = '-';}
else if (entrada.Contains("*")) { partes = entrada.Split('*'); separador = '*';}
else if (entrada.Contains("/")) { partes = entrada.Split('/'); separador = '/';}

switch (separador)
{
    case '+':
        a = int.Parse(partes[0]);
        b = int.Parse(partes[1]);
        c = a + b;
        break;
    case '-':
        a = int.Parse(partes[0]);
        b = int.Parse(partes[1]);
        c = a - b;
        break;

    case '*':
        a = int.Parse(partes[0]);
        b = int.Parse(partes[0]);
        c = a * b;
        break;

    case '/':
        a = int.Parse(partes[0]);
        b = int.Parse(partes[0]);
        c = a / b;
        break;
}
Console.WriteLine("RESULTADO DE LA OPERACION INGRESADA " + a + separador + b + " " + c);
