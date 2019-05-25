using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlTableBuilder
{
    public class Builder
    {
        public List<Tr> Trs { get; }

        public Builder()
        {
            Trs = new List<Tr>();
        }

        public void AddTrToTable(Tr tr)
        {
            Trs.Add(tr);
        }

        public static Builder Create()
        {
            return new Builder();
        }
    }

    public static class BuilderExtensions
    {
        public static string SerializeToString(this Builder build)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<table>");

            foreach (var tr in build.Trs)
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

        public static Builder AddTr(this Builder builder, Tr tr)
        {
            builder.AddTrToTable(tr);
            return builder;
        }

        public static Tr AddChildToTr(this Tr tr, IInsideTr childTr)
        {
            tr.AddToTr(childTr);
            return tr;
        }
    }

    public class Tr
    {
        public List<IInsideTr> TrChild { get; }

        public Tr()
        {
            TrChild = new List<IInsideTr>();
        }

        public void AddToTr(IInsideTr th)
        {
            TrChild.Add(th);
        }
    }

    public class Th : IInsideTr
    {
        public string Content { get; }

        public Th(string content)
        {
            Content = content;
        }
    }

    public class Td : IInsideTr
    {
        public string Content { get; }

        public Td(string content)
        {
            Content = content;
        }
    }

    public interface IInsideTr
    {
        string Content { get; }
    }
}
