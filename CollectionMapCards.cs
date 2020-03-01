using CsvHelper.Configuration;

namespace Lab01
{
    class CollectionMapCards : ClassMap<Card>
    {
        public CollectionMapCards()
        {
            Map(m =>m.id).Name("Id");
            Map(m => m._money).Name("Money");
        }
    }
}
