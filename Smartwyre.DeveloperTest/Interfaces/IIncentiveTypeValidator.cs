namespace Smartwyre.DeveloperTest.Interfaces;
using Smartwyre.DeveloperTest.Types;

interface IIncentiveTypeValidator {
    bool IsIncentiveTypeValid(Rebate rebate, Product product, CalculateRebateRequest request);
}