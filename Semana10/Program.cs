using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("2525 – ESTRUCTURA DE DATOS – UEA / SEMANA 10");

        // 0) Configuración
        const int totalCiudadanos = 500;
        const int nPfizer = 75;
        const int nAstra = 75;
        var random = new Random(42); // Semilla fija para reproducibilidad

        // 1) Universo: 500 ciudadanos "Ciudadano 1" ... "Ciudadano 500"
        var universo = new HashSet<string>();
        for (int i = 1; i <= totalCiudadanos; i++)
            universo.Add($"Ciudadano {i}");

        // 2) Muestras de vacunados (subconjuntos del universo, únicos y al azar)
        var pfizer = GenerarVacunados("Ciudadano ", nPfizer, totalCiudadanos, random);
        var astra = GenerarVacunados("Ciudadano ", nAstra, totalCiudadanos, random);

        // 3) Operaciones de teoría de conjuntos (SIEMPRE sobre copias)
        // No vacunados = U \ (Pfizer ∪ Astra)
        var noVacunados = new HashSet<string>(universo);
        var unionVacunados = new HashSet<string>(pfizer);
        unionVacunados.UnionWith(astra);
        noVacunados.ExceptWith(unionVacunados);

        // Ambas dosis = Pfizer ∩ Astra
        var ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astra);

        // Solo Pfizer = Pfizer \ Astra
        var soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astra);

        // Solo Astra = Astra \ Pfizer
        var soloAstra = new HashSet<string>(astra);
        soloAstra.ExceptWith(pfizer);

        // 4) Resultados
        Console.WriteLine("\n=== Campaña de Vacunación COVID-19 ===");
        Console.WriteLine($"Total ciudadanos:           {universo.Count}");
        Console.WriteLine($"Vacunados con Pfizer:       {pfizer.Count}");
        Console.WriteLine($"Vacunados con AstraZeneca:  {astra.Count}");
        Console.WriteLine($"No vacunados:               {noVacunados.Count}");
        Console.WriteLine($"Ambas dosis:                {ambasDosis.Count}");
        Console.WriteLine($"Solo Pfizer:                {soloPfizer.Count}");
        Console.WriteLine($"Solo AstraZeneca:           {soloAstra.Count}");

        // (Opcional) Mostrar listas. Descomenta si el profe lo pide.
        /*
        ImprimirLista("\n-- No vacunados --", noVacunados);
        ImprimirLista("\n-- Ambas dosis --", ambasDosis);
        ImprimirLista("\n-- Solo Pfizer --", soloPfizer);
        ImprimirLista("\n-- Solo AstraZeneca --", soloAstra);
        */
    }

    // Genera 'cantidad' ciudadanos distintos en el rango [1..total], con prefijo dado.
    static HashSet<string> GenerarVacunados(string prefijo, int cantidad, int total, Random random)
    {
        var conjunto = new HashSet<string>();
        while (conjunto.Count < cantidad)
        {
            int numero = random.Next(1, total + 1);
            conjunto.Add(prefijo + numero);
        }
        return conjunto;
    }

    static void ImprimirLista(string titulo, HashSet<string> items)
    {
        Console.WriteLine(titulo);
        foreach (var c in items) Console.WriteLine(c);
    }
}

