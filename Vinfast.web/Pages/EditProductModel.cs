using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Vinfast.models;

namespace Vinfast.web.Pages
{
    public class EditProductModel
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }
        public version version { get; set; }
        [Required(ErrorMessage = "Giá không được để trống")]
        public Int64 Price { get; set; }
        public string PhotoPath { get; set; }
       
        public string PriceDisplay { get; set; }

    }
}
