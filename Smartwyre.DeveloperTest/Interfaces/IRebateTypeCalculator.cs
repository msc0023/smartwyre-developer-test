namespace Smartwyre.DeveloperTest.Interfaces;
using Smartwyre.DeveloperTest.Types;

interface IRebateTypeCalculator {
    decimal CalculateRebate(Rebate rebate, Product product, CalculateRebateRequest request);
}