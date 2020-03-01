using CsvHelper;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Lab01
{
    internal class FileExtensions
    {
        public static CardHolder[] GetHolders()
        {
            try
            {
                using (var reader = new StreamReader(@"..\..\..\Holders.csv"))
                using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
                {
                   csv.Configuration.RegisterClassMap<CollectionMapHolder>();
                    var records = csv.GetRecords<CardHolder>();
                    return records.ToArray();
                }
            }
            catch (Exception massage)
            {
                Console.WriteLine(massage);
                return null;
            }
        }

        public static void SetHolders(IEnumerable<CardHolder> cardHolders)
        {
            using (var writer = new StreamWriter(@"..\..\..\Holders.csv"))
            using (var csv = new CsvWriter(writer, System.Globalization.CultureInfo.CurrentCulture))
            {
                csv.WriteRecords(cardHolders);
            }
        }

        public static Card[] GetCards()
        {

            using (var reader = new StreamReader(@"..\..\..\Cards.csv"))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
            {
                csv.Configuration.RegisterClassMap<CollectionMapCards>();
                var records = csv.GetRecords<Card>();
                return records.ToArray();
            }

        }

        public static void SetCards(IEnumerable<Card> storages)
        {
            using (var writer = new StreamWriter(@"..\..\..\Cards.csv"))
            using (var csv = new CsvWriter(writer, System.Globalization.CultureInfo.CurrentCulture))
            {
                csv.WriteRecords(storages);
            }
        }
    }
}
