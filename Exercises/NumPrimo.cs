using static System.Console;

class Primo
{
    public void NumeroPrimo()
        {
            int num = 0, i;
            bool esPrimo = true;

            Write("Introduce un numero entero positivo: ");
            if (!int.TryParse(ReadLine(), out num))
            {
                WriteLine("Numero invalido");
                return;
            }

            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo)
                WriteLine("{0} es un numero primo", num);
            else
                WriteLine("{0} no es un numero primo", num);
        }
}  