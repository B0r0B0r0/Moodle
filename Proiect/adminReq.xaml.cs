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
    /// Interaction logic for adminReq.xaml
    /// </summary>
    public partial class adminReq : Window
    {
        public adminReq()
        {
            InitializeComponent();
            Load_Requests();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            admin page = new admin();
            page.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            adminUpAcc page = new adminUpAcc();
            page.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            adminEnroll page = new adminEnroll();
            page.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            adminReq page = new adminReq();
            page.Show();
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

        public class RequestInfo
        {
            public int RequestId { get; set; }
            public string RequestText { get; set; }
        }

        private void Load_Requests()
        {
            dbDataContext context = new dbDataContext();

            var query = from req in context.Requests
                        join user in context.Users on req.iduser equals user.id
                        select new
                        {
                            RequestId = req.id,
                            UserId = user.id,
                            UserName = user.username,
                            RequestText = req.request1
                        };

            var lista = query.ToList();

            StackPanel requestsStackPanel = new StackPanel
            {
                Width = 450
            };

            foreach (var item in lista)
            {
                Border border = new Border
                {
                    Width = requestsStackPanel.Width,
                    Height = 80,
                    Background = (Brush)new BrushConverter().ConvertFrom("#2D7A6C"),
                    CornerRadius = new CornerRadius(10, 10, 10, 10),
                    Margin = new Thickness(0, 0, 0, 10)
                };

                StackPanel reqStackPanel = new StackPanel
                {
                    Width = requestsStackPanel.Width,
                    Height = 100
                };
                reqStackPanel.Orientation = Orientation.Vertical;

                StackPanel borderStackPanel = new StackPanel();
                borderStackPanel.Orientation = Orientation.Horizontal;

                StackPanel requestStackPanel = new StackPanel
                {
                    Orientation = Orientation.Horizontal
                };

                StackPanel topInfoStackPanel = new StackPanel
                {
                    Orientation = Orientation.Vertical,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Margin = new Thickness(10, 0, 0, 0)
                };

                var requestInfo = new RequestInfo
                {
                    RequestId = item.RequestId,
                    RequestText = item.RequestText
                };

                topInfoStackPanel.Children.Add(new TextBlock
                {
                    Text = $"Request from user {item.UserName}",
                    Foreground = Brushes.White,
                    FontFamily = new FontFamily("Bahnschrift Condensed"),
                    FontSize = 20,
                    Margin = new Thickness(0, 10, 0, 0),
                    TextWrapping = TextWrapping.Wrap
                });

                borderStackPanel.Children.Add(requestStackPanel);
                borderStackPanel.Children.Add(topInfoStackPanel);

                reqStackPanel.Children.Add(borderStackPanel);

                border.Child = reqStackPanel;

                border.Tag = requestInfo;

                border.MouseLeftButtonDown += Border_MouseLeftButtonDown;

                requestsStackPanel.Children.Add(border);
            }

            reqList.Content = requestsStackPanel;
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Border border)
            {


                if (border.Tag is RequestInfo requestInfo)
                {
                    adminSelect page = new adminSelect(requestInfo.RequestId.ToString(), requestInfo.RequestText.ToString());
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
