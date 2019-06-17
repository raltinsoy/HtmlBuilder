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

        //TODO: change type from string to generic type
        public string HeadStyle { get; }

        public bool WithHtmlTag { get; set; }

        public Builder(string headStyle = null)
        {
            _contents = new List<IHtmlContent>();
            
            HeadStyle = headStyle;
        }

        public void AddTableInner(Table table)
        {
            _contents.Add(table);
        }

        public static Builder Create(string headStyle = null)
        {
            return new Builder(headStyle);
        }
    }
}
