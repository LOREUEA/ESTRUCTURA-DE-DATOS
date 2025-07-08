namespace Tarea3;
using global::RegistroClientes;
using System;
using System.Collections.Generic;

namespace RegistroClientes
{
    public class Datos
    {
        public List<Clientes> ListaClientes = new List<Clientes>();

        public void AgregarCliente(Clientes cliente)
        {
            ListaClientes.Add(cliente);
        }

        public void MostrarTodos()
        {
            foreach (Clientes cliente in ListaClientes)
            {
                cliente.MostrarInformacion();
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}
