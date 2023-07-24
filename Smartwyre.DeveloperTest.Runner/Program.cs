using Smartwyre.DeveloperTest.Services;
using Smartwyre.DeveloperTest.Types;
using System;

namespace Smartwyre.DeveloperTest.Runner;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Rebate Identifier: ");
        var rebateIdentifier = Console.ReadLine();

        Console.WriteLine("Enter a Produce Identifier: ");
        var productIdentifier = Console.ReadLine();

        bool notValidVolume = true;
        while(notValidVolume) {
            Console.WriteLine("Enter a Volume: ");
            var volume = Console.ReadLine();
            
            if(Decimal.TryParse(volume, out decimal volumeDecimal)) {
                notValidVolume = false;
                RebateService rebateService = new RebateService();
                CalculateRebateRequest request = new CalculateRebateRequest() {
                    RebateIdentifier = rebateIdentifier,
                    ProductIdentifier = productIdentifier,
                    Volume = volumeDecimal
                };
                var result = rebateService.Calculate(request);
                if(result.Success) {
                    Console.WriteLine("Rebate Successfully calculated and saved");
                }
            }
            else {
                Console.WriteLine("Volume must be a decimal, please input a valid value.");
            }
        }
        
    }
}
