// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
bool esNumero;
int op = 0;

do
{
Console.WriteLine("Ingrese la operación que desea realizar:");
Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n0. Salir");
string opcion = Console.ReadLine();
esNumero = int.TryParse(opcion, out op);

if (esNumero && op > 0 && op <= 4)
{
    Console.Write("Ingrese el primer número: ");
    double numero1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingrese el segundo número: ");
    double numero2 = Convert.ToDouble(Console.ReadLine());

     switch (op)
     {
         case 1:
             Console.WriteLine("Resultado: " + (numero1 + numero2));
             break;

        case 2:
            Console.WriteLine("Resultado: " + (numero1 - numero2));
            break;

        case 3:
            Console.WriteLine("Resultado: " + (numero1 * numero2));
            break;

        case 4:
            if (numero2 != 0)
            {
                Console.WriteLine("Resultado: " + (numero1 / numero2));
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
            }
            break;
    }
}else if (op != 0)
{
    Console.WriteLine("Opción no válida. Intente de nuevo.");
}

} while (op != 0);

Console.WriteLine("Gracias por usar la calculadora.");
