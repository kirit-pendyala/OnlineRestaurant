using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public class Restaurant
    {
        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }

        [MaxLength(10, ErrorMessage = "Please Enter a Valid Mobile Number")]
        //[RegularExpression(@"[0-9]{3}-[0-9]{3}-[0-9]{4}$", ErrorMessage = "Please enter the phone number as XXX-XXX-XXXX")]
        //[DisplayFormat(DataFormatString = "{0:###-###-####}", ApplyFormatInEditMode = true)]
        [Phone]
        public string CustomerMobile { get; set; }

        public string Item1 { get; set; }

        public string Item2 { get; set; }

        public string Item3 { get; set; }

        public string Item4 { get; set; }

        public string Item5 { get; set; }
    }
}
