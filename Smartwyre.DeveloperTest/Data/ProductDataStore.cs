using Smartwyre.DeveloperTest.Types;

namespace Smartwyre.DeveloperTest.Data;

public class ProductDataStore
{
    public Product GetProduct(string productIdentifier)
    {
        // Access database to retrieve account, code removed for brevity 
        /* For the sake of testing Application I'm adding a test Product object
         Please note that this in reality would look like fetching the value from the db based on the
         identifier string. Since we don't have a db connection here, a test object is required for a console app
         due to the validations around rebates and products. If testing against actual data, please comment out lines 16 - 22 
         and fetch data from the db instead.
        */ 
        return new Product() {
            Price = 1,
            Identifier = "Test",
            Id = 1, 
            Uom = "Test", 
            SupportedIncentives = SupportedIncentiveType.FixedRateRebate
        };
        //return new Product();
    }
}
