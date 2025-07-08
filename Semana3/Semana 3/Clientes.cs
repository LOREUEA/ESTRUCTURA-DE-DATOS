//Generaremos código para poner en práctica el Array y las matrices, por lo tanto en este proyecto haremos un registro de clientes de la empresa LATINUM SAC, quien lleva la contabilidad de sus clientes y proveedores, para ello crearemos una clase Clientes que tendrá los siguientes atributos: Nombre, Apellidos, RUC, Usuario, Contraseña, tres teléfonos, Direccion.

namespace Registro // Puedes usar el mismo nombre de tu proyecto
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
