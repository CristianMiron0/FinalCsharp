using static System.Console;

class SumaPar
{
    public void SumaNumerosPares()
        {
            WriteLine("Ingrese los numeros separados por coma:");
            string? entrada = ReadLine();

            if (entrada == null)
                return;

            List<int> numeros = entrada.Split(',').Select(int.Parse).ToList();
            int suma = 0;


            foreach (int num in numeros)
            {
                if (num % 2 == 0)
                    suma += num;
            }

            WriteLine("La suma de los numeros pares es {0}", suma);

            ReadKey();
        }

} 