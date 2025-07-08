namespace Registro
{
    public class Datos
    {
        public List<Clientes> ListaClientes = new List<Clientes>();

        public void AgregarCliente(Clientes c)
        {
            ListaClientes.Add(c);
        }

        public void MostrarTodos()
        {
            foreach (Clientes c in ListaClientes)
            {
                c.MostrarInformacion();
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
