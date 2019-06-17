using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder
{
    public class Th : IChildOfTr
    {
        public string Content { get; }

        public Th(string content)
        {
            Content = content;
        }

        public string SerializeToString()
        {
            return Content;
        }
    }
}
