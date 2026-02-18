//Declaro el namespace System (Ahí vive la clase Console)
using System;

//Declaro la clase que voy a usar
class Program
{
    //Declaro el método Main
    static void Main(string[] args)
    {
        //Declaro las variables del programa
        string nombre;
        int edad;
        int edad_5y;
        //Pregunto al usuario su nombre
        Console.WriteLine("Por favor, ingresa tu nombre:");
        //Pasamos el valor que ingresa el usuario a nombre
        nombre = Console.ReadLine();
        //Pregunto al usuario su edad
        Console.WriteLine("Genial, ahora ingresa tu edad:");
        //Guardo como entero el dato
        edad = int.Parse(Console.ReadLine());
         //Imprimo la información del usuario
        Console.WriteLine("Hola " + nombre + " tienes " + edad + " años.");
        //Calculo la edad en 5 años
        edad_5y = edad + 5;
        Console.WriteLine("En 5 años tendrás " + edad_5y + " años.");
        //Revisamos si el usuario es mayor de edad o no
        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad.");
        }
        else
        {
            Console.WriteLine("No eres mayor de edad.");
        }
       

    }
}