using static System.Console;

class Numeros 
{
   public void MenorMayor()
        {

            WriteLine("Ingrese los numeros separados por coma:");
            string? entrada = ReadLine();

            if (entrada == null)
                return;

            int[] numeros = entrada.Split(',').Select(int.Parse).ToArray();

            int mayor = numeros[0];
            int menor = numeros[0];

            foreach (int numero in numeros)
            {
                if (numero > mayor)
                {
                    mayor = numero;
                }
                if (numero < menor)
                {
                    menor = numero;
                }
            }

            WriteLine("El mayor numero es: " + mayor);
            WriteLine("El menor numero es: " + menor);
        } 
}