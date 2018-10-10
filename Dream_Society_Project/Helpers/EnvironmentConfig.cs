using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream_Society_Project.EnvironmentConfigurartion
{
    public class EnvironmentConfig
    {
        public const string dataSource = "DataSource";
      
        public static string DataSourceValue 
        {
            set 
            {
                if (!string.IsNullOrEmpty(value)) 
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings[dataSource].Value = value;
                    config.Save(ConfigurationSaveMode.Full, true);
                    ConfigurationManager.RefreshSection("appSettings");
                }                
            }           
        }

        public static string ConnectionString
        {
            get
            {
                return string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};User Id=Admin;Password=", ConfigurationManager.AppSettings[dataSource]); 
            }            
        }

        
    }
}
