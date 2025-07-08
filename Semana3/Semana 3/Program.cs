using System;
using Registro;

namespace Registro
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos baseClientes = new Datos();

            // Crear primer cliente
            Clientes cliente1 = new Clientes();
            cliente1.DNI = "12345678";
            cliente1.Nombre = "Lore";
            cliente1.Apellidos = "Guerrero";
            cliente1.Telefonos[0] = "099111111";
            cliente1.Telefonos[1] = "099222222";
            cliente1.Telefonos[2] = "099333333";
            cliente1.Email = "lore@latinum.pe";
            cliente1.Direccion = "Calle Amazonía 456";
            cliente1.RUC = "20123456789";
            cliente1.Usuario = "lore123";
            cliente1.Contraseña = "miClaveSegura";

            baseClientes.AgregarCliente(cliente1);

            // Mostrar todos los clientes
            baseClientes.MostrarTodos();

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
