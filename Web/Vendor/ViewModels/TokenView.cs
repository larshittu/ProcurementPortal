using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vendor.ViewModels
{
    [NotMapped]
    public class TokenView
    {
        public string UserTokenID { get; set; }
        public string TokenDescription { get; set; }
    }
}
