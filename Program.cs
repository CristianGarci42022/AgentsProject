using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Ejercicio 1: ObtenerMedia
        obtenerMedia();

        // Ejercicio 2: Escalera
        Escalera();
    }

    static void obtenerMedia()
    {
        // Ejemplo de lista de números
        List<double> numbers = new List<double> { 1, 2, 3, 4, 5, 6 };

        // Crear instancias de los Media
        IAgent MediaA = new AgentA();
        IAgent MediaB = new AgentB();
        IAgent MediaC = new AgentC();

        // Calcular y mostrar la media para cada Media
        Console.WriteLine("Media A: " + MediaA.GetMedia(numbers));
        Console.WriteLine("Media B: " + MediaB.GetMedia(numbers));
        Console.WriteLine("Mediana C: " + MediaC.GetMedia(numbers));
    }

    static void Escalera()
    {
        // Ejemplo de uso
        var agentA = new AgentsProject.AgentA();
        Console.WriteLine($"Escalera A:\n{agentA.GetStaircase(8)}");

        var agentB = new AgentsProject.AgentB();
        Console.WriteLine($"Escalera B:\n{agentB.GetStaircase(6)}");

        var agentC = new AgentsProject.AgentC();
        Console.WriteLine($"Escalera C:\n{agentC.GetStaircase(10)}");
        
    }
}
