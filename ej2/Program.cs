// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
double num1, num2;
bool n=false;
do
{
    Console.WriteLine("\n CALCULADORA ARITMETICA V1!!!!! \n Seleccione la opeación que desea realizar");
    Console.WriteLine("\n 1: Suma \n 2: Resta \n 3: Multiplicación \n 4: División \n");
    do { n = int.TryParse(Console.ReadLine(), out a); } while (!n);
    n = false;
    switch (a)
    {
        case 1:
            {
                Console.WriteLine("\n --- SUMA --- \n Ingrese el primer numero: ");
                do { n = double.TryParse(Console.ReadLine(), out num1); } while (!n);
                Console.WriteLine("\n Ingrese el segundo numero: ");
                do { n = double.TryParse(Console.ReadLine(), out num2); } while (!n);
                num2 = num1 + num2;
                Console.WriteLine("\n RESULTADO: " + num2);
                n = false;
            }
            break;
        case 2:
            {
                Console.WriteLine("\n --- DIFERENCIA --- \n Ingrese el primer numero: ");
                do { n = double.TryParse(Console.ReadLine(), out num1); } while (!n);
                Console.WriteLine("\n Ingrese el segundo numero: ");
                do { n = double.TryParse(Console.ReadLine(), out num2); } while (!n);
                num2 = num1 - num2;
                Console.WriteLine("\n RESULTADO: " + num2);
                n = false;
            }
            break;
        case 3:
            {
                Console.WriteLine("\n --- MULTIPLICACION ---\n Ingrese el primer numero: ");
                do { n = double.TryParse(Console.ReadLine(), out num1); } while (!n);
                Console.WriteLine("\n Ingrese el segundo numero: ");
                do { n = double.TryParse(Console.ReadLine(), out num2); } while (!n);
                num2 = num1 * num2;
                Console.WriteLine("\n RESULTADO: " + num2);
                n = false;
            }
            break;
        case 4:
            {
                Console.WriteLine("\n--- DIVISION DE ENTEROS ---\n Ingrese el numerador: ");
                do { n = double.TryParse(Console.ReadLine(), out num1); } while (!n);
                Console.WriteLine("\n Ingrese el denominador: ");
                do { n = double.TryParse(Console.ReadLine(), out num2); } while (!n);
                num2 = num1 / num2;
                Console.WriteLine("\n RESULTADO: " + num2);
                n = false;
            }
            break;
        case 5:
            {
                Console.WriteLine("\n--- MAXIMO ENTRE NUMEROS ---\n Ingrese el primer numero: ");
                do { n = double.TryParse(Console.ReadLine(), out num1); } while (!n);
                Console.WriteLine("\n Ingrese el segundo numero: ");
                do { n = double.TryParse(Console.ReadLine(), out num2); } while (!n);
                if (num1 >= num2){ Console.WriteLine("\n RESULTADO: " + num1); }
                else {Console.WriteLine("\n RESULTADO: " + num2);}
                n = false;
            }
            break;
        case 6:
            {
                Console.WriteLine("\n--- minimo ENTRE NUMEROS ---\n Ingrese el primer numero: ");
                do { n = double.TryParse(Console.ReadLine(), out num1); } while (!n);
                Console.WriteLine("\n Ingrese el segundo numero: ");
                do { n = double.TryParse(Console.ReadLine(), out num2); } while (!n);
                if (num1 <= num2){ Console.WriteLine("\n RESULTADO: " + num1); }
                else {Console.WriteLine("\n RESULTADO: " + num2);}
                n = false;
            }
            break;
        case 7:
            {
                Console.WriteLine("\n--- VALOR ABSOLUTO ---\n Ingrese el numeror: ");
                do { n = double.TryParse(Console.ReadLine(), out num1); } while (!n);
                if(num1<0){num1 = -num1;}
                Console.WriteLine("\n RESULTADO: " + num1);
                n = false;
            }
            break;
        case 8:
            {
                Console.WriteLine("\n--- CUADRADO ---\n Ingrese el numero: ");
                do { n = double.TryParse(Console.ReadLine(), out num1); } while (!n);
                num1 = num1 * num1;
                Console.WriteLine("\n RESULTADO: " + num1);
                n = false;
            }
            break;
        case 9:
            {
                Console.WriteLine("\n--- RAIZ CUADRADA ---\n Ingrese el numero: ");
                do { n = double.TryParse(Console.ReadLine(), out num1); } while (!n);
                num1 = (double)Math.Sqrt(num1);
                Console.WriteLine("\n RESULTADO: " + num1);
                n = false;
            }
            break;
        case 10:
            {
                Console.WriteLine("\n--- SENO ---\n Ingrese el numero: ");
                do { n = double.TryParse(Console.ReadLine(), out num1); } while (!n);
                num1 = (double)Math.Sin(num1);
                Console.WriteLine("\n RESULTADO: " + num1);
                n = false;
            }
            break;
        case 11:
            {
                Console.WriteLine("\n--- COSENO ---\n Ingrese el numero: ");
                do { n = double.TryParse(Console.ReadLine(), out num1); } while (!n);
                num2 = (double)Math.Cos(num1);
                Console.WriteLine("\n RESULTADO: " + num1);
                n = false;
            }
            break;
        case 12:
            {
                Console.WriteLine("\n--- Parte entera ---\n Ingrese el numero: ");
                do { n = double.TryParse(Console.ReadLine(), out num1); } while (!n);
                num1 = (int)num1;
                Console.WriteLine("\n RESULTADO: " + num1);
                n = false;
            }
            break;
    }
    Console.WriteLine("\n ¿Desea realizar otra operación? ");
} while (a != 0);
