using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Pasteleria_API.Models
{
    public class PasteleriaSettings:IPasteleriaSettings
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Collection { get; set; }
    }

    public interface IPasteleriaSettings
    {
        string Server { get; set; }
        string Database { get; set; }
        string Collection { get; set; }
    }
}
