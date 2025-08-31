using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Diccionarios
{
    // Clase principal Traductor
    class Traductor
    {
        private readonly Dictionary<string, string> esToEn =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        private readonly Dictionary<string, string> enToEs =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        public Traductor()
        {
            // Palabras iniciales
            AddPair("tiempo", "time");
            AddPair("persona", "person");
            AddPair("año", "year");
            AddPair("camino", "way");
            AddPair("día", "day");
            AddPair("cosa", "thing");
            AddPair("hombre", "man");
            AddPair("mundo", "world");
            AddPair("vida", "life");
            AddPair("mano", "hand");
            AddPair("parte", "part");
            AddPair("niño", "child");
            AddPair("ojo", "eye");
            AddPair("mujer", "woman");
            AddPair("lugar", "place");
            AddPair("trabajo", "work");
            AddPair("semana", "week");
            AddPair("caso", "case");
            AddPair("punto", "point");
            AddPair("gobierno", "government");
            AddPair("empresa", "company");
        }

        private void AddPair(string es, string en)
        {
            esToEn[es] = en;
            enToEs[en] = es;
        }

        public void Iniciar()
        {
            bool continuar = true;
            while (continuar)
            {
                MostrarMenu();
                string opcion = Console.ReadLine()?.Trim();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": TraducirFrase(); break;
                    case "2": AgregarPalabra(); break;
                    case "0":
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine();
            }
        }

        private void MostrarMenu()
        {
            Console.WriteLine("==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
        }

        private void TraducirFrase()
        {
            Console.WriteLine("Dirección de traducción:");
            Console.WriteLine("1) Español -> Inglés");
            Console.WriteLine("2) Inglés -> Español");
            Console.Write("Elija 1 o 2: ");
            string dir = Console.ReadLine()?.Trim();
            bool fromSpanish = dir != "2";

            Console.Write("Ingrese la frase: ");
            string frase = Console.ReadLine() ?? "";

            string resultado = Traducir(frase, fromSpanish);
            Console.WriteLine("\nTraducción:");
            Console.WriteLine(resultado);
        }

        private void AgregarPalabra()
        {
            Console.WriteLine("Agregar palabra:");
            Console.WriteLine("1) Español -> Inglés");
            Console.WriteLine("2) Inglés -> Español");
            Console.Write("Elija 1 o 2: ");
            string dir = Console.ReadLine()?.Trim();

            if (dir == "2")
            {
                Console.Write("Palabra en inglés: ");
                string en = Console.ReadLine() ?? "";
                Console.Write("Traducción al español: ");
                string es = Console.ReadLine() ?? "";
                AddPair(es, en);
                Console.WriteLine($"Agregado: {en} <-> {es}");
            }
            else
            {
                Console.Write("Palabra en español: ");
                string es = Console.ReadLine() ?? "";
                Console.Write("Traducción al inglés: ");
                string en = Console.ReadLine() ?? "";
                AddPair(es, en);
                Console.WriteLine($"Agregado: {es} <-> {en}");
            }
        }

        private string Traducir(string frase, bool fromSpanish)
        {
            var tokens = Regex.Split(frase, "([\\p{L}]+)", RegexOptions.CultureInvariant);
            for (int i = 0; i < tokens.Length; i++)
            {
                string t = tokens[i];
                if (string.IsNullOrWhiteSpace(t)) continue;

                if (Regex.IsMatch(t, "^[\\p{L}]+$"))
                {
                    string lookup = t.ToLowerInvariant();
                    string traducida = fromSpanish
                        ? (esToEn.TryGetValue(lookup, out var v1) ? v1 : null)
                        : (enToEs.TryGetValue(lookup, out var v2) ? v2 : null);

                    if (traducida != null)
                        tokens[i] = AplicarCasing(t, traducida);
                }
            }
            return string.Join("", tokens);
        }

        private static string AplicarCasing(string original, string traducida)
        {
            if (string.IsNullOrEmpty(original)) return traducida;
            if (original.ToUpper() == original) return traducida.ToUpper();
            if (original.ToLower() == original) return traducida.ToLower();
            if (char.IsUpper(original[0]))
                return char.ToUpper(traducida[0]) + traducida.Substring(1);
            return traducida;
        }
    }

    // Clase Program que arranca todo
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // para acentos y ñ
            Traductor traductor = new Traductor();
            traductor.Iniciar();
        }
    }
}
