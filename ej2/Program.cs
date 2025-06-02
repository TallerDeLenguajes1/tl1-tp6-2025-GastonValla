// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a, num1, num2;
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
                Console.WriteLine("\n --- SUMA DE ENTEROS --- \n Ingrese el primer numero: ");
                do { n = int.TryParse(Console.ReadLine(), out num1); } while (!n);
                Console.WriteLine("\n Ingrese el segundo numero: ");
                do { n = int.TryParse(Console.ReadLine(), out num2); } while (!n);
                num2 = num1 + num2;
                Console.WriteLine("\n RESULTADO: " + num2);
                n = false;
            }
            break;
        case 2:
            {
                Console.WriteLine("\n --- DIFERENCIA DE ENTEROS --- \n Ingrese el primer numero: ");
                do { n = int.TryParse(Console.ReadLine(), out num1); } while (!n);
                Console.WriteLine("\n Ingrese el segundo numero: ");
                do { n = int.TryParse(Console.ReadLine(), out num2); } while (!n);
                num2 = num1 - num2;
                Console.WriteLine("\n RESULTADO: " + num2);
                n = false;
            }
            break;
        case 3:
            {
                Console.WriteLine("\n --- MULTIPLICACION DE ENTEROS ---\n Ingrese el primer numero: ");
                do { n = int.TryParse(Console.ReadLine(), out num1); } while (!n);
                Console.WriteLine("\n Ingrese el segundo numero: ");
                do { n = int.TryParse(Console.ReadLine(), out num2); } while (!n);
                num2 = num1 * num2;
                Console.WriteLine("\n RESULTADO: " + num2);
                n = false;
            }
            break;
        case 4:
            {
                Console.WriteLine("\n--- DIVISION DE ENTEROS ---\n Ingrese el numerador: ");
                do { n = int.TryParse(Console.ReadLine(), out num1); } while (!n);
                Console.WriteLine("\n Ingrese el denominador: ");
                do { n = int.TryParse(Console.ReadLine(), out num2); } while (!n);
                num2 = num1 / num2;
                Console.WriteLine("\n RESULTADO: " + num2);
                n = false;
            }
            break;
    }
    Console.WriteLine("\n ¿Desea realizar otra operación? ");
} while (a != 0);
