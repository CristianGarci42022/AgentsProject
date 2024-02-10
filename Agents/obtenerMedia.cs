using System;
using System.Collections.Generic;
using System.Linq;

namespace AgentsLibrary{
    
}
public interface IAgent
{
    double GetMedia(List<double> numbers);
}

// Implementación del agente A para obtener la media aritmética
public class AgentA : IAgent
{
    public double GetMedia(List<double> numbers)
    {
        if (numbers == null || numbers.Count == 0)
            throw new ArgumentException("La lista de números no puede estar vacía.");

        return numbers.Average();
    }
}

// Implementación del agente B para obtener la media armónica
public class AgentB : IAgent
{
    public double GetMedia(List<double> numbers)
    {
        if (numbers == null || numbers.Count == 0)
            throw new ArgumentException("La lista de números no puede estar vacía.");

        return numbers.Count / numbers.Sum(x => 1 / x);
    }
}

// Implementación del agente C para obtener la mediana
public class AgentC : IAgent
{
    public double GetMedia(List<double> numbers)
    {
        if (numbers == null || numbers.Count == 0)
            throw new ArgumentException("La lista de números no puede estar vacía.");

        numbers.Sort();
        int middleIndex = numbers.Count / 2;
        if (numbers.Count % 2 == 0)
        {
            return (numbers[middleIndex - 1] + numbers[middleIndex]) / 2;
        }
        else
        {
            return numbers[middleIndex];
        }
    }
}
