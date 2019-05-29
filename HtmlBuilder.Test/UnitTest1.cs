using HtmlBuilder.Style;
using System;
using Xunit;

namespace HtmlBuilder.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            var tableStyle = new TableStyle()
            {
                Width = "100%",
                BackgroundColor = "gray",
                Border = "1px solid red"
            };

            var testBuilder = Builder.Create().AddTable(
                new Table(tableStyle: tableStyle)
                    .AddTr(new Tr()
                        .AddChild(new Th("First Name"))
                        .AddChild(new Th("Last Name"))
                    )
                    .AddTr(new Tr()
                        .AddChild(new Td("Peter"))
                        .AddChild(new Td("White"))
                    )
                ).SerializeToString();

            var expected = "<table style='width:100%;border:1px solid red;background-color:gray;'>" +
                                "<tr>" +
                                    "<th>First Name</th>" +
                                    "<th>Last Name</th>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th>Peter</th>" +
                                    "<th>White</th>" +
                                "</tr>" +
                            "</table>";

            Assert.Equal(expected, testBuilder);
        }

        [Fact]
        public void TestMethod2()
        {
            var testBuilder = Builder.Create()
                .AddTable(x => x.AddTr(y => y
                                            .AddChild(new Td("Id"))
                                            .AddTd("Fisrt Name")
                                            .AddTd(new Td("Last Name"))
                                       )
                                .AddTr(y => y
                                            .AddChild(new Th("1"))
                                            .AddTh("Peter")
                                            .AddTh(new Th("White"))
                                       )
                                .AddTr(y => y
                                            .AddChild(new Th("2"))
                                            .AddTh("Bob")
                                            .AddTh(new Th("Marley"))
                                       )
                          )
                .SerializeToString();

            var expected = "<table>" +
                                "<tr>" +
                                    "<th>Id</th>" +
                                    "<th>Fisrt Name</th>" +
                                    "<th>Last Name</th>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th>1</th>" +
                                    "<th>Peter</th>" +
                                    "<th>White</th>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th>2</th>" +
                                    "<th>Bob</th>" +
                                    "<th>Marley</th>" +
                                    "</tr>" +
                            "</table>";

            Assert.Equal(expected, testBuilder);
        }
    }
}
