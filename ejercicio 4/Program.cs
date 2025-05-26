// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese una cadena de texto:");
string cadena=Console.ReadLine();

int longitud=cadena.Length;
Console.WriteLine("La longitud de la cadena es:" +longitud);

Console.Write("Ingresa la segunda cadena de texto: ");
string cadena2 = Console.ReadLine();

if (cadena != cadena2)
{
    string resultado = string.Concat(cadena, cadena2);
    Console.WriteLine("Las cadenas son distintas. Resultado de la concatenación:" +resultado);
}else
{
    Console.WriteLine("Las cadenas son iguales. No se concatenaron.");
}

//extraer cadena
Console.Write("Ingresa la posición inicial para extraer la subcadena (0 a {0}): ", cadena.Length - 1);
int inicio = int.Parse(Console.ReadLine());

Console.Write("Ingresa la longitud de la subcadena: ");
int longitud2 = int.Parse(Console.ReadLine());


if (inicio >= 0 && inicio + longitud2 <= cadena.Length)
{
    string subcadena = cadena.Substring(inicio, longitud2);
    Console.WriteLine("Subcadena extraída:" +subcadena);
}
else
{
    Console.WriteLine("Los valores ingresados están fuera de rango.");
}

/*yo a la calculadora la use en otro pryecto, pero para mostar los resultados de operaciones seria algo asi
Console WriteLine("El producto de" + numero1.ToString() +" y " + numero2.ToString() + " es: " + resultado. ToString());*/

Console.Write("Ingresa una cadena de texto: ");
string cadena3 = Console.ReadLine();

Console.WriteLine("Caracteres en la cadena:");

foreach (char c in cadena3)
{
    Console.WriteLine(c);
}

Console.Write("Ingresa la palabra que deseas buscar: ");
string palabra = Console.ReadLine();

string textoMinuscula = cadena3.ToLower();
string palabraMinuscula = palabra.ToLower();

int contador = 0;
int posicion = textoMinuscula.IndexOf(palabraMinuscula);

while (posicion != -1)
{
    contador++;
    // busco la siguiente ocurrencia después de la actual
    posicion = textoMinuscula.IndexOf(palabraMinuscula, posicion + palabra.Length);
}

Console.WriteLine($"La palabra \"{palabra}\" aparece {contador} veces en la cadena.");

//ya la converti en minuscula, solo lo hare a mayuscula :)

string textoMayuscula = cadena3.ToUpper();
Console.WriteLine("La cadena en Mayuscula es:" +textoMayuscula);
Console.WriteLine("La cadena en Minuscula es: " +textoMinuscula);

Console.WriteLine("Ingrese la cadena completa:");
string cadena4 = Console.ReadLine();
Console.WriteLine("Ingrese el texto separador:");
string separador = Console.ReadLine();

string[] cadena5 = cadena4.Split(new string[] { separador }, 0); // 0 equivale a StringSplitOptions.None

Console.WriteLine("Resultados de la separación:");
foreach (string r in cadena5)
{
    Console.WriteLine(r.Trim());
}


Console.WriteLine("Ingrese una operación simple (ejemplo: 582+2):");
        string input = Console.ReadLine();

        // Variables para los operandos y el operador
        int operadorPos = -1;
        char operador = '\0';

        // Buscar operador en la cadena
        foreach (char c in input)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/')
            {
                operador = c;
                operadorPos = input.IndexOf(c);
                break;
            }
        }

        if (operadorPos == -1)
        {
            Console.WriteLine("No se encontró un operador válido (+, -, *, /).");
            
        }else
        {
            // Extraer los dos números
            string num1 = input.Substring(0, operadorPos);
            string num2 = input.Substring(operadorPos + 1);

            int num1 = int.Parse(num1);
            int num2 = int.Parse(num2);

            int resultado = 0;

            // Realizar la operación
            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: División por cero.");
                        return;
                    }
                    resultado = num1 / num2;
                    break;
            }

            Console.WriteLine($"Resultado: {resultado}");
        }
