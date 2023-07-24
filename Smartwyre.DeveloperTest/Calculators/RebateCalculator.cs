using Smartwyre.DeveloperTest.Types;
using Smartwyre.DeveloperTest.Interfaces;

namespace Smartwyre.DeveloperTest.Calculators;

public class RebateCalculator {
    public FixedCashAmountRebateCalculator fixedCashAmountRebateCalculator;
    public AmountPerUomRebateCalculator amountPerUomRebateCalculator;
    public FixedRateRebateIncentiveCalculator fixedRateRebateRebateCalculator;

    public RebateCalculator() {
        fixedCashAmountRebateCalculator = new FixedCashAmountRebateCalculator();
        amountPerUomRebateCalculator = new AmountPerUomRebateCalculator();
        fixedRateRebateRebateCalculator = new FixedRateRebateIncentiveCalculator();
    }

    public decimal CalculateRebateAmount(Rebate rebate, Product product, CalculateRebateRequest request) {
        switch(rebate.Incentive) {
            case IncentiveType.FixedCashAmount:
                return fixedCashAmountRebateCalculator.CalculateRebate(rebate, product, request);
            case IncentiveType.FixedRateRebate: 
                return fixedRateRebateRebateCalculator.CalculateRebate(rebate, product, request);
            case IncentiveType.AmountPerUom:
                return amountPerUomRebateCalculator.CalculateRebate(rebate, product, request);
            default: 
                return 0m;
        }
    }
}