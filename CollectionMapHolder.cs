using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration;

namespace Lab01
{
    class CollectionMapHolder : ClassMap<CardHolder>
    {
        public CollectionMapHolder()
        {
            Map(m => m.id).Name("Id");
            Map(m => m.holder).Name("Name");
        }
    }

        
}
