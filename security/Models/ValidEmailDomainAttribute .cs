using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace security.Models
{

        public class ValidEmailDomainAttribute : ValidationAttribute
        {
            private readonly string allowedDomain;

            public ValidEmailDomainAttribute()
            {
            
                DomainValid dv = new DomainValid();
                this.allowedDomain = dv.Domain;
            }

            public override bool IsValid(object value)
            {
            if (value == null)
            {
                return false;
            }
            
                
                    string[] strings = value.ToString().Split('@');
                    return strings[1].ToUpper() == allowedDomain.ToUpper();
                
                
            }
        }
}
