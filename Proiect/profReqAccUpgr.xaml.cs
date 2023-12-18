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

namespace Proiect
{
    /// <summary>
    /// Interaction logic for profReqAccUpgr.xaml
    /// </summary>
    public partial class profReqAccUpgr : Window
    {
        User utilizator;
        public profReqAccUpgr(User utilizator_p)
        {
            InitializeComponent();
            utilizator = utilizator_p;
            InitializeComboBox();
        }
        private void InitializeComboBox()
        {
            upgr.Items.Add("Student");
            upgr.Items.Add("Professor");
            upgr.Items.Add("Admin");
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
            professor page = new professor(utilizator);
            page.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            profAddCourse page = new profAddCourse(utilizator);
            page.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            profViewCourses page = new profViewCourses(utilizator);
            page.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            profReqEnroll page = new profReqEnroll(utilizator);
            page.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            profReqAccUpgr page = new profReqAccUpgr(utilizator);
            page.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (upgr.SelectedItem == null)
            {
                MessageBox.Show("Please select an upgrade!");
                return;
            }

            string upgrade = upgr.SelectedItem.ToString();


            dbDataContext context = new dbDataContext();

            Request newRequest = new Request
            {
                iduser = utilizator.id,
                request1 = $"Account Upgrade to {upgrade}"
            };

            context.Requests.InsertOnSubmit(newRequest);
            context.SubmitChanges();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            login page = new login();
            page.Show();
            this.Close();
        }
    }

    
}
