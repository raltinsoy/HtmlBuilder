using HtmlBuilder.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder
{
    public class Builder
    {
        private List<IHtmlContent> _contents;

        public IEnumerable<IHtmlContent> Contents => _contents;

        //TODO: missing serialize
        public TableStyle TableStyle { get; }

        public Builder(TableStyle tableStyle = null)
        {
            _contents = new List<IHtmlContent>();

            TableStyle = tableStyle;
        }

        public void AddTableInner(Table table)
        {
            _contents.Add(table);
        }

        public static Builder Create()
        {
            return new Builder();
        }
    }
}
