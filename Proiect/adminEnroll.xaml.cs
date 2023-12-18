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
    /// Interaction logic for adminEnroll.xaml
    /// </summary>
    public partial class adminEnroll : Window
    {
       
        public adminEnroll()
        {
            InitializeComponent();
            initializeComboBoxes();
        }
        private void initializeComboBoxes()
        {
            dbDataContext context = new dbDataContext();
            var allUsers = context.Users.ToList();

            foreach(var item in allUsers)
            {
                if(item.usertype.ToString()!="admin")
                    userList.Items.Add(item.username.ToString());
            }
            
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            selectStatus.Text = "";
            if (userList.SelectedItem == null)
            {
                selectStatus.Text = "Please select an user!";
                return;
            }
            if (enrollment.SelectedItem == null)
            {
                selectStatus.Text = "Please select an enrollment!";
                return;
            }
            string username = userList.SelectedItem.ToString();
            string secondSelect = enrollment.SelectedItem.ToString();

            dbDataContext context = new dbDataContext();


            var user = context.Users.FirstOrDefault(u => u.username == username);
            
            if(user.usertype.ToString()=="student")
            {
                var course = context.Courses.FirstOrDefault(c => c.coursename == secondSelect);
                Enrollment newEntry = new Enrollment
                {
                    idcourse = course.id,
                    iduser = user.id
                };
                context.Enrollments.InsertOnSubmit(newEntry);
                context.SubmitChanges();

            }

            if (user.usertype.ToString() == "professor")
            {
                var subject = context.Subjects.FirstOrDefault(s => s.subjectname == secondSelect);
                UsersSubject newEntry = new UsersSubject
                {
                    idsubject = subject.id,
                    iduser = user.id
                };
                context.UsersSubjects.InsertOnSubmit(newEntry);
                context.SubmitChanges();

            }

            selectStatus.Text = "User successfully enrolled!";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            admin adminhome = new admin();
            adminhome.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            adminUpAcc upAcc = new adminUpAcc();
            upAcc.Show();
            this.Close();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            adminReq page = new adminReq();
            page.Show();
            this.Close();
        }

        private void userList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dbDataContext context = new dbDataContext();
            enrollment.Items.Clear();
            var user = context.Users.FirstOrDefault(u => u.username == userList.SelectedItem.ToString());
            if (user.usertype == "student")
            {
                var courseNames = context.Courses.Select(course => course.coursename).ToList();
                foreach (var item in courseNames)
                    enrollment.Items.Add(item.ToString());

            }

            if (user.usertype=="professor")
            {
                var subjectNames = context.Subjects.Select(subject => subject.subjectname).ToList();
                foreach (var item in subjectNames)
                    enrollment.Items.Add(item.ToString());
            }
                
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            login page = new login();
            page.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            adminEnroll page = new adminEnroll();
            page.Show();
            this.Close();
        }
    }
}
