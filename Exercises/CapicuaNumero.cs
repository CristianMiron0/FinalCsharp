using static System.Console;

class Capi
{
    public void Capicua()
        {
            Console.Write("Ingresa un numero: ");
            int num = 0;
            if (!int.TryParse(ReadLine(), out num))
            {
                WriteLine("Numero invalido");
                return;
            }
            int originalNum = num;
            int reversedNum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversedNum = (reversedNum * 10) + digit;
                num /= 10;
            }

            if (originalNum == reversedNum)
            {
                Console.WriteLine("El numero es capicua.");
            }
            else
            {
                Console.WriteLine("El numero no es capicua.");
            }
        }

    }