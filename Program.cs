
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

bool esNumero;
string entrada;
int numero;
do
{
    Console.WriteLine("Ingrese un numero(mayor a 0): ");
    entrada=Console.ReadLine(); 
    esNumero=!int.TryParse(entrada, out numero);

        if (!esNumero)
        {
            string invertido="";
            for (int i = entrada.Length-1; i >=0; i--)
            {
                invertido+=entrada[i];
            }
            Console.WriteLine("El numero invertido es: " +invertido);
        }else
        {
            Console.WriteLine("no es un numero");
        }

} while (esNumero && numero<0);
    
