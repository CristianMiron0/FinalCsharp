using static System.Console;

class Ordenada
{
    public void ordenarLista()
        {
            WriteLine("Ingrese los nombres separados por coma:");
            string? entrada = ReadLine();

            if (entrada == null)
                return;

            string[] nombres = entrada.Split(',');

            Array.Sort(nombres);;

            WriteLine("Lista ordenada alfabéticamente:");

            foreach (string nombre in nombres)
            {
                WriteLine(nombre);
            }
        }
} 