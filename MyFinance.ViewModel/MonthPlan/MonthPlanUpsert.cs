using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.ViewModel.MonthPlan
{
    public class MonthPlanUpsert
    {
        //[Required(ErrorMessage = "UserId required!")]
        //[Range(1, long.MaxValue, ErrorMessage = "UserId not found in database!")]
        public long? UserId { get; set; }

        [Required(ErrorMessage = "Month required!")]
        [Range(1, 12, ErrorMessage = "Month is incorrect!")]
        public int? Month { get; set; }

        [Required(ErrorMessage = "Month required!")]
        [Range(1, 9999, ErrorMessage = "Month is incorrect!")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Income required!")]
        [Range(1, double.MaxValue, ErrorMessage = "Income is incorrect!")]
        public decimal? Income { get; set; }

    }
}
