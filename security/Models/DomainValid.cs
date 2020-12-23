using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace security.Models
{
    public class DomainValid
    {
        string domain = "cognizant.com";
        public string Domain
        {
            get
            {
                return domain;
            }
            set
            {
                domain = value;
            }
        }
    }
}