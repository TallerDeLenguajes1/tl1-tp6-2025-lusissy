// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("=== CALCULADORA V2 ===");

        // 1. Solicitar un número y calcular operaciones avanzadas
        double numero = 0;
        bool valido = false;

        while (!valido)
        {
            Console.Write("Ingrese un número: ");
            string entrada = Console.ReadLine();
            valido = double.TryParse(entrada, out numero);

            if (!valido)
            {
                Console.WriteLine("Entrada inválida. Intente de nuevo.");
            }
        }

        Console.WriteLine("Valor absoluto: " + Math.Abs(numero));
        Console.WriteLine("Cuadrado: " + (numero * numero));
        if (numero >= 0)
        {
            Console.WriteLine("Raíz cuadrada: " + Math.Sqrt(numero));
        }
        else
        {
            Console.WriteLine("Raíz cuadrada: No se puede calcular la raíz cuadrada de un número negativo.");
        }
        Console.WriteLine("Seno: " + Math.Sin(numero));
        Console.WriteLine("Coseno: " + Math.Cos(numero));
        Console.WriteLine("Parte entera: " + Math.Truncate(numero));

        Console.WriteLine("\n=== Comparación entre dos números ===");

        // 2. Solicitar dos números para comparar
        double num1 = 0, num2 = 0;
        bool valido1 = false, valido2 = false;

        while (!valido1)
        {
            Console.Write("Ingrese el primer número: ");
            string entrada1 = Console.ReadLine();
            valido1 = double.TryParse(entrada1, out num1);
            if (!valido1)
            {
                Console.WriteLine("Entrada inválida. Intente de nuevo.");
            }
        }

        while (!valido2)
        {
            Console.Write("Ingrese el segundo número: ");
            string entrada2 = Console.ReadLine();
            valido2 = double.TryParse(entrada2, out num2);
            if (!valido2)
            {
                Console.WriteLine("Entrada inválida. Intente de nuevo.");
            }
        }

        Console.WriteLine("Máximo: " + Math.Max(num1, num2));
        Console.WriteLine("Mínimo: " + Math.Min(num1, num2));

        Console.WriteLine("\nGracias por usar la Calculadora V2.");
