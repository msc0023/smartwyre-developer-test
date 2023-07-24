using Smartwyre.DeveloperTest.Types;
using Smartwyre.DeveloperTest.Interfaces;
namespace Smartwyre.DeveloperTest.Calculators;

public class FixedRateRebateIncentiveCalculator : IRebateTypeCalculator {
    public decimal CalculateRebate(Rebate rebate, Product product, CalculateRebateRequest request) {
       return product.Price * rebate.Percentage * request.Volume;
    }
}