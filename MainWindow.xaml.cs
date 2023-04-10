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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace ADO.Net_Project_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_execute_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=nandhu;Data Source=NANDHU\r\n";
            sql.Open();

            
            SqlCommand cmd = new SqlCommand(txtbox_query.Text,sql);
           int i= cmd.ExecuteNonQuery();
            sql.Close();

            if(i!=-1)
            {
                txtblock_statusbar.Text = "Successfully command executed";
            }
            else if(i==-1)
            {
                txtblock_statusbar.Text = "Error in query";
            }
         
        }
    }
}
