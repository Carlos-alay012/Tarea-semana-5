using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Pruebas de las funciones
        //Función 1
        double radio = 0;
        Console.WriteLine("\tIngrese el radio del círculo para calcular su area");
        radio = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\tÁrea del círculo: " + CalcularAreaCirculo(radio));

        //FUnción 2
        double ancho = 0;
        double altura = 0;
        Console.WriteLine("\n\tIngrese el ancho del rectángulo para calcular el perímetro");
        ancho = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\tAhora ingrese la altura del rectángulo para calcular el perímetro");
        altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\tPerímetro del rectángulo: " + CalcularPerimetroRectangulo(ancho, altura));

        //Función 3
        string input;
        List<int> numeros = new List<int> ();
        Console.WriteLine("\n\tIngrese su lista de números para calcular el promedio de la lista\n\tPresione ENTER para terminar.");
        while ((input = Console.ReadLine()) != "")
        {
            int num;
            if (int.TryParse(input, out num))
            {
                numeros.Add(num);
            }
        }
        Console.WriteLine("\tLos números ingresados son:");
        foreach (int num in numeros)
        {
            Console.WriteLine("\t" + num);
        }
        Console.WriteLine("\tPromedio de la lista de números: " + CalcularPromedio(numeros));

        //Función 4
        int numero = 0;
        Console.WriteLine("\n\tIngrese un número para saber si es par o impar");
        numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\tEl número " + numero + " es " + (EsPar(numero) ? "par" : "impar"));

        //Función5 
        string cadena;
        Console.WriteLine("\n\tIngrese la cadena de palabras que desea convertir a mayúsculas");
        cadena = Convert.ToString(Console.ReadLine());
        Console.WriteLine("\tLa cadena convertida a mayúsculas: " + ConvertirAMayusculas(cadena));

        //Función 6
        double x1 = 0, x2 = 0, y1 = 0, y2 = 0;
        Console.WriteLine("\n\tIngrese el punto x de la primer coordenada");
        x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n\tIngrese el punto y de la primer coordenada");
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\tIngrese el punto X de la segunda coordenada");
        x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\tIngrese el punto Y de la segunda coordenada");
        y2= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n\tDistancia entre los puntos: " + CalcularDistancia(x1, x2, y1, y2));

        //Función 7
        int n = 0;
        Console.WriteLine("\n\tIngrese los números naturales para hacer la suma");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Suma de los primeros " + n + " números naturales: " + CalcularSumaNaturales(n));

        //Función 8
        int factorialNumero = 0;
        Console.WriteLine("\n\tIngrese el número que desee para calcular el factorial");
        factorialNumero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\tFactorial de " + factorialNumero + ": " + CalcularFactorial(factorialNumero));
    }

    //Funcion 1
    static double CalcularAreaCirculo(double radio)
    {
        double area = Math.PI * Math.Pow(radio, 2);
        return area;
    }

    //Funcion 2
    static double CalcularPerimetroRectangulo(double ancho, double altura)
    {
        double perimetro = 2 * (ancho + altura);
        return perimetro;
    }

    //Funcion 3
    static double CalcularPromedio(List<int> numeros)
    {
        double suma = 0;
        foreach (int num in numeros)
        {
            suma += num;
        }
        double promedio = suma / numeros.Count;
        return promedio;
    }
    //Funcion 4
    static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }
    //Funcion 5
    static string ConvertirAMayusculas(string cadena)
    {
        return cadena.ToUpper();
    }
    //Funcion 6
    static double CalcularDistancia(double x1, double x2, double y1, double y2)
    {
        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distancia;
    }
    //Funcion 7
    static int CalcularSumaNaturales(int n)
    {
        int suma = 0;
        for (int i = 1; i <= n; i++)
        {
            suma += i;
        }
        return suma;
    }
    //Funcion 8
    static int CalcularFactorial(int n)
    {
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}