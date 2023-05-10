using static System.Console;

class Anagram
{
    public void Anagrama()
        {
            WriteLine("Ingrese la primera palabra:");
            string? palabra1 = ReadLine();

            WriteLine("Ingrese la segunda palabra:");
            string? palabra2 = ReadLine();

            if (((palabra1 == null) || (palabra2 == null)))
                return;

            palabra1 = System.Text.RegularExpressions.Regex.Replace(palabra1.Normalize(System.Text.NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");
            palabra1 = System.Text.RegularExpressions.Regex.Replace(palabra1, @"\p{P}", string.Empty);
            palabra1 = palabra1.ToLower();

            palabra2 = System.Text.RegularExpressions.Regex.Replace(palabra2.Normalize(System.Text.NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");
            palabra2 = System.Text.RegularExpressions.Regex.Replace(palabra2, @"\p{P}", string.Empty);
            palabra2 = palabra2.ToLower();

            char[] letras1 = palabra1.ToCharArray();    
            char[] letras2 = palabra2.ToCharArray();

            Array.Sort(letras1);
            Array.Sort(letras2);

            bool sonAnagramas = letras1.SequenceEqual(letras2);

            if (sonAnagramas)
            {
                WriteLine(palabra1 + " y " + palabra2 + " son anagramas.");
            }
            else
            {
                WriteLine(palabra1 + " y " + palabra2 + " no son anagramas.");
            }
        }
} 