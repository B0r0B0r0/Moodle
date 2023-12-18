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
    /// Interaction logic for studentViewYourCourses.xaml
    /// </summary>
    public partial class studentViewYourCourses : Window
    {
        User utilizator;
        public studentViewYourCourses(User utilizator_p)
        {
            InitializeComponent();
            utilizator = utilizator_p;
            Load_Courses();

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
        private void Load_Courses()
        {

            StackPanel coursesStackPanel = new StackPanel
            {
                Width = 450
            };
            dbDataContext context = new dbDataContext();
            var userCoursesQuery = from enrollment in context.Enrollments
                                   join course in context.Courses on enrollment.idcourse equals course.id
                                   where enrollment.iduser == utilizator.id
                                   select new
                                   {
                                       CourseId = course.id,
                                       CourseName = course.coursename,
                                       ProfName = course.courseprof,
                                       CoursePath = course.coursepath,
                                       SubjectId = course.idSubject
                                   };

            var lista = userCoursesQuery.ToList();


            foreach (var item in lista)
            {
                Border border = new Border
                {
                    Width = coursesStackPanel.Width,
                    Height = 80,
                    Background = (Brush)new BrushConverter().ConvertFrom("#2D7A6C"),
                    CornerRadius = new CornerRadius(10, 10, 10, 10),
                    Margin = new Thickness(0, 0, 0, 10)
                };

                StackPanel crsStackPanel = new StackPanel
                {
                    Width = coursesStackPanel.Width,
                    Height = 100
                };
                crsStackPanel.Orientation = Orientation.Vertical;

                StackPanel borderStackPanel = new StackPanel();
                borderStackPanel.Orientation = Orientation.Horizontal;

                StackPanel courseStackPanel = new StackPanel
                {
                    Orientation = Orientation.Horizontal
                };




                StackPanel topInfoStackPanel = new StackPanel
                {
                    Orientation = Orientation.Vertical,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Margin = new Thickness(10, 0, 0, 0)
                };

                var subjectName = context.Courses
                .Where(course => course.id == item.CourseId)
                .Join(context.Subjects, course => course.idSubject, subject => subject.id, (course, subject) => subject.subjectname)
                .FirstOrDefault();

                topInfoStackPanel.Children.Add(new TextBlock
                {
                    Text = $"Subject: {subjectName} - {item.CourseName} by {item.ProfName}",
                    Foreground = Brushes.White,
                    FontFamily = new FontFamily("Bahnschrift Condensed"),
                    FontSize = 20,
                    Margin = new Thickness(10, 10, 0, 0),
                    TextWrapping = TextWrapping.Wrap
                });


                borderStackPanel.Children.Add(courseStackPanel);
                borderStackPanel.Children.Add(topInfoStackPanel);



                crsStackPanel.Children.Add(borderStackPanel);

                border.Child = crsStackPanel;
                border.Tag = item.CoursePath.ToString();
                border.MouseLeftButtonDown += Border_MouseLeftButtonDown;

                coursesStackPanel.Children.Add(border);
            }

            coursesList.Content = coursesStackPanel;
        }


        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Border border)
            {


                if (border.Tag is string coursepath)
                {
                    viewCourse page = new viewCourse(coursepath, "full");
                    page.Show();
                }
                else
                {
                    Console.WriteLine("Invalid Tag format.");
                }
            }
            else
            {
                Console.WriteLine("Invalid sender type.");
            }
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            login page = new login();
            page.Show();
            this.Close();
        }
    }
}
