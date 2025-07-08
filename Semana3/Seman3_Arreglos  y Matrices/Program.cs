using Seman3_Arreglos__y_Matrices.RegistroClientes;
using System;

namespace RegistroClientes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Registro de Cliente ===");

            Console.Write("DNI: ");
            string dni = Console.ReadLine();

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellidos: ");
            string apellidos = Console.ReadLine();

            Console.Write("Dirección: ");
            string direccion = Console.ReadLine();

            Console.Write("Correo electrónico: ");
            string email = Console.ReadLine();

            Console.Write("RUC: ");
            string ruc = Console.ReadLine();

            Console.Write("Usuario: ");
            string usuario = Console.ReadLine();

            string[] telefonos = new string[3];
            for (int i = 0; i < telefonos.Length; i++)
            {
                Console.Write($"Teléfono {i + 1}: ");
                telefonos[i] = Console.ReadLine();
            }

            Clientes cliente1 = new Clientes(dni, nombre, apellidos, direccion, email, ruc, usuario, telefonos);

            Datos baseDatos = new Datos();
            baseDatos.AgregarCliente(cliente1);
            baseDatos.MostrarTodos();

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
