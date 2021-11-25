﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.AppService.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Tests.TestsCase
{
    public class SiteOperationsTests : AppServiceTestBase
    {
        public SiteOperationsTests(bool isAsync)
    : base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<Site> CreateSiteAsync(string siteName)
        {
            var container = (await CreateResourceGroupAsync()).GetSites();
            var input = ResourceDataHelper.GetBasicSiteData(DefaultLocation);
            var lro = await container.CreateOrUpdateAsync(siteName, input);
            return lro.Value;
        }

        [TestCase]
        [RecordedTest]
        public async Task Delete()
        {
            var siteName = Recording.GenerateAssetName("testSite-");
            var plan = await CreateSiteAsync(siteName);
            await plan.DeleteAsync();
        }

        [TestCase]
        [RecordedTest]
        public async Task Get()
        {
            var siteName = Recording.GenerateAssetName("testSite-");
            var site1 = await CreateSiteAsync(siteName);
            Site site2 = await site1.GetAsync();

            ResourceDataHelper.AssertSite(site1.Data, site2.Data);
        }
    }
}
