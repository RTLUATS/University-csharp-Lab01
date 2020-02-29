using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using CsvHelper.Configuration;

namespace Lab01
{
    class CollectionMapCards : ClassMap<Card>
    {
        public CollectionMapCards()
        {
            Map(m =>m.id).Name("ID");
            Map(m => m._money).Name("Money");
        }
    }
}
