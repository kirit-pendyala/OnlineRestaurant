using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Please Enter a Valid Mobile Number")]
        //[RegularExpression(@"[0-9]{3}-[0-9]{3}-[0-9]{4}$", ErrorMessage = "Please enter the phone number as XXX-XXX-XXXX")]
        //[DisplayFormat(DataFormatString = "{0:###-###-####}", ApplyFormatInEditMode = true)]
        [Phone]
        public string CustomerMobile { get; set; }

   
    }
}
