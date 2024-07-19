using MyFinance.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Provider.Contract
{
    public interface ISpendingPlanRepository
    {
        Task<SpendingPlanGrid> AddSpendingPlan(SpendingPlanInsert spendingPlanInput);
        //Task<SpendingPlanGrid> UpdateSpendingPlan(SpendingPlanUpsert spendingPlanInput);
    }
}
