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
using System.Text.RegularExpressions;
using System.Security.Cryptography;


namespace Proiect
{
    /// <summary>
    /// Interaction logic for register.xaml
    /// </summary>
    public partial class register : Window
    {
        public register()
        {
            InitializeComponent();
        }

        static string Encode(string rawData)
        {
            // Create a SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                var text_bytes = Encoding.UTF8.GetBytes(builder.ToString());
                var base64String = Convert.ToBase64String(text_bytes);
                return base64String;
            }
        }
        private void textEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtEmail.Focus();
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && txtEmail.Text.Length > 0)
            {
                textEmail.Visibility = Visibility.Collapsed;
            }
            else
            {
                textEmail.Visibility = Visibility.Visible;
            }
        }

        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Focus();
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)
            {
                textPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPassword.Visibility = Visibility.Visible;
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if(txtPassword.Password.ToString() != txtRepeatPassword.Password.ToString())
            {
                MessageBox.Show("Passwords are not the same!");
                return;
            }
            if(txtPassword.Password.ToString()=="" || txtRepeatPassword.Password.ToString()== "" || txtEmail.Text.ToString()== "" || txtUsername.Text.ToString()== "")
            {
                MessageBox.Show("All fields must be completed!");
                return;
            }
            string pattern = @"^[a-zA-Z]+@(gmail|yahoo|hotmail|mta)\.(([cC][oO][mM])|([rR][oO]))$";
            Regex regex = new Regex(pattern);
            if(!regex.IsMatch(txtEmail.Text.ToString()))
            {
                MessageBox.Show("The email is not correct!");
                return;
            }

            dbDataContext context = new dbDataContext();
            
            var utilizatorExistent = context.Users.FirstOrDefault(u => u.username.ToString() == txtUsername.Text.ToString());
            if( utilizatorExistent != null)
            { 
                MessageBox.Show("The user is already registered! Please try to make another account or Log in!");
                return;
            }
            string encoded_pass = Encode(txtPassword.Password.ToString());
            

            User newUser = new User
            {
                username = txtUsername.Text.ToString(),
                userpass = encoded_pass,
                useremail = txtEmail.Text.ToString(),
                usertype = "student"
            };

            context.Users.InsertOnSubmit(newUser);
            context.SubmitChanges();
            student page = new student(newUser);
            page.Show();
            this.Close();
        }

        private void textUsername_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtUsername.Focus();
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && txtUsername.Text.Length > 0)
            {
                textUsername.Visibility = Visibility.Collapsed;
            }
            else
            {
                textUsername.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            login loginpage = new login();
            loginpage.Show();
            this.Close();
        }

        private void textRepeatPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtRepeatPassword.Focus();
        }

        private void txtRepeatPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRepeatPassword.Password) && txtRepeatPassword.Password.Length > 0)
            {
                textRepeatPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textRepeatPassword.Visibility = Visibility.Visible;
            }

        }
    }
}
