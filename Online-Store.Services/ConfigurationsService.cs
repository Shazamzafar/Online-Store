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
        public config GetConfig(string id)
        {
            using (var context = new OSContext())
            {
                return context.Configurations.Find(id);
            }
        } 
    }
}
