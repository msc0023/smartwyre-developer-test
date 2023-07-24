using System;
using Xunit;
using Smartwyre.DeveloperTest.Services;
using Smartwyre.DeveloperTest.Types;
using Smartwyre.DeveloperTest.Calculators;
using Smartwyre.DeveloperTest.Validators;

namespace Smartwyre.DeveloperTest.Tests;
public class IncentiveValidatorTests
{
    // Testing Validators
    #region FixedCashAmount
    [Fact]
    public void FixedCashAmountRebateIsNull()
    {
        Product product = new Product() {
            Price = 1,
            Identifier = "Test",
            Id = 1, 
            Uom = "Test", 
            SupportedIncentives = SupportedIncentiveType.FixedCashAmount
        };
        Rebate rebate = null;
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 3
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.False(actual);
    }

    [Fact]
    public void FixedCashAmountRebateIsUnsupported()
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
            Incentive = IncentiveType.FixedCashAmount, 
            Amount = 2, 
            Percentage = 15
        };
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 3
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.False(actual);
    }
   
    [Fact]
    public void FixedCashAmountRebateIsZero()
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
            Amount = 0, 
            Percentage = 15
        };
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 3
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.False(actual);
    }

    [Fact]
    public void FixedCashAmountRebateIsValidAndSaved()
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
            Amount = 10, 
            Percentage = 15
        };
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 3
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.True(actual);
    }
    #endregion

    #region FixedRate
    [Fact]
    public void FixedRateRebateRebateIsNull()
    {
        Product product = new Product() {
            Price = 1,
            Identifier = "Test",
            Id = 1, 
            Uom = "Test", 
            SupportedIncentives = SupportedIncentiveType.FixedRateRebate
        };
        Rebate rebate = null;
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 3
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.False(actual);
    }

    [Fact]
    public void FixedRateRebateProductIsNull()
    {
        Product product = null;
        Rebate rebate = new Rebate() {
            Identifier = "Test", 
            Incentive = IncentiveType.FixedRateRebate, 
            Amount = 2, 
            Percentage = 15
        };;
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 3
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.False(actual);
    }

    [Fact]
    public void FixedRateRebateIsUnsupported()
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
            Incentive = IncentiveType.FixedRateRebate, 
            Amount = 2, 
            Percentage = 15
        };
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 3
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.False(actual);
    }

    [Fact]
    public void FixedRateRebatePercentageIsZero()
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
            Amount = 10, 
            Percentage = 0
        };
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 3
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.False(actual);
    }

    [Fact]
    public void FixedRateRebatePriceIsZero()
    {
        Product product = new Product() {
            Price = 0,
            Identifier = "Test",
            Id = 1, 
            Uom = "Test", 
            SupportedIncentives = SupportedIncentiveType.FixedRateRebate
        };
        Rebate rebate = new Rebate() {
            Identifier = "Test", 
            Incentive = IncentiveType.FixedRateRebate, 
            Amount = 10, 
            Percentage = 15
        };
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 3
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.False(actual);
    }

    [Fact]
    public void FixedRateRebateVolumeIsZero()
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
            Amount = 10, 
            Percentage = 15
        };
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 0
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.False(actual);
    }

    [Fact]
    public void FixedRateRebateIsValidAndSaved()
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
            Amount = 10, 
            Percentage = 15
        };
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 20
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.True(actual);
    }
    #endregion

    #region AmountPerUom
    [Fact]
    public void AmountPerUomRebateIsNull()
    {
        Product product = new Product() {
            Price = 1,
            Identifier = "Test",
            Id = 1, 
            Uom = "Test", 
            SupportedIncentives = SupportedIncentiveType.AmountPerUom
        };
        Rebate rebate = null;
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 3
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.False(actual);
    }

    [Fact]
    public void AmountPerUomProductIsNull()
    {
        Product product = null;
        Rebate rebate = new Rebate() {
            Identifier = "Test", 
            Incentive = IncentiveType.AmountPerUom, 
            Amount = 2, 
            Percentage = 15
        };;
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 3
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.False(actual);
    }

    [Fact]
    public void AmountPerUomRebateAmountIsZero()
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
            Amount = 0, 
            Percentage = 15
        };
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 20
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.False(actual);
    }

    [Fact]
    public void AmountPerUomRebateVolumeIsZero()
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
            Amount = 10, 
            Percentage = 15
        };
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 0
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.False(actual);
    }

    [Fact]
    public void AmountPerUomIsValidAndSaved()
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
            Amount = 10, 
            Percentage = 15
        };
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 20
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.True(actual);
    }

    [Fact]
    public void AmountPerUomRebateIsUnsupported()
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
            Incentive = IncentiveType.AmountPerUom, 
            Amount = 2, 
            Percentage = 15
        };
        CalculateRebateRequest request = new CalculateRebateRequest() {
            RebateIdentifier = "Test", 
            ProductIdentifier = "Test", 
            Volume = 3
        };
        IncentiveValidator validator = new IncentiveValidator();
        bool actual = validator.IsRebateIncentiveValid(rebate, product, request);
        Assert.False(actual);
    }
    #endregion

}