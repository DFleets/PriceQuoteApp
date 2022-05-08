using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PriceQuoteApp.Models
{
    public class PriceQuoteAppModel
    {
        
        [Range(1, int.MaxValue, ErrorMessage = "Must be a valid number greater than 0")]
        [Required(ErrorMessage = "Must not be 0")]
        public decimal? SubTotal { get; set; }

        
        [Range(0, 100, ErrorMessage = "Must be a valid number between 0 to 100")]
        [Required(ErrorMessage = "Enter a valid number")]
        public decimal? DiscountPercent { get; set; }

        [Display(Name = "Discount Amount")]
        public decimal? DiscountAmount { get; set; }

        [Display(Name = "Total")]
        public decimal? Total { get; set; }

    }
}
