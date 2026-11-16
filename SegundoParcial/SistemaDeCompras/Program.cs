/*
Jade Mariel Mateo Baez 20260706
Fecha: 15/11/2026
Tema: Segundo Parcial, Ronda 3.
Resumen: Sistema de compras de consola para estudiantes con un menú de cuatro opciones, el programa aplica automáticamente
un descuento de estudiante, imprime la factura y calcula el cambio.
*/

using System;

namespace SistemaDeCompras;

class Program
{
    static double subtotal = 0; // variables de clase: el carrito
    static int articulos = 0;

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int opcion;
        do
        {
            Console.WriteLine($"\n=== Sistema ===  Carrito: {articulos} artículo(s)");
            Console.WriteLine("1. Ver catálogo\n2. Agregar productos\n3. Pagar\n0. Salir");
            opcion = LeerEntero("Opción: ", 0, 3);

            switch (opcion)
            {
                case 1: MostrarCatalogo(); break;
                case 2: Agregar(); break;
                case 3: Pagar(); break;
            }
        } while (opcion != 0);

        Console.WriteLine("¡Gracias por tu visita!");
    }

    static string Nombre(int id)
    {
        switch (id)
        {
            case 1: return "Mouse inalámbrico";
            case 2: return "Teclado mecánico";
            case 3: return "Audífonos Bluetooth";
            default: return "Mochila para laptop";
        }
    }

    static double Precio(int id)
    {
        switch (id)
        {
            case 1: return 650;
            case 2: return 1450;
            case 3: return 1200;
            default: return 1800;
        }
    }

    static double Descuento(double monto)
    {
        if (monto >= 3000) return 0.15;
        else if (monto >= 1500) return 0.10;
        else return 0.05;
    }

    static void MostrarCatalogo()
    {
        for (int id = 1; id <= 4; id++)
            Console.WriteLine($"{id}. {Nombre(id),-22} RD$ {Precio(id),8:N2}");
        Console.WriteLine("Descuento de estudiante: 5% | 10% desde RD$ 1,500 | 15% desde RD$ 3,000");
    }

    static void Agregar()
    {
        MostrarCatalogo();
        int id = LeerEntero("Código (1-4): ", 1, 4);
        int cantidad = LeerEntero("Cantidad (1-10): ", 1, 10);

        subtotal += Precio(id) * cantidad;
        articulos += cantidad;
        Console.WriteLine($"Agregado: {cantidad} x {Nombre(id)}. Subtotal: RD$ {subtotal:N2}");
    }

    static void Pagar()
    {
        if (articulos == 0)
        {
            Console.WriteLine("Tu carrito está vacío.");
            return;
        }

        double descuento = subtotal * Descuento(subtotal);
        double total = subtotal - descuento;
        Console.WriteLine($"Subtotal: RD$ {subtotal:N2}");
        Console.WriteLine($"Descuento estudiante: -RD$ {descuento:N2}");
        Console.WriteLine($"TOTAL: RD$ {total:N2}");

        double monto = 0;
        while (monto < total)
        {
            Console.Write("Monto recibido: RD$ ");
            double.TryParse(Console.ReadLine(), out monto);
            if (monto < total) Console.WriteLine("Monto insuficiente.");
        }

        Console.WriteLine($"Cambio: RD$ {monto - total:N2}. ¡Compra realizada!");
        subtotal = 0;
        articulos = 0;
    }

    static int LeerEntero(string mensaje, int min, int max)
    {
        int valor;
        Console.Write(mensaje);
        while (!int.TryParse(Console.ReadLine(), out valor) || valor < min || valor > max)
            Console.Write($"Inválido, escribe un número entre {min} y {max}: ");
        return valor;
    }
}