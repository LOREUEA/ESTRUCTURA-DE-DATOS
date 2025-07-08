namespace RegistroClientes
{
    public class Clientes
    {
        public string DNI;
        public string Nombre;
        public string Apellidos;
        public string[] Telefonos = new string[3];
        public string Email;
        public string Direccion;
        public string RUC;
        public string Usuario;
        public string Contraseña;

        public void MostrarInformacion()
        {
            Console.WriteLine("DNI: " + DNI);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Teléfonos:");
            foreach (string tel in Telefonos)
            {
                Console.WriteLine(" - " + tel);
            }
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("RUC: " + RUC);
            Console.WriteLine("Usuario: " + Usuario);
            Console.WriteLine("Contraseña: " + Contraseña);
        }
    }
}
