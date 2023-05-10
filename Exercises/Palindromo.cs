using static System.Console;

class Palindromo
{
    public void palindromo()
        {
            Write("Ingrese una palabra o frase: ");
            string? texto = ReadLine();
            if (texto == null)
            {
                Write("texto invalido");
                return;
            }

            texto = System.Text.RegularExpressions.Regex.Replace(texto.Normalize(System.Text.NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");
            texto = System.Text.RegularExpressions.Regex.Replace(texto, @"\p{P}", string.Empty);
            texto = texto.ToLower();

            texto = texto.ToLower().Replace(" ", "");
            bool palindromo = true;
            for (int i = 0; i < texto.Length / 2; i++)
            {
                if (texto[i] != texto[texto.Length - 1 - i])
                {
                    palindromo = false;
                    break;
                }
            }

            if (palindromo)
            {
                WriteLine("La cadena es un palíndromo");
            }
            else
            {
                WriteLine("La cadena no es un palíndromo");
            }

        }
}  