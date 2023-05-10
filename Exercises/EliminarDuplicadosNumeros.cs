using static System.Console;

class Duplicados
{
    public void EliminarDuplicados()
        {
        WriteLine("Ingrese los numeros separados por coma:");
        string? entrada = ReadLine();

        if (entrada == null)
            return;

        List<int> numeros = entrada.Split(',').Select(int.Parse).ToList();
        List<int> numerosSinDuplicados = numeros.Distinct().ToList();

            foreach (int numero in numeros)
            {
                if (!numerosSinDuplicados.Contains(numero))
                {
                    numerosSinDuplicados.Add(numero);
                }
            }

            WriteLine("Numeros originales: " + string.Join(", ", numeros));
            WriteLine("Numeros sin duplicados: " + string.Join(", ", numerosSinDuplicados));

        }

}  