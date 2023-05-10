using static System.Console;

class Par
{
    public void ParImpar()
            {
                int numero = 0;
                Write("Ingrese un numero entero: ");
                if (int.TryParse(ReadLine(), out numero))
                    if (numero % 2 == 0)
                    {
                        WriteLine("El numero es par");
                    }
                    else
                    {
                        WriteLine("El numero es impar");
                    }
                else
                {
                    WriteLine("Ha entrado un numero erroneo");
                }
            }
}