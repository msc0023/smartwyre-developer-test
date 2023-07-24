using Smartwyre.DeveloperTest.Types;
using Smartwyre.DeveloperTest.Interfaces;
namespace Smartwyre.DeveloperTest.Calculators;

public class FixedCashAmountRebateCalculator : IRebateTypeCalculator {
    public decimal CalculateRebate(Rebate rebate, Product product, CalculateRebateRequest request) {
       return rebate.Amount;
    }
}