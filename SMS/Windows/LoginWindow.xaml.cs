using SMS.Helpers;
using SMS.Model;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();


            //bool validate = true;

            //SMSContext db = new SMSContext();
            //string userName = txtUserName.Text;
            //string password = SecurityHelper.CalculateMD5Hash(txtPassword.Password);

            //if (userName.Trim().Length == 0)
            //{
            //    validate = false;
            //    lblUserNameValidation.Content = "Istifadəçi adını daxil edin!";
            //}
            //if (userName.Trim().Length == 0)
            //{
            //    validate = false;
            //    lblPasswordValidation.Content = "Şifrəni daxil edin!";
            //}

            //if (validate)
            //{
            //    User user = db.User.FirstOrDefault(x => x.UserName == userName && x.Password == password);

            //    if (user != null)
            //    {
            //        if (user.Status)
            //        {
            //            MessageBox.Show("Sizin girişinizə məhdudiyyət qoyulub", "Xəbərdarlıq", MessageBoxButton.OK, MessageBoxImage.Warning);
            //        }
            //        else
            //        {
            //            MainWindow mainWindow = new MainWindow();
            //            mainWindow.Show();
            //            this.Close();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Daxil etdiyiniz şifrə və ya istifadəçi adı yanlışdır! ", "Xəbərdarlıq", MessageBoxButton.OK, MessageBoxImage.Error);
            //    }
            //}

           


        }
    }
}
