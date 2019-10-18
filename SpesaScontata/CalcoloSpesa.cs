using System;

namespace SpesaScontata
{
    public class CalcoloSpesa
    {
        public static string Prezzo(double spesa, double sconto, double spesascontata)
        {

            if (spesa < 500)
            {
                sconto = (spesa / 100) * 10;
                spesascontata = spesa - sconto;

            }
            else if (spesa > 500)
            {
                sconto = (spesa / 100) * 20;
                spesascontata = spesa - sconto;

            }

            return $"L'importo da pagare è di {spesascontata} euro, considerando lo sconto di {sconto} euro ";
        }
    }
}
