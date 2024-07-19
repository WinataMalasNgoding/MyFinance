using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.ViewModel
{
    public class SpendingPlanGrid
    {
        public long SpendingPlanId { get; set; }
        public long MonthPlanId { get; set; }
        public required string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public int DayOfUse { get; set; }
        public int Quantity { get; set; }
    }
}
