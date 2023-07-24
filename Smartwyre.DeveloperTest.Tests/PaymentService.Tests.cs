using System;
using Xunit;
using Smartwyre.DeveloperTest.Services;
using Smartwyre.DeveloperTest.Types;
using Smartwyre.DeveloperTest.Calculators;

namespace Smartwyre.DeveloperTest.Tests;

public class PaymentServiceTests
{
    // Test Payment Calculators work correctly for each type
    [Fact]
    public void FixedRateRebateCalculatorReturnsCorrect()
    {
        Product product = new Product() {
            Price = 1,
            Identifier = "Test",
            Id = 1, 
            Uom = "Test", 
            SupportedIncentives = SupportedIncentiveType.FixedRateRebate
        };
        Rebate rebate = new Rebate() {
            Identifier = "Test", 
            Incentive = IncentiveType.FixedRateRebate, 
            Amount = 2, 
            Percentage = 15
        };
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 3
        };

        RebateCalculator calculator = new RebateCalculator();
        decimal calculatedAmount = calculator.CalculateRebateAmount(rebate, product, request);
        Assert.Equal(45m, calculatedAmount);
    }

    [Fact]
    public void AmountPerUomRebateCalculatorReturnsCorrect()
    {
        Product product = new Product() {
            Price = 1,
            Identifier = "Test",
            Id = 1, 
            Uom = "Test", 
            SupportedIncentives = SupportedIncentiveType.AmountPerUom
        };
        Rebate rebate = new Rebate() {
            Identifier = "Test", 
            Incentive = IncentiveType.AmountPerUom, 
            Amount = 2, 
            Percentage = 15
        };
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 3
        };

        RebateCalculator calculator = new RebateCalculator();
        decimal calculatedAmount = calculator.CalculateRebateAmount(rebate, product, request);
        Assert.Equal(6m, calculatedAmount);
    }

    [Fact]
    public void FixedCashAmountRebateCalculatorReturnsCorrect()
    {
        Product product = new Product() {
            Price = 1,
            Identifier = "Test",
            Id = 1, 
            Uom = "Test", 
            SupportedIncentives = SupportedIncentiveType.FixedCashAmount
        };
        Rebate rebate = new Rebate() {
            Identifier = "Test", 
            Incentive = IncentiveType.FixedCashAmount, 
            Amount = 2, 
            Percentage = 15
        };
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 3
        };

        RebateCalculator calculator = new RebateCalculator();
        decimal calculatedAmount = calculator.CalculateRebateAmount(rebate, product, request);
        Assert.Equal(2m, calculatedAmount);
    }

}
