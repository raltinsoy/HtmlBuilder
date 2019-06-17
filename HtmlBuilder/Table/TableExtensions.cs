using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder
{
    public static class TableExtensions
    {
        public static Builder WithHtmlTag(this Builder builder)
        {
            builder.WithHtmlTag = true;
            return builder;
        }

        public static Builder AddTable(this Builder builder, Func<Table, Table> func)
        {
            var table = func.Invoke(new Table());
            builder.AddTableInner(table);
            return builder;
        }

        public static Builder AddTable(this Builder builder, Table table)
        {
            builder.AddTableInner(table);
            return builder;
        }

        public static Builder AddTable(this Builder builder)
        {
            builder.AddTableInner(new Table());
            return builder;
        }

        public static Table AddTr(this Table table, Tr tr)
        {
            table.AddTrInner(tr);
            return table;
        }

        public static Table AddTr(this Table table, Func<Tr, Tr> func)
        {
            var tr = func.Invoke(new Tr());
            table.AddTrInner(tr);
            return table;
        }

        public static Table AddTr(this Table table)
        {
            table.AddTrInner(new Tr());
            return table;
        }

        public static Tr AddChild(this Tr tr, IChildOfTr childofTr)
        {
            tr.AddChildInner(childofTr);
            return tr;
        }

        public static Tr AddTd(this Tr tr, Td td)
        {
            tr.AddChildInner(td);
            return tr;
        }

        public static Tr AddTd(this Tr tr, string content)
        {
            tr.AddChildInner(new Td(content));
            return tr;
        }

        public static Tr AddTh(this Tr tr, Th th)
        {
            tr.AddChildInner(th);
            return tr;
        }

        public static Tr AddTh(this Tr tr, string content)
        {
            tr.AddChildInner(new Th(content));
            return tr;
        }

        public static Tr AddTable(this Tr tr, Table table)
        {
            tr.AddChildInner(table);
            return tr;
        }
    }
}
