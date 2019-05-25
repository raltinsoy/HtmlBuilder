using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder
{
    public class Tr
    {
        private List<IChildOfTr> _trChild { get; }

        public IEnumerable<IChildOfTr> TrChild => _trChild;

        public Tr()
        {
            _trChild = new List<IChildOfTr>();
        }

        internal void AddChildInner(IChildOfTr th)
        {
            _trChild.Add(th);
        }
    }
}
