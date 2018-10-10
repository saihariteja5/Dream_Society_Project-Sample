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
using System.Data.OleDb;
using System.Configuration;

namespace Dream_Society_Project.UserControls
{
    /// <summary>
    /// Interaction logic for UserDetail.xaml
    /// </summary>
    public partial class UserDetail : UserControl
    {
        public UserDetail()
        {
            InitializeComponent();
        }

        private void buttonclicked(object sender, RoutedEventArgs e)
        {
            UserBank_Detail ucb = new UserBank_Detail();
            stackDetail.Children.Add(ucb);
          //  var usercontrols = UserBank_Detail();

        }

        private void btnsave(object sender, RoutedEventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "insert into tbl_details values('@Name',@GroupName,@occupation,@village,@mandal,@Branchname,@Address,@Contact,@Aadhar,@lead)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Name", txtFullName.Text);
            cmd.Parameters.AddWithValue("@GroupName", txtEmail.Text);
            cmd.Parameters.AddWithValue("@occupation", rbtGender.SelectedValue);
            cmd.Parameters.AddWithValue("@village", txtVillage.Text);
            cmd.Parameters.AddWithValue("@mandal", txtMandal.Text);
            cmd.Parameters.AddWithValue("@Branchname", txt.SelectedValue);
            cmd.Parameters.AddWithValue("@Address", txttAdress.Text);
            cmd.Parameters.AddWithValue("@Contact", rbtGender.SelectedValue);
            cmd.Parameters.AddWithValue("@Aadhar", txtAadhar.Text);
            if (leadRb.IsChecked==true)
	            {
                 int nval=1;
		         cmd.Parameters.AddWithValue("@lead",nval );
	            }
            else if(memberRb.IsChecked==true)
            {
                int nval = 0;
                cmd.Parameters.AddWithValue("@lead", nval);
            }
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }
    }
}
