using Smartwyre.DeveloperTest.Types;
using Smartwyre.DeveloperTest.Interfaces;
namespace Smartwyre.DeveloperTest.Validators;

public class FixedRateRebateIncentiveValidator : IIncentiveTypeValidator {
    public bool IsIncentiveTypeValid(Rebate rebate, Product product, CalculateRebateRequest request) {
        if (product == null ||
            !product.SupportedIncentives.HasFlag(SupportedIncentiveType.FixedRateRebate) ||
            rebate.Percentage == 0 || product.Price == 0 || request.Volume == 0
            )
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}