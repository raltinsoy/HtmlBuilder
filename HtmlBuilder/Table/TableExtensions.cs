using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder
{
    public static class TableExtensions
    {
        public static Builder AddTable(this Builder builder, Table table)
        {
            builder.AddTableInner(table);
            return builder;
        }

        public static Table AddTr(this Table table, Tr tr)
        {
            table.AddTrInner(tr);
            return table;
        }

        public static Tr AddChildToTr(this Tr tr, IChildOfTr childofTr)
        {
            tr.AddChildInner(childofTr);
            return tr;
        }
    }
}
