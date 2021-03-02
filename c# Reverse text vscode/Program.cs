using System;

namespace c__Reverse_text_vscode
{
    class Program
    {
        static void Main(string[] args)
        {
            inizio:
            Console.Write("Inserisci la parola da ribaltare:   ");
            string Parola = Console.ReadLine();
            Console.WriteLine($"Ecco la parola ribaltata: {Reversa(Parola)}");
            Console.WriteLine("-----------===================-----------");
            Console.WriteLine("Premi R per Continuare o un qualsiasi altro tasto per uscire");
            if(Console.ReadKey(true).Key == ConsoleKey.R)
            {
                Console.Clear();
                goto inizio;
            }
            else
            {
                Console.WriteLine("ADDIO");
                Environment.Exit(0);
            }
        }
        public static string Reversa(string Parola)
        {
            if(Parola == null) return null;
            char[] chars = Parola.ToCharArray();
            Array.Reverse(chars);
            return new String(chars);   
        }
    }
}
