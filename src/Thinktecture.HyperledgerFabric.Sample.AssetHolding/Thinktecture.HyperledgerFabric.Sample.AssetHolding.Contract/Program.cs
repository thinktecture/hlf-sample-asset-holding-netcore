﻿using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Thinktecture.HyperledgerFabric.Chaincode;
using Thinktecture.HyperledgerFabric.Chaincode.Handler;

namespace Thinktecture.HyperledgerFabric.Sample.AssetHolding.Contract
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var provider = ChaincodeProviderConfiguration.ConfigureWithContracts<AssetHolding>(args))
            {
                var shim = provider.GetRequiredService<Shim>();
                await shim.Start();
            }
        }
    }
}
