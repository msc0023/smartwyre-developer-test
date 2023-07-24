namespace Smartwyre.DeveloperTest.Interfaces;
using Smartwyre.DeveloperTest.Types;

interface IRebateDataSaver {
    void StoreCalculationResult(Rebate account, decimal rebateAmount);
}