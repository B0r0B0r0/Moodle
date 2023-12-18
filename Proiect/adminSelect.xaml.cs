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
    /// Interaction logic for adminSelect.xaml
    /// </summary>
    public partial class adminSelect : Window
    {
        string requestID;
        public adminSelect(string reqID, string reqTXT)
        {
            InitializeComponent();
            req.Text = reqTXT;
            requestID = reqID;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Sterg din baza de date
            dbDataContext context = new dbDataContext();

            var requestToDelete = context.Requests.FirstOrDefault(r => r.id.ToString() == requestID);

            if (requestToDelete != null)
            {
                context.Requests.DeleteOnSubmit(requestToDelete);
                context.SubmitChanges();
            }

            this.Close();
        }
    }
}
