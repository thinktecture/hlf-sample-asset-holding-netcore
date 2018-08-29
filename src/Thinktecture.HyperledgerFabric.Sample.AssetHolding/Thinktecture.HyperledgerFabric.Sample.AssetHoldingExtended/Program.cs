using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Thinktecture.HyperledgerFabric.Chaincode;
using Thinktecture.HyperledgerFabric.Chaincode.Handler;

namespace Thinktecture.HyperledgerFabric.Sample.AssetHoldingExtended
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var providers = ChaincodeProviderConfiguration.Configure<AssetHoldingExtended>(args))
            {
                var shim = providers.GetRequiredService<Shim>();
                await shim.Start();
            }
        }
    }
}
