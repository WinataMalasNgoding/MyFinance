using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.ViewModel
{
    public class SpendingPlanUpsert
    {
        [Required(ErrorMessage = "ItemName required!")]
        [StringLength(maximumLength: 200, ErrorMessage = "ItemName max 200 character!")]
        public string? ItemName { get; set; }

        [Required(ErrorMessage = "ItemPrice required!")]
        [Range(1, double.MaxValue, ErrorMessage = "ItemPrice is incorrect!")]
        public decimal? ItemPrice { get; set; }

        [Required(ErrorMessage = "DayOfUse required!")]
        [Range(1, int.MaxValue, ErrorMessage = "DayOfUse is incorrect!")]
        public int? DayOfUse { get; set; }

        [Required(ErrorMessage = "Quantity required!")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity is incorrect!")]
        public int? Quantity { get; set; }
    }

    public class SpendingPlanInsert : SpendingPlanUpsert
    {
        [Required(ErrorMessage = "MonthPlanId required!")]
        [Range(1, long.MaxValue, ErrorMessage = "MonthPlanId not found in database!")]
        public long? MonthPlanId { get; set; }
    }

    public class SpendingPlanUpdate : SpendingPlanUpsert
    {
        [Required(ErrorMessage = "SpendingPlanId required!")]
        [Range(1, long.MaxValue, ErrorMessage = "SpendingPlanId not found in database!")]
        public long? SpendingPlanId { get; set; }
    }
}
