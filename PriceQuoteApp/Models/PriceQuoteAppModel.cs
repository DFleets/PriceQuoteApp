using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PriceQuoteApp.Models
{
    public class PriceQuoteAppModel
    {
        
        [Range(0, int.MaxValue)]
        [Required(ErrorMessage = "Must be a valid number greater than 0")]
        public decimal? SubTotal { get; set; }

        
        [Range(0, 100)]
        [Required(ErrorMessage = "Must be a valid number between 0 to 100")]
        public decimal? DiscountPercent { get; set; }

        public decimal? DiscountAmount { get; set; }

       
        public decimal? Total { get; set; }

    }
}
