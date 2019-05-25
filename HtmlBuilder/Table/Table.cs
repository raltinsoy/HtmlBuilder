using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder
{
    public class Table
    {
        private List<Tr> _trs { get; }

        public IEnumerable<Tr> Trs => _trs;

        public Table()
        {
            _trs = new List<Tr>();
        }

        internal void AddTrInner(Tr tr)
        {
            _trs.Add(tr);
        }
    }
}
