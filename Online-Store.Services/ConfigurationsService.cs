using Online_Store.Database;
using Online_Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Store.Services
{
    public class ConfigurationsService
    {

        #region Singleton
        public static ConfigurationsService Instance
        {
            get
            {
                if (instance == null) instance = new ConfigurationsService();

                return instance;
            }
        }
        private static ConfigurationsService instance { get; set; }
        private ConfigurationsService()
        {
        }
        #endregion

        public config GetConfig(string id)
        {
            using (var context = new OSContext())
            {
                return context.Configurations.Find(id);
            }
        } 
    }
}
