[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)


1.  **¿`string` es un tipo por valor o un tipo por referencia?**
    *   El tipo `string` en C# es un **tipo por referencia**.
    *   En C#, los tipos de datos se dividen principalmente en tipos de valor y tipos de referencia. La distinción fundamental radica en cómo se almacenan y manejan los datos:
        *   Una variable de un tipo de valor contiene directamente la instancia de ese tipo. Cuando se asigna o se pasa como argumento, se crea una **copia independiente** del valor.
        *   Una variable de un tipo de referencia **no contiene la instancia directamente**, sino una referencia a la ubicación en memoria donde reside la instancia real. Al asignar o pasar una variable de tipo referencia, lo que se copia es la **referencia**, no la instancia. Palabras clave como `class`, `interface` y `delegate` se usan para declarar tipos de referencia.
    *   La palabra clave `string` es un **alias para el tipo `System.String`**. Una cadena de texto se considera un **objeto de tipo `String`**. Dado que `System.String` es una clase (y la palabra clave `class` se utiliza para declarar tipos de referencia), y una cadena es un objeto de este tipo, `string` se clasifica como un tipo por referencia. Además, se menciona explícitamente que "Los tipos de referencia (como `string`, `class`) son nullable por defecto".

2.  **¿Qué secuencias de escape tiene el tipo `string`?**
    *   Se menciona específicamente que las cadenas de C# **pueden contener cualquier número de caracteres nulos insertados (`"\0"`)**.
    *   También se aclara que las cadenas de C# **no tienen un carácter que finalice en NULL** al final, a diferencia de las cadenas en algunos otros lenguajes.
    *   Segun el pdf de la clase 5, **no detalla** otras secuencias de escape comunes que podrían usarse dentro de literales de cadena (como `\n` para salto de línea, `\t` para tabulación, `\"` para comillas, etc.).

3.  **¿Qué sucede cuando utiliza el carácter `@` y `$` antes de una cadena de texto?**
    *   Cuando se utiliza el carácter **`$`** antes de una cadena de texto, se habilita la **interpolación de cadenas**.
    *   La interpolación de cadenas es descrita como "La forma más moderna y legible (.NET 6+)" para construir cadenas.
    *   Permite incrustar directamente el valor de variables o expresiones dentro del literal de cadena, rodeando la expresión con llaves `{}` y prefijando la cadena con `$`. El compilador procesa estas expresiones incrustadas para incluir sus valores en la cadena resultante en tiempo de ejecución. Un ejemplo de esto es: `string interpolacion = $"{saludo}{nombre}!"`.
    *   Cuando se utiliza el carácte **`@`** antes de una cadena de texto, se crea una cadena literal que ignora los caracteres de escape (como \n o \\) y permite escribir texto multilínea o rutas de archivos sin necesidad de escapar caracteres especiales.
    *   Ejemplo: `string path = @"C:\Users\Juan\Documents\archivo.txt"`;
