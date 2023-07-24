using Smartwyre.DeveloperTest.Data;
using Smartwyre.DeveloperTest.Types;
using Smartwyre.DeveloperTest.Calculators;
using Smartwyre.DeveloperTest.Validators;
using System;

namespace Smartwyre.DeveloperTest.Services;

public class RebateService : IRebateService
{
    public CalculateRebateResult Calculate(CalculateRebateRequest request)
    {
        var rebateDataStore = new RebateDataStore();
        var productDataStore = new ProductDataStore();
        
        Rebate rebate = rebateDataStore.GetRebate(request.RebateIdentifier);
        Product product = productDataStore.GetProduct(request.ProductIdentifier);

        var result = new CalculateRebateResult();

        var rebateAmount = 0m;
        var incentiveValidator = new IncentiveValidator();
        result.Success = incentiveValidator.IsRebateIncentiveValid(rebate, product, request);
        
        // valid result, let's calculate the rebate and save it
        if (result.Success)
        {
            var rebateCalculator = new RebateCalculator();
            rebateAmount = rebateCalculator.CalculateRebateAmount(rebate, product, request);
            var storeRebateDataStore = new RebateDatabaseDataSaver();
            storeRebateDataStore.StoreCalculationResult(rebate, rebateAmount);
        }

        return result;
    }
}
