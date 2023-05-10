using static System.Console;

class PosYNeg
{
    public void NumeroPositivoNegativoCero()
        {

            int num;

            Write("Introduce un numero entero: ");
            if (!int.TryParse(ReadLine(), out num))
            {
                WriteLine("Numero invalido");
                return;
            }

            if (num > 0)
                WriteLine("{0} es un numero positivo", num);
            else if (num < 0)
                WriteLine("{0} es un numero negativo", num);
            else
                WriteLine("{0} es cero", num);

            ReadKey();
        }
}  