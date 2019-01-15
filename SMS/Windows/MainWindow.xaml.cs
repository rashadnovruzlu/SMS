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
using System.Windows.Shapes;

namespace SMS.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = sender as MenuItem;
            this.Title = "File: " + item.Header;
        }

        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {
            MenuItem item = sender as MenuItem;
            this.Title = "Edit: " + item.Header;
        }

        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {
            MenuItem item = sender as MenuItem;
            this.Title = "View: " + item.Header;
        }
    }
}
