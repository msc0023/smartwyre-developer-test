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
         due to the validations around rebates. If testing against actual data, please comment out lines 15 - 20 
         and fetch data from the db instead.
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
