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
        public List<Dishes> DishesList { get; set; }
        public List<SelectListItem> quantityList { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "0", Text = "0"  },
            new SelectListItem { Value = "1", Text = "1" },
            new SelectListItem { Value = "2", Text = "2" },
            new SelectListItem { Value = "3", Text = "3"  },
            new SelectListItem { Value = "4", Text = "4"  },
            new SelectListItem { Value = "5", Text = "5"  },

        };

    }
}
