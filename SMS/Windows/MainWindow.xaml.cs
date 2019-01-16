using SMS.Helpers;
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

        private void itemUser_Click(object sender, RoutedEventArgs e)
        {
            FillFrame(SMSPage.UserPage);
        }

        private void itemStudent_Click(object sender, RoutedEventArgs e)
        {
            FillFrame(SMSPage.StudentPage);
        }

        private void FillFrame(SMSPage page)
        {
            string path = null;

            switch (page)
            {
                case SMSPage.StudentPage:
                    path = "Pages/StudentPage.xaml";
                    break;
                case SMSPage.UserPage:
                    path= "Pages/UserPage.xaml";
                    break;
                default:
                    break;
            }

            frmMain.Navigate(new Uri(path, UriKind.RelativeOrAbsolute));


        }


    }
}
