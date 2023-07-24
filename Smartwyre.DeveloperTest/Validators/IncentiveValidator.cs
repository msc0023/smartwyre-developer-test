using Smartwyre.DeveloperTest.Types;
namespace Smartwyre.DeveloperTest.Validators;

public class IncentiveValidator {
    public FixedCashAmountIncentiveValidator fixedCashAmountIncentiveValidator;
    public AmountPerUomIncentiveValidator amountPerUomIncentiveValidator;
    public FixedRateRebateIncentiveValidator fixedRateRebateIncentiveValidator;

    public IncentiveValidator() {
        fixedCashAmountIncentiveValidator = new FixedCashAmountIncentiveValidator();
        amountPerUomIncentiveValidator = new AmountPerUomIncentiveValidator();
        fixedRateRebateIncentiveValidator = new FixedRateRebateIncentiveValidator();
    }

    public bool IsRebateIncentiveValid(Rebate rebate, Product product, CalculateRebateRequest request) {
        if(rebate == null) {
            return false;
        }
        switch(rebate.Incentive) {
            case IncentiveType.FixedCashAmount:
                return fixedCashAmountIncentiveValidator.IsIncentiveTypeValid(rebate, product, request);
            case IncentiveType.FixedRateRebate: 
                return fixedRateRebateIncentiveValidator.IsIncentiveTypeValid(rebate, product, request);
            case IncentiveType.AmountPerUom:
                return amountPerUomIncentiveValidator.IsIncentiveTypeValid(rebate, product, request);
            default: 
                return false;
        }
    }
}