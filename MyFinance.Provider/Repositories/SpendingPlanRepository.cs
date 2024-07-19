using Dapper;
using MyFinance.Provider.Contract;
using MyFinance.ViewModel;
using MyFinance.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Provider.Repositories
{
    public class SpendingPlanRepository : ISpendingPlanRepository
    {
        private readonly IDbConnection _dbConnection;

        public SpendingPlanRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<SpendingPlanGrid> AddSpendingPlan(SpendingPlanInsert spendingPlanInput)
        {
            try
            {
                string queryInsert = @"INSERT INTO dbo.SpendingPlan
                                                   (MonthPlanId
                                                   ,ItemName
                                                   ,ItemPrice
                                                   ,DayOfUse
                                                   ,Quantity)
                                        OUTPUT INSERTED.SpendingPlanId [SpendingPlanId]
		                                        ,INSERTED.MonthPlanId [MonthPlanId]
		                                        ,INSERTED.ItemName [ItemName]
		                                        ,INSERTED.ItemPrice [ItemPrice]
		                                        ,INSERTED.DayOfUse [DayOfUse]
		                                        ,INSERTED.Quantity [Quantity]
                                        VALUES
                                            (@MonthPlanId
                                            ,@ItemName
                                            ,@ItemPrice
                                            ,@DayOfUse
                                            ,@Quantity)";
                return await _dbConnection.QuerySingleAsync<SpendingPlanGrid>(queryInsert, new DynamicParameters(new
                {
                    MonthPlanId = spendingPlanInput.MonthPlanId,
                    ItemName = spendingPlanInput.ItemName,
                    ItemPrice = spendingPlanInput.ItemPrice,
                    DayOfUse = spendingPlanInput.DayOfUse,
                    Quantity = spendingPlanInput.Quantity
                }), commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                throw new GlobalExceptions("tes", ex.InnerException);
            }
        }
    }
}
