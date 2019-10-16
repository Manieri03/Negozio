using System;

namespace Negozio
{
    class Program
    {
        static void Main(string[] args)
        {
            double spesascontata=0;
            double sconto=0;
            Console.WriteLine("Quanto hai speso?");
            double spesa = double.Parse(Console.ReadLine());
            if (spesa < 500)
            {
                sconto = (spesa / 100) * 10;
                spesascontata = spesa - sconto;

            }else if (spesa > 500)
            {
                sconto = (spesa / 100) * 20;
                spesascontata = spesa - sconto;

            }
            Console.WriteLine($"L'importo da pagare è di {spesascontata} euro, considerando lo sconto di {sconto} euro ");
            Console.ReadLine();
        }
    }
}
