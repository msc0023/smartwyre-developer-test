using Smartwyre.DeveloperTest.Types;
using Smartwyre.DeveloperTest.Interfaces;
namespace Smartwyre.DeveloperTest.Validators;

public class AmountPerUomIncentiveValidator : IIncentiveTypeValidator {
    public bool IsIncentiveTypeValid(Rebate rebate, Product product, CalculateRebateRequest request) {
        if (product == null ||
            !product.SupportedIncentives.HasFlag(SupportedIncentiveType.AmountPerUom) ||
            rebate.Amount == 0 || request.Volume == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}