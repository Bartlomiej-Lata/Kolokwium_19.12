using System;

namespace Kolokwium
{
    class Program
    {
        public static void Zadanie1(double kwota, string kod)
        {
            double ilePunktow = kwota / 3;
            double punktyZKodem;

            if (kod=="1234")
            {
                punktyZKodem = ilePunktow + ilePunktow * 0.15;
            }
            else if (kod=="urodziny")
            {
                punktyZKodem = ilePunktow + (kwota / 10) *  10;
            }
            else if (kod=="swieta")
            {
                punktyZKodem = ilePunktow + 50;
            }
            else
            {
                Console.WriteLine("Podano nieprawidlowy kod");
            }
        }


        public static void Zadanie2(string tekst)
        {
            int iloscZnakow = tekst.Length; Console.WriteLine("tekst ma: "+iloscZnakow+" znakow");
            int iloscSlow;
            int iloscZdan;
            int iloscAkapitow;
        }


        class NaprawaGwarancyjna
        {
            public DateTime DataZgloszenia;
            public DateTime DataNaprawy;
            public bool CzyUznana;
            public string KosztNaprawy;

            public enum Status
            {
                Zgloszona,
                Zweryfikowana,
                Naprawiona,
                Zakonczona
            }

            public NaprawaGwarancyjna()
            {
                DataZgloszenia = DateTime.Today;
            }
        }


        public static void Zadanie3()
        {
            NaprawaGwarancyjna naprawaGwarancyjna = new NaprawaGwarancyjna();
                Program.NaprawaGwarancyjna.Status status;

            void Zweryfikuj()
            {
                Console.WriteLine("Czy gwarancja zostala uznana ?");
                string odp = Console.ReadLine();

                if (odp=="tak")
                {
                    naprawaGwarancyjna.CzyUznana = true;

                }
                else
                {
                    naprawaGwarancyjna.CzyUznana = false;
                }
            }

            void Napraw()
            {
                Console.WriteLine("Podaj cene naprawy");
                naprawaGwarancyjna.KosztNaprawy = Console.ReadLine();
                naprawaGwarancyjna.DataNaprawy = DateTime.Today;

                status = Program.NaprawaGwarancyjna.Status.Naprawiona;
                
            }


            void Odbierz()
            {
                if (naprawaGwarancyjna.CzyUznana==false)
                {
                    Console.WriteLine(naprawaGwarancyjna.KosztNaprawy);
                }

                status = Program.NaprawaGwarancyjna.Status.Zakonczona;
            }


        }


        static void Main(string[] args)
        {
            Zadanie1(200,"swieta")
        }
    }
}

/* Napisz funkcję która przeanalizuje tekst przesłany jako parametr.
 * Wypisz statystyki takie jak: ilość znaków, ilość słów (na podstawie spacji), ilość zdań (na podstawie kropek), 
 * ilość akapitów (na podstawie tabulatorów) a także wypisz informację
 czy tekst prawdopodobnie jest kodem (jeśli ilość średników przekracza 0.2% znaków)  */


/* Stwórz klasę NaprawaGwarancyjna. Dodaj do niej właściwości DataZgloszenia, 
 * DataWeryfikacji, DataNaprawy, CzyUznana, KosztNaprawy, Status (enum).
 * Status powinien mieć następujace opcje: Zgloszona, Zweryfikowana, Naprawiona, Zakonczona. Dodaj
 konstruktor bez parametrów, który uzupełni Datę Zgłoszenia aktualną datą.
 Dodaj metodę Zweryfikuj, która zapyta użytkownika czy gwarancja została uznana. 
 Ustaw CzyUznana zgodnie z odpowiedzią. Dodaj metode Napraw, która zadziała tylko jeśli status to Zweryfikowana.
 Zapytaj użytkownika o cenę naprawy. Uzupełnij Datę Naprawy aktualną datą i ustaw status na Naprawiona. 
 
    Dodaj metodę Odbierz, która wypisze cenę tylko jeśli przedmiot był naprawiany i klient naprawiał na swój koszt
    (CzyUznana jako fałsz) i zmień Status na Zakonczona.  */
/*   */
