using Smartwyre.DeveloperTest.Types;

namespace Smartwyre.DeveloperTest.Data;

public class RebateDataStore
{
    public Rebate GetRebate(string rebateIdentifier)
    {
        // Access database to retrieve account, code removed for brevity 
        /* For the sake of testing Application I'm adding a test Rebate object
         Please note that this in reality would look like fetching the value from the db based on the
         identifier string. Since we don't have a db connection here, a test object is required for a console app
         due to the validations around rebates. 
        */ 
        return new Rebate() {
            Identifier = "Test", 
            Incentive = IncentiveType.FixedRateRebate, 
            Amount = 2, 
            Percentage = 15
        };
        //return new Rebate();
    }
}
