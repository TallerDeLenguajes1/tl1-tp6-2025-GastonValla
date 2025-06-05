// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Ingresa una cadena de texto y yo te voy a decir si es un link o no:\n");
string a = Console.ReadLine();
string patron = @"^(https?:\/\/)?([\w\-]+\.)+[a-zA-Z]{2,}(/[\w\-./?%&=]*)?$";
if (Regex.IsMatch(a, patron))
{ Console.WriteLine("\n SI ES UN LINK"); }
else { Console.WriteLine("\n NONONO ESO NO ES UN LINK");}

Console.WriteLine("\n \n jjajaja ingresá otra y te digo si es un mail o no");
a = Console.ReadLine();
patron = @"^[\w\.-]+@[\w\.-]+\.\w{2,}$";
if (Regex.IsMatch(a, patron))
{ Console.WriteLine("\n SI ES UN MAIL"); }
else{Console.WriteLine("\n ESO NO ES UN MAIL");}
