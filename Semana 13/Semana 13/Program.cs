using System;
using System.Collections.Generic;

namespace CatalogoRevistasBST
{
    // Nodo del BST (clave = título de revista)
    class Nodo
    {
        public string Titulo;
        public Nodo Izq;
        public Nodo Der;
        public Nodo(string titulo) => Titulo = titulo;
    }

    /// <summary>
    /// Árbol Binario de Búsqueda de títulos (string).
    /// Comparación case-insensitive para que "Nature" == "nature".
    /// </summary>
    class ArbolBST
    {
        private Nodo _raiz;
        private readonly StringComparer _cmp = StringComparer.OrdinalIgnoreCase;

        // Inserta ignorando duplicados
        public void Insertar(string titulo)
        {
            if (string.IsNullOrWhiteSpace(titulo)) return;
            _raiz = InsertarRec(_raiz, titulo.Trim());
        }

        private Nodo InsertarRec(Nodo n, string titulo)
        {
            if (n == null) return new Nodo(titulo);
            int rel = _cmp.Compare(titulo, n.Titulo);
            if (rel < 0) n.Izq = InsertarRec(n.Izq, titulo);
            else if (rel > 0) n.Der = InsertarRec(n.Der, titulo);
            // rel == 0 → duplicado, no insertar
            return n;
        }

        // BÚSQUEDA RECURSIVA
        public bool BuscarRecursivo(string titulo) => BuscarRec(_raiz, titulo?.Trim() ?? "");
        private bool BuscarRec(Nodo n, string titulo)
        {
            if (n == null) return false;
            int rel = _cmp.Compare(titulo, n.Titulo);
            if (rel == 0) return true;
            return rel < 0 ? BuscarRec(n.Izq, titulo) : BuscarRec(n.Der, titulo);
        }

        // BÚSQUEDA ITERATIVA
        public bool BuscarIterativo(string titulo)
        {
            string key = titulo?.Trim() ?? "";
            var n = _raiz;
            while (n != null)
            {
                int rel = _cmp.Compare(key, n.Titulo);
                if (rel == 0) return true;
                n = rel < 0 ? n.Izq : n.Der;
            }
            return false;
        }

        // Listado ordenado (inorden)
        public IEnumerable<string> Inorden()
        {
            var pila = new Stack<Nodo>();
            var actual = _raiz;
            while (actual != null || pila.Count > 0)
            {
                while (actual != null) { pila.Push(actual); actual = actual.Izq; }
                actual = pila.Pop();
                yield return actual.Titulo;
                actual = actual.Der;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var catalogo = new ArbolBST();

            // ≥ 10 títulos precargados
            foreach (var t in new[]
            {
                "Nature",
                "Science",
                "IEEE Spectrum",
                "National Geographic",
                "The Economist",
                "MIT Technology Review",
                "Wired",
                "Scientific American",
                "Harvard Business Review",
                "PC World",
                "ACM Communications"
            }) catalogo.Insertar(t);

            while (true)
            {
                Console.WriteLine("\n=== CATÁLOGO DE REVISTAS (BST) ===");
                Console.WriteLine("1) Agregar título");
                Console.WriteLine("2) Buscar (recursivo)   → imprime: Encontrado / No encontrado");
                Console.WriteLine("3) Buscar (iterativo)   → imprime: Encontrado / No encontrado");
                Console.WriteLine("4) Listar (alfabético)");
                Console.WriteLine("0) Salir");
                Console.Write("Opción: ");
                var op = Console.ReadLine()?.Trim();

                switch (op)
                {
                    case "1":
                        Console.Write("Nuevo título: ");
                        var nuevo = Console.ReadLine();
                        catalogo.Insertar(nuevo);
                        Console.WriteLine("OK");
                        break;

                    case "2":
                        Console.Write("Título a buscar: ");
                        var q1 = Console.ReadLine();
                        Console.WriteLine(catalogo.BuscarRecursivo(q1) ? "Encontrado" : "No encontrado");
                        break;

                    case "3":
                        Console.Write("Título a buscar: ");
                        var q2 = Console.ReadLine();
                        Console.WriteLine(catalogo.BuscarIterativo(q2) ? "Encontrado" : "No encontrado");
                        break;

                    case "4":
                        Console.WriteLine("\n--- Catálogo (A–Z) ---");
                        foreach (var t in catalogo.Inorden())
                            Console.WriteLine("- " + t);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}

