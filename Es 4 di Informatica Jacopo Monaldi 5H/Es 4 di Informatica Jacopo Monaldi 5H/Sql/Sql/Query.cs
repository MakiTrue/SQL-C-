using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql
{
    internal class Query
    {
        public string Titolo { get; }
        public string Contenuto { get; }

        public Query(string titolo, string contenuto)
        {
            Titolo = titolo;
            Contenuto = contenuto;
        }
    }
}
