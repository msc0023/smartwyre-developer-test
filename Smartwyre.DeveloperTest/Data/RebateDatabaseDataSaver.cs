using Smartwyre.DeveloperTest.Types;
using Smartwyre.DeveloperTest.Interfaces;

namespace Smartwyre.DeveloperTest.Data;

public class RebateDatabaseDataSaver : IRebateDataSaver
{
    public void StoreCalculationResult(Rebate account, decimal rebateAmount)
    {
        // Update account in database, code removed for brevity
    }
}