// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Samples
{
    public partial class Sample_LocalRulesResource
    {
        // LocalRules_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_LocalRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/LocalRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulesResource created on azure
            // for more information of creating LocalRulesResource, please refer to the document of LocalRulesResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulesResourceId = LocalRulesResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulesResource localRulesResource = client.GetLocalRulesResource(localRulesResourceId);

            // invoke the operation
            LocalRulesResource result = await localRulesResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalRulesResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // LocalRules_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_LocalRulesGetMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/LocalRules_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulesResource created on azure
            // for more information of creating LocalRulesResource, please refer to the document of LocalRulesResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulesResourceId = LocalRulesResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulesResource localRulesResource = client.GetLocalRulesResource(localRulesResourceId);

            // invoke the operation
            LocalRulesResource result = await localRulesResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalRulesResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // LocalRules_CreateOrUpdate_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_LocalRulesCreateOrUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/LocalRules_CreateOrUpdate_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulesResource created on azure
            // for more information of creating LocalRulesResource, please refer to the document of LocalRulesResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulesResourceId = LocalRulesResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulesResource localRulesResource = client.GetLocalRulesResource(localRulesResourceId);

            // invoke the operation
            LocalRulesResourceData data = new LocalRulesResourceData("localRule1")
            {
                ETag = new ETag("c18e6eef-ba3e-49ee-8a85-2b36c863a9d0"),
                Description = "description of local rule",
                RuleState = StateEnum.Disabled,
                Source = new SourceAddr()
                {
                    Cidrs =
{
"1.0.0.1/10"
},
                    Countries =
{
"India"
},
                    Feeds =
{
"feed"
},
                    PrefixLists =
{
"PL1"
},
                },
                NegateSource = BooleanEnum.True,
                Destination = new DestinationAddr()
                {
                    Cidrs =
{
"1.0.0.1/10"
},
                    Countries =
{
"India"
},
                    Feeds =
{
"feed"
},
                    PrefixLists =
{
"PL1"
},
                    FqdnLists =
{
"FQDN1"
},
                },
                NegateDestination = BooleanEnum.True,
                Applications =
{
"app1"
},
                Category = new Category(new string[]
            {
"https://microsoft.com"
            }, new string[]
            {
"feed"
            }),
                Protocol = "HTTP",
                ProtocolPortList =
{
"80"
},
                InboundInspectionCertificate = "cert1",
                AuditComment = "example comment",
                ActionType = ActionEnum.Allow,
                EnableLogging = StateEnum.Disabled,
                DecryptionRuleType = DecryptionRuleTypeEnum.SSLOutboundInspection,
                Tags =
{
new TagInfo("keyName","value")
},
            };
            ArmOperation<LocalRulesResource> lro = await localRulesResource.UpdateAsync(WaitUntil.Completed, data);
            LocalRulesResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalRulesResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // LocalRules_CreateOrUpdate_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_LocalRulesCreateOrUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/LocalRules_CreateOrUpdate_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulesResource created on azure
            // for more information of creating LocalRulesResource, please refer to the document of LocalRulesResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulesResourceId = LocalRulesResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulesResource localRulesResource = client.GetLocalRulesResource(localRulesResourceId);

            // invoke the operation
            LocalRulesResourceData data = new LocalRulesResourceData("localRule1");
            ArmOperation<LocalRulesResource> lro = await localRulesResource.UpdateAsync(WaitUntil.Completed, data);
            LocalRulesResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LocalRulesResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // LocalRules_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_LocalRulesDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/LocalRules_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulesResource created on azure
            // for more information of creating LocalRulesResource, please refer to the document of LocalRulesResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulesResourceId = LocalRulesResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulesResource localRulesResource = client.GetLocalRulesResource(localRulesResourceId);

            // invoke the operation
            await localRulesResource.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // LocalRules_Delete_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_LocalRulesDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/LocalRules_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulesResource created on azure
            // for more information of creating LocalRulesResource, please refer to the document of LocalRulesResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulesResourceId = LocalRulesResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulesResource localRulesResource = client.GetLocalRulesResource(localRulesResourceId);

            // invoke the operation
            await localRulesResource.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // LocalRules_getCounters_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetCounters_LocalRulesGetCountersMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/LocalRules_getCounters_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_getCounters" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulesResource created on azure
            // for more information of creating LocalRulesResource, please refer to the document of LocalRulesResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulesResourceId = LocalRulesResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulesResource localRulesResource = client.GetLocalRulesResource(localRulesResourceId);

            // invoke the operation
            string firewallName = "firewall1";
            RuleCounter result = await localRulesResource.GetCountersAsync(firewallName: firewallName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // LocalRules_getCounters_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetCounters_LocalRulesGetCountersMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/LocalRules_getCounters_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_getCounters" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulesResource created on azure
            // for more information of creating LocalRulesResource, please refer to the document of LocalRulesResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulesResourceId = LocalRulesResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulesResource localRulesResource = client.GetLocalRulesResource(localRulesResourceId);

            // invoke the operation
            RuleCounter result = await localRulesResource.GetCountersAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // LocalRules_refreshCounters_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RefreshCounters_LocalRulesRefreshCountersMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/LocalRules_refreshCounters_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_refreshCounters" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulesResource created on azure
            // for more information of creating LocalRulesResource, please refer to the document of LocalRulesResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulesResourceId = LocalRulesResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulesResource localRulesResource = client.GetLocalRulesResource(localRulesResourceId);

            // invoke the operation
            string firewallName = "firewall1";
            await localRulesResource.RefreshCountersAsync(firewallName: firewallName);

            Console.WriteLine($"Succeeded");
        }

        // LocalRules_refreshCounters_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RefreshCounters_LocalRulesRefreshCountersMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/LocalRules_refreshCounters_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_refreshCounters" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulesResource created on azure
            // for more information of creating LocalRulesResource, please refer to the document of LocalRulesResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulesResourceId = LocalRulesResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulesResource localRulesResource = client.GetLocalRulesResource(localRulesResourceId);

            // invoke the operation
            await localRulesResource.RefreshCountersAsync();

            Console.WriteLine($"Succeeded");
        }

        // LocalRules_resetCounters_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ResetCounters_LocalRulesResetCountersMaximumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/LocalRules_resetCounters_MaximumSet_Gen.json
            // this example is just showing the usage of "LocalRules_resetCounters" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulesResource created on azure
            // for more information of creating LocalRulesResource, please refer to the document of LocalRulesResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulesResourceId = LocalRulesResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulesResource localRulesResource = client.GetLocalRulesResource(localRulesResourceId);

            // invoke the operation
            string firewallName = "firewall1";
            RuleCounterReset result = await localRulesResource.ResetCountersAsync(firewallName: firewallName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // LocalRules_resetCounters_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ResetCounters_LocalRulesResetCountersMinimumSetGen()
        {
            // Generated from example definition: specification/paloaltonetworks/resource-manager/PaloAltoNetworks.Cloudngfw/preview/2022-08-29-preview/examples/LocalRules_resetCounters_MinimumSet_Gen.json
            // this example is just showing the usage of "LocalRules_resetCounters" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LocalRulesResource created on azure
            // for more information of creating LocalRulesResource, please refer to the document of LocalRulesResource
            string subscriptionId = "2bf4a339-294d-4c25-b0b2-ef649e9f5c27";
            string resourceGroupName = "firewall-rg";
            string localRulestackName = "lrs1";
            string priority = "1";
            ResourceIdentifier localRulesResourceId = LocalRulesResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, localRulestackName, priority);
            LocalRulesResource localRulesResource = client.GetLocalRulesResource(localRulesResourceId);

            // invoke the operation
            RuleCounterReset result = await localRulesResource.ResetCountersAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
