using Dream_Society_Project.EnvironmentConfigurartion;
using DreamSociety.BusinessLayer;
using DreamSociety.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Dream_Society_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string fileName = string.Empty;
        public MainWindow()
        {
            InitializeComponent();                  
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = ".accdb";
            fileDialog.Filter = "Microsoft Access Database (.accdb) | *.accdb*";
            if(fileDialog.ShowDialog()==true)
            {
                txtFileName.Text = fileDialog.FileName;
                fileName = txtFileName.Text.ToString();
                EnvironmentConfig.DataSourceValue = Convert.ToString(fileName.Trim());                
                DataSet dd = AccessDbLoader.LoadFromFile();
                var lll = (from lead in dd.Tables["[tbl_Lead]"].AsEnumerable()
                           join member in dd.Tables["[tbl_Member]"].AsEnumerable()
                           on lead.Field<int>("ID") equals member.Field<int>("LeadId")
                           select new
                           {
                               AadhaarNumber = member.Field<string>("AadharNumber"),
                               Name = member.Field<string>("Member_Name"),
                               Village = lead.Field<string>("Village"),
                               Mandal = lead.Field<string>("Mandal"),
                               BranchName = lead.Field<string>("BranchName")
                           }).ToList();
                grdView.ItemsSource = lll;
                
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = grdView.SelectedItem;   
    
        }
    }
}
