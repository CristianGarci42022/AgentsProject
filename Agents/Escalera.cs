using System;

namespace AgentsProject
{
    public interface IAgent
    {
        string GetStaircase(int n);
    }

    public class AgentA : IAgent
    {
        public string GetStaircase(int n)
        {
            string staircase = "";
            for (int i = 1; i <= n; i++)
            {
                string spaces = new string(' ', n - i);
                string symbols = new string('#', i);
                staircase += spaces + symbols + "\n";
            }
            return staircase;
        }
    }

    public class AgentB : IAgent
    {
        public string GetStaircase(int n)
        {
            string staircase = "";
            for (int i = 1; i <= n; i++)
            {
               

                string symbolss = new string('#', n - i + 1);
                staircase += symbolss.PadLeft(n) + "\n";
            }
            return staircase;
        }
    }

    public class AgentC : IAgent
    {
        public string GetStaircase(int n)
        {
            string staircase = "";
            int dimension1 = 4;
            int dimension2 = 10;
            int space = dimension1 - 1;
            // Creamos la parte superior desde dimension1 hasta dimension2, pero incrementamos de 2 en 2
            for (int i = dimension1; i <= (dimension2); i += 2)
            {
                // Dibujamos los espacios en el Ciclo
                for (int j = 0; j < space; j++)
                {
                    staircase += ' ';
                }
                //Reaalizamos la declaracion de la variable en de los espacios
                space--;
                // Dibujamos los "#" desde 0 hasta el valor actual de i, que sería desde dimension1 hasta dimension2
                for (int j = 0; j < i; j++)
                {
                    staircase += '#';
                }
                // Insertamos un salto de línea
                staircase += '\n';
            }
            // Iniciamos la variable de espacios en 1 ya que la parte inferior requiere un espacio en el ciclo inicial
            space = 1;
            // Dibujamos la parte inferior desde dimension2-2 hasta dimension1 pero decrementamos de 2 en 2
            for (int i = dimension2 - 2; i >= (dimension1); i -= 2)
            {
                // Dibujamos los espacios 
                for (int j = 0; j < space; j++)
                {
                    staircase += ' ';
                }
                // Incrementamos la variable de espacios
                space++;
                // Dibujamos los "#" desde 0 hasta el valor actual de i, que sería desde dimension2 hasta dimension1
                for (int j = 0; j < i; j++)
                {
                    staircase += '#';
                }
                staircase += '\n';
            }
            return staircase;
        }
    }
}
