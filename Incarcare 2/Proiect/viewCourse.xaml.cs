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
    /// Interaction logic for viewCourse.xaml
    /// </summary>
    public partial class viewCourse : Window
    {
        string path, type;
        bool isEditable;
        public viewCourse(string path_p, string type_p, bool isEditable_p)
        {
            InitializeComponent();
            path = path_p;
            type = type_p;
            isEditable = isEditable_p;
            course.AcceptsReturn = isEditable;
            readFromFile(path,type);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(isEditable)
                File.WriteAllText(path, course.Text);
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void readFromFile(string path, string type)
        {
            if (path == null)
                return;

            if (type == "full")
            {
                StreamReader reader = new StreamReader(path);
                course.Text = reader.ReadToEnd();
            }
            else if(type=="preview")
            {
                StreamReader reader = new StreamReader(path);

                int fileSize = (int)reader.BaseStream.Length;
                int bytesToRead = (int)(fileSize * 0.1); 

                char[] buffer = new char[bytesToRead];
                int bytesRead = reader.Read(buffer, 0, bytesToRead);

                if (bytesRead > 0)
                {
                    course.Text = new string(buffer);
                }

            }
        }

    }
}
