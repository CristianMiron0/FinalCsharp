using static System.Console;

class Media
{
    public void MediaLista()
        {
            
            WriteLine("Ingrese los numeros separados por coma:");
            string? entrada = ReadLine();

            if (entrada == null)
                return;

            int[] numeros = entrada.Split(',').Select(int.Parse).ToArray();
            double media = numeros.Average();
            WriteLine("La media es: " + Math.Round(media,2));
        }
}