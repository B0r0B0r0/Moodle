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
using System.IO;
using Microsoft.Win32;

namespace Proiect
{
    /// <summary>
    /// Interaction logic for profAddCourse.xaml
    /// </summary>
    public partial class profAddCourse : Window
    {
        User utilizator;
        string filePath;
        public profAddCourse(User utilizator_p)
        {
            InitializeComponent();
            utilizator = utilizator_p;
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {

            dbDataContext context = new dbDataContext();
            var subjectNames = (
                from userSubject in context.UsersSubjects
                join subject in context.Subjects on userSubject.idsubject equals subject.id
                where userSubject.iduser == utilizator.id
                select subject.subjectname
            ).ToList();

            foreach (var item in subjectNames)
            {
                subj.Items.Add(item.ToString());
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
            professor page = new professor(utilizator);
            page.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            profReqEnroll page = new profReqEnroll(utilizator);
            page.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            profAddCourse page = new profAddCourse(utilizator);
            page.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            profReqAccUpgr page = new profReqAccUpgr(utilizator);
            page.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            profViewCourses page = new profViewCourses(utilizator);
            page.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text|*.txt";
            if (file.ShowDialog() == true)
                previewText.Text = File.ReadAllText(file.FileName);
            filePath = file.FileName.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (filePath == null)
                return;
            if (subj.SelectedItem == null)
                return;
            dbDataContext context = new dbDataContext();
            if (!context.Subjects.Any(subject => subject.subjectname == subj.SelectedItem.ToString()))
                return;
            string type;
            if (utilizator.usertype == "professor lab")
                type = "laborator";
            else
                type = "curs";
            Course newCourse = new Course
            {
                coursename = System.IO.Path.GetFileNameWithoutExtension(filePath),
                coursepath = filePath,
                courseprof = utilizator.username,
                coursetype = type,
                idSubject = (context.Subjects.FirstOrDefault(s => s.subjectname == subj.SelectedItem.ToString())).id
            };

            context.Courses.InsertOnSubmit(newCourse);
            context.SubmitChanges();

            Enrollment newEnrollment = new Enrollment
            {
                iduser = utilizator.id,
                idcourse = newCourse.id
            };

            context.Enrollments.InsertOnSubmit(newEnrollment);
            context.SubmitChanges();
            File.WriteAllText(filePath, previewText.Text);
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            login page = new login();
            page.Show();
            this.Close();
        }

    }
}
