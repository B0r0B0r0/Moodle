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

    public partial class studentReqEnroll : Window
    {
        User utilizator;
        public studentReqEnroll(User utilizator_p)
        {
            InitializeComponent();
            utilizator = utilizator_p;
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            dbDataContext context = new dbDataContext();
            var courseNames = context.Courses.Select(course => course.coursename).ToList();
            foreach (var item in courseNames)
            {
                courseList.Items.Add(item.ToString());
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            student page = new student(utilizator);
            page.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            studentViewAllCourses page = new studentViewAllCourses(utilizator);
            page.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            studentViewYourCourses page = new studentViewYourCourses(utilizator);
            page.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            studentReqEnroll page = new studentReqEnroll(utilizator);
            page.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            studentReqUpg page = new studentReqUpg(utilizator);
            page.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (courseList.SelectedItem == null)
                return;
            
            dbDataContext context = new dbDataContext();
            var matchingCourse = context.Courses.Where(course => course.coursename.Contains(courseList.SelectedItem.ToString()));
            if (matchingCourse == null)
                return;

            Request newEntry = new Request
            {
                iduser = utilizator.id,
                request1 = $"Enrollment to course {courseList.SelectedItem.ToString()}"
            };

            context.Requests.InsertOnSubmit(newEntry);
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
