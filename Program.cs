using static System.Console;
using static System.Math;

class Program
    {
        static void Main()
        {
            while (true)
            {
                WriteLine("Seleccione una opción:");
                WriteLine("1. Encontrar el mayor y el menor numero");
                WriteLine("2. Determinar si un numero es par o impar");
                WriteLine("3. Determinar si un año es bisiesto");
                WriteLine("4. Determinar si una palabra o frase es un palíndromo");
                WriteLine("5. Ordenar una lista de nombres alfabéticamente");
                WriteLine("6. Calcular el factorial de un numero");
                WriteLine("7. Determinar si un numero es primo");
                WriteLine("8. Calcular el área y el volumen de un cubo");
                WriteLine("9. Calcular la suma de los numeros pares en una lista");
                WriteLine("10. Determinar si un numero es positivo, negativo o cero");
                WriteLine("11. Calcular la media de una lista de numeros");
                WriteLine("12. Juego con umeros");
                WriteLine("13. Anagrama de una palabra");
                WriteLine("14. Eliminar duplicados de una lista");
                WriteLine("15. Determinar un numero es capicuo o no");
                WriteLine("0. Salir");

                int opcion;
                if (!int.TryParse(ReadLine(), out opcion))
                {
                    WriteLine("Opción inválida");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        var p1 = new Numeros();
                        p1.MenorMayor();
                        break;
                    case 2:
                        var p2 = new Par();
                        p2.ParImpar();
                        break;
                    case 3:
                        var p3 = new Bisiesto();
                        p3.AnyoBisiesto();
                        break;
                    case 4:
                        var p4 = new Palindromo();
                        p4.palindromo();
                        break;
                    case 5:
                        var p5 = new Ordenada();
                        p5.ordenarLista();
                        break;
                    case 6:
                        var p6 = new Factorial();
                        p6.factorial();
                        break;
                    case 7:
                        var p7 = new Primo();
                        p7.NumeroPrimo();
                        break;
                    case 8:
                        var p8 = new Cubo();
                        p8.AreaVolumenCubo();
                        break;
                    case 9:
                        var p9 = new SumaPar();
                        p9.SumaNumerosPares();
                        break;
                    case 10:
                        var p10 = new PosYNeg();
                        p10.NumeroPositivoNegativoCero();
                        break;
                    case 11:
                        var p11 = new Media();
                        p11.MediaLista();
                        break;
                    case 12:
                        var p12 = new Adivinar();
                        p12.AdivinarNumero();
                        break;
                    case 13:
                        var p13 = new Anagram();
                        p13.Anagrama();
                        break;
                    case 14:
                        var p14 = new Duplicados();
                        p14.EliminarDuplicados();
                        break;
                    case 15:
                        var p15 = new Capi();
                        p15.Capicua();
                        break;
                    case 0:
                        WriteLine("Bye bye ^_^");
                        return;
                    default:
                        WriteLine("Opción inválida");
                        break;
                }
                WriteLine("------------------------------");
                WriteLine("Pulsa una tecla para continuar");
                ReadLine();
                Clear();
            }
        }
    }