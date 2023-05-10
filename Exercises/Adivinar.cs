using static System.Console;

class Adivinar
{
    public void AdivinarNumero()
        {

            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            int intentos = 0;
            int numeroUsuario = 0;

            while (numeroUsuario != numeroAleatorio)
            {
                WriteLine("Adivina el numero (entre 1 y 100):");
                if (!int.TryParse(ReadLine(), out numeroUsuario))
                {
                    WriteLine("Numero invalido");
                    continue;
                }
                intentos++;

                if (numeroUsuario < numeroAleatorio)
                {
                    WriteLine("El numero introducido es menor que el numero aleatorio.");
                }
                else if (numeroUsuario > numeroAleatorio)
                {
                    WriteLine("El numero introducido es mayor que el numero aleatorio.");
                }
            }

            WriteLine("¡Has acertado el numero en " + intentos + " intentos!");
        }
} 