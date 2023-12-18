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

namespace Proiect
{
    /// <summary>
    /// Interaction logic for adminUpAcc.xaml
    /// </summary>
    public partial class adminUpAcc : Window
    {
        public adminUpAcc()
        {

            InitializeComponent();
            initializeComboBoxes();
           


        }

        private void initializeComboBoxes()
        {
            upgrades.Items.Add("student");
            upgrades.Items.Add("professor");
            upgrades.Items.Add("admin");
            // De test
            dbDataContext context = new dbDataContext();
            var lista = context.Users.Select(user => user.username).ToList();
            foreach (var el in lista)
                userList.Items.Add(el.ToString());
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
            admin adminpage = new admin();
            adminpage.Show();
            this.Close();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            selectStatus.Text = "";
            if (userList.SelectedItem == null)
            {
                selectStatus.Text = "Please select an user!";
                return;
            }
            if (upgrades.SelectedItem == null)
            {
                selectStatus.Text = "Please select an upgrade!";
                return;
            }
            string user = userList.SelectedItem.ToString();
            string upg = upgrades.SelectedItem.ToString();
            // lucru cu baza de date

            dbDataContext context = new dbDataContext();
            var userToUpdate = context.Users.FirstOrDefault(usr => usr.username.ToString() == user);
            userToUpdate.usertype = upg;
            context.SubmitChanges();
            selectStatus.Text = "Account successfully upgraded!";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            adminEnroll ad = new adminEnroll();
            ad.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            adminReq page = new adminReq();
            page.Show();
            this.Close();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            login page = new login();
            page.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            adminUpAcc page = new adminUpAcc();
            page.Show();
            this.Close();
        }
    }
}
