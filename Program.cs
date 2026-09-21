namespace GaderypolukiInformator2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekstOdUzytkownika = Console.ReadLine().ToUpper();
            Console.WriteLine(Szyfruj(tekstOdUzytkownika));
        }

        static string Szyfruj(string tekst)
        {
            char[] litery = ['G', 'A', 'D', 'E', 'R', 'Y', 'P', 'O', 'L', 'U', 'K', 'I'];
            string wynik = "";

            for (int i = 0; i < tekst.Length; i++)
            {
                char litera = tekst[i];
                int indeks = Array.IndexOf(litery, litera);

                if (indeks != -1)
                {
                    if (indeks % 2 == 0)
                    {
                        wynik += litery[indeks + 1];
                    }
                    else if (indeks % 2 == 1)
                    {
                        wynik += litery[indeks - 1];
                    }
                }
                else
                {
                    wynik += litera;
                }

            }

            return wynik;
        }

    }
}
