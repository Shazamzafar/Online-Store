using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Store.Entities
{
    public class config
    {
        [Key]
        public string id { get; set; }
        public string Value { get; set; }
    }
}
