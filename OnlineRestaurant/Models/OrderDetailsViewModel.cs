using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public class OrderDetailsViewModel 
    {
        public IList<Dishes> DishesList { get; set; } 
    }
}
