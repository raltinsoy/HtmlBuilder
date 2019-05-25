using HtmlBuilder.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder
{
    public class Table : IHtmlContent
    {
        private List<Tr> _trs { get; }

        public IEnumerable<Tr> Trs => _trs;

        /// <summary>
        /// can be null
        /// </summary>
        public TableStyle TableStyle { get; }

        public Table(TableStyle tableStyle = null) : this(null, tableStyle)
        {
        }

        public Table(IEnumerable<Tr> trs, TableStyle tableStyle = null)
        {
            if (trs == null)
                _trs = new List<Tr>();
            else
                _trs = new List<Tr>(trs);

            TableStyle = tableStyle;
        }

        internal void AddTrInner(Tr tr)
        {
            _trs.Add(tr);
        }

        public string SerializeToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (TableStyle == null)
            {
                stringBuilder.Append("<table>");
            }
            else
            {
                stringBuilder.Append($"<table {TableStyle.SerializeToString()}>");
            }

            foreach (var tr in Trs)
            {
                stringBuilder.Append("<tr>");

                foreach (var th in tr.TrChild)
                {
                    stringBuilder.Append("<th>");
                    stringBuilder.Append(th.Content);
                    stringBuilder.Append("</th>");
                }

                stringBuilder.Append("</tr>");
            }

            stringBuilder.Append("</table>");

            return stringBuilder.ToString();
        }
    }
}
