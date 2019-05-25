﻿using System;
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

namespace HtmlTableBuilder.Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var testBuilder = Builder.Create()
                 .AddTr(new Tr()
                     .AddChildToTr(
                         new Th("Th1")
                     )
                     .AddChildToTr(
                         new Th("Th2")
                     )
                 )
                 .AddTr(new Tr()
                    .AddChildToTr(
                        new Td("Td1")
                     )
                     .AddChildToTr(
                        new Td("Td2")
                     )
                 )
                 .SerializeToString();
            
        }
    }
}
