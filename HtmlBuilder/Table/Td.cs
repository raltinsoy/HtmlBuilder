using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder
{
    public class Td : IChildOfTr
    {
        public string Content { get; }

        public Td(string content)
        {
            Content = content;
        }
    }
}
