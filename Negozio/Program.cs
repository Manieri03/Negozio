using System;
using SpesaScontata;


namespace Negozio
{
    class Program
    {
        static void Main(string[] args)
        {
            string risposta;
            double spesascontata=0;
            double sconto=0;

            Console.WriteLine("Quanto hai speso?");
            double spesa = double.Parse(Console.ReadLine());

            risposta =CalcoloSpesa.Prezzo (spesa, spesascontata, sconto);

            Console.WriteLine(risposta);
            Console.ReadLine();
        }
    }
}
