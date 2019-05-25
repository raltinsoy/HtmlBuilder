using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HtmlBuilder.Style;

namespace HtmlBuilder.Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var tableStyle = new TableStyle()
            {
                Width = "100%",
                BackgroundColor = "gray",
                Border = "1px solid red"
            };

            var testBuilder = Builder.Create().AddTable(
                new Table(tableStyle: tableStyle)
                    .AddTr(new Tr()
                        .AddChildToTr(new Th("Row1.Col1"))
                        .AddChildToTr(new Th("Row1.Col2"))
                    )
                    .AddTr(new Tr()
                        .AddChildToTr(new Td("Row2.Col1"))
                        .AddChildToTr(new Td("Row2.Col2"))
                    )
                ).SerializeToString();

        }
    }
}
