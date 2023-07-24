using Smartwyre.DeveloperTest.Types;
using Smartwyre.DeveloperTest.Interfaces;
namespace Smartwyre.DeveloperTest.Validators;

public class FixedCashAmountIncentiveValidator : IIncentiveTypeValidator {
    public bool IsIncentiveTypeValid(Rebate rebate, Product product, CalculateRebateRequest request) {
        if (!product.SupportedIncentives.HasFlag(SupportedIncentiveType.FixedCashAmount) ||
            rebate.Amount == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
