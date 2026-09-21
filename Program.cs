namespace GaderypolukiInformator2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pobieramy tekst od użytkownika i konwertujemy go na wielkie litery
            string tekstOdUzytkownika = Console.ReadLine().ToUpper();
            Console.WriteLine(Szyfruj(tekstOdUzytkownika));
        }

        /***********************************
         * nazwa funkcji: Szyfruj
         * 
         * parametry wejściowe: tekst - przechowuje tekst wprowadzony przez użytkownika
         * wartość zwracana: wynik - przechowuje zaszyfrowany tekst
         * opis funkcji: Funkcja szyfruje tekst wprowadzony przez użytkownika za pomocą szyfru Gaderypoluki.
         * Dla każdej litery w tekście sprawdza, czy znajduje się ona w tablicy liter szyfru.
         * Jeśli tak, zamienia ją na odpowiednią literę z pary. Jeśli nie, dodaje ją bez zmian do wyniku.
         * 
         * autor: 12345678910
         */
        static string Szyfruj(string tekst)
        {
            // Definiujemy tablicę liter używanych w szyfrze Gaderypoluki
            char[] litery = ['G', 'A', 'D', 'E', 'R', 'Y', 'P', 'O', 'L', 'U', 'K', 'I'];
            // Inicjalizujemy pusty string, który będzie przechowywał wynik szyfrowania
            string wynik = "";

            // Iterujemy przez każdy znak w podanym tekście
            for (int i = 0; i < tekst.Length; i++)
            {
                char litera = tekst[i];
                // Sprawdzamy, czy litera znajduje się w tablicy liter szyfru
                int indeks = Array.IndexOf(litery, litera);

                // Jeśli litera znajduje się w tablicy, zamieniamy ją na odpowiednią literę z pary
                if (indeks != -1)
                {
                    // Jeśli indeks jest parzysty, dodajemy literę z następnej pozycji, jeśli nieparzysty, dodajemy literę z poprzedniej pozycji
                    if (indeks % 2 == 0)
                    {
                        wynik += litery[indeks + 1];
                    }
                    // Jeśli indeks jest nieparzysty, dodajemy literę z poprzedniej pozycji
                    else if (indeks % 2 == 1)
                    {
                        wynik += litery[indeks - 1];
                    }
                }
                // Jeśli litera nie znajduje się w tablicy, dodajemy ją bez zmian
                else
                {
                    wynik += litera;
                }

            }

            // Zwracamy wynik szyfrowania
            return wynik;
        }

    }
}
