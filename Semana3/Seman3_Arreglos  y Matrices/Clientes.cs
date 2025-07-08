using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace RegistroClientes;

public class Clientes
{
    public string DNI { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Direccion { get; set; }
    public string Email { get; set; }
    public string RUC { get; set; }
    public string Usuario { get; set; }
    public string[] Telefonos { get; set; }

    public Clientes(string dni, string nombre, string apellidos, string direccion, string email, string ruc, string usuario, string[] telefonos)
    {
        DNI = dni;
        Nombre = nombre;
        Apellidos = apellidos;
        Direccion = direccion;
        Email = email;
        RUC = ruc;
        Usuario = usuario;

        Telefonos = new string[3];
        Array.Copy(telefonos, Telefonos, 3);
    }

    public void MostrarDatos()
    {
        Console.WriteLine("\n--- Datos del cliente ---");
        Console.WriteLine($"DNI: {DNI}");
        Console.WriteLine($"Nombre: {Nombre} {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine($"Correo: {Email}");
        Console.WriteLine($"RUC: {RUC}");
        Console.WriteLine($"Usuario: {Usuario}");
        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($" - Teléfono {i + 1}: {Telefonos[i]}");
        }
    }
}
