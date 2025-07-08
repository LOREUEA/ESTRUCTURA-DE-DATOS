using Seman3_Arreglos__y_Matrices.RegistroClientes;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroClientes;

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
            cliente.MostrarDatos();
            Console.WriteLine("--------------------------------------");
        }
    }
}
