﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Tests.Helpers
{
    public static class ResourceDataHelper
    {
        private const string dummySSHKey = "ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQC+wWK73dCr+jgQOAxNsHAnNNNMEMWOHYEccp6wJm2gotpr9katuF/ZAdou5AaW1C61slRkHRkpRRX9FA9CYBiitZgvCCz+3nWNN7l/Up54Zps/pHWGZLHNJZRYyAB6j5yVLMVHIHriY49d/GZTZVNB8GoJv9Gakwc/fuEZYYl4YDFiGMBP///TzlI4jhiJzjKnEvqPFki5p2ZRJqcbCiF4pJrxUQR/RXqVFQdbRLZgYfJ8xGB878RENq3yQ39d8dVOkq4edbkzwcUmwwwkYVPIoDGsYLaRHnG+To7FvMeyO7xDVQkMKzopTQV8AuKpyvpqu0a9pWOMaiCyDytO7GGN you@me.com";

        // Temporary solution since the one in Azure.ResourceManager.AppService is internal
        public static IDictionary<string, string> ReplaceWith(this IDictionary<string, string> dest, IDictionary<string, string> src)
        {
            dest.Clear();
            foreach (var kv in src)
            {
                dest.Add(kv);
            }

            return dest;
        }

        public static void AssertTrackedResource(TrackedResource r1, TrackedResource r2)
        {
            Assert.AreEqual(r1.Name, r2.Name);
            Assert.AreEqual(r1.Id, r2.Id);
            Assert.AreEqual(r1.Type, r2.Type);
            Assert.AreEqual(r1.Location, r2.Location);
            Assert.AreEqual(r1.Tags, r2.Tags);
        }

        #region AppServicePlan
        public static void AssertPlan(AppServicePlanData plan1, AppServicePlanData plan2)
        {
            AssertTrackedResource(plan1, plan2);
            Assert.AreEqual(plan1.ExtendedLocation, plan2.ExtendedLocation);
        }

        public static AppServicePlanData GetBasicAppServicePlanData(Location location)
        {
            var data = new AppServicePlanData(location)
            {
                //Location = "AZURE_LOCATION",
                Sku = new SkuDescription
                {
                Name = "S1",
                Tier = "STANDARD",
                Capacity =  1
                },
                PerSiteScaling = false,
                IsXenon = false
            };
            return data;
        }
        #endregion

        #region Site

        public static void AssertSite(SiteData site1, SiteData site2)
        {
            AssertTrackedResource(site1, site2);
            Assert.AreEqual(site1.EnabledHostNames, site2.EnabledHostNames);
        }

        public static SiteData GetBasicSiteData(Location location)//, string description = null)
        {
            var data = new SiteData(location)
            {
                /*Reserved = false,
                IsXenon = false,
                HyperV = false,
                SiteConfig = new SiteConfig
                {
                    NetFrameworkVersion = "v4.6",
                    AppSettings =
                    {
                        new NameValuePair
                        {
                            Name = "WEBSITE_NODE_DEFAULT_VERSION",
                            Value = "10.14"
                        }
                    },
                    LocalMySqlEnabled = false,
                    Http20Enabled = true
                },
                ScmSiteAlsoStopped = false,
                HttpsOnly = false*/
            };
            return data;
        }
        #endregion

        #region SiteSlot
        public static void AssertSiteSlot(SiteData site1, SiteData site2)
        {
            AssertTrackedResource(site1, site2);
            Assert.AreEqual(site1.EnabledHostNames, site2.EnabledHostNames);
        }

        public static SiteData GetBasicSiteSlotData(Location location, string description = null)
        {
            var data = new SiteData(location)
            {
                Reserved = false,
                IsXenon = false,
                HyperV = false,
                SiteConfig = new SiteConfig
                {
                    NetFrameworkVersion = "v4.6",
                    LocalMySqlEnabled = false,
                    Http20Enabled = true
                },
                ScmSiteAlsoStopped = false,
            };
            return data;
        }
        #endregion

        #region SiteSlotConfigWeb
        public static SiteConfigResourceData GetBasicSiteConfigResourceData(Location location, string description = null)
        {
            /*IDictionary<string, IList<string>> header = new ChangeTrackingDictionary<string, IList<string>>();
            IList<string> ipAddress = new List<string>();
            ipAddress.Add("Any");
            IList<string> action = new List<string>();
            action.Add("Allow");
            IList<string> priority = new List<string>();
            priority.Add("1");
            IList<string> name = new List<string>();
            name.Add("Allow all");
            IList<string> descriptionlist = new List<string>();
            descriptionlist.Add("Allow all accesss");
            header.Add("ip_adddress", ipAddress);
            header.Add("action", action);
            header.Add("priority", priority);
            header.Add("name", name);
            header.Add("description",descriptionlist);*/
            var data = new SiteConfigResourceData()
            {
                DefaultDocuments =
                {
                    "Default.htm",
                    "Default.html",
                    "Default.asp",
                    "index.htm",
                    "index.html",
                    "iisstart.htm",
                    "default.aspx",
                    "index.php",
                    "hostingstart.html"
                },
                IpSecurityRestrictions =
                {
                    new IpSecurityRestriction
                    {
                    IpAddress = "Any",
                    Action = "Allow",
                    Priority = 1,
                    Name =  "Allow all",
                    Description = "Allow all access"
                    }
                },
                ScmIpSecurityRestrictions =
                {
                    new IpSecurityRestriction
                    {
                    IpAddress = "Any",
                    Action = "Allow",
                    Priority = 1,
                    Name =  "Allow all",
                    Description = "Allow all access"
                    }
                },
                VirtualApplications =
                {
                    new VirtualApplication
                    {
                    VirtualPath =  "/",
                    PhysicalPath =  "site\\wwwroot",
                    PreloadEnabled =  true
                    }
                }
            };
            return data;
        }
        #endregion

        #region SiteSourceControlData(SiteSlotSourcecontrol)
        public static void AssertSiteSourceControlData(SiteSourceControlData sscd1, SiteSourceControlData sscd2)
        {
            Assert.AreEqual(sscd1.Name, sscd2.Name);
            Assert.AreEqual(sscd1.Id, sscd2.Id);
            Assert.AreEqual(sscd1.Type, sscd2.Type);
            Assert.AreEqual(sscd1.Branch, sscd2.Branch);
        }

        public static SiteSourceControlData GetBasicSiteSourceControlData()
        {
            var data = new SiteSourceControlData()
            {
                RepoUrl = "https://github.com/00Kai0/azure-site-test",
                Branch = "staging",
                IsManualIntegration = true,
                IsMercurial = false,
            };
            return data;
        }
        #endregion

        #region StaticSiteARMResourceData(StaticSiteRestOperation)
        public static void AssertStaticSiteARMSourceData(StaticSiteARMResourceData ssrd1, StaticSiteARMResourceData ssrd2)
        {
            AssertTrackedResource(ssrd1, ssrd2);
            Assert.AreEqual(ssrd1.Branch, ssrd2.Branch);
            Assert.AreEqual(ssrd1.RepositoryUrl, ssrd2.RepositoryUrl);
            Assert.AreEqual(ssrd1.Kind, ssrd2.Kind);
        }

        public static StaticSiteARMResourceData GetBasicStaticSiteARMSourceData(Location location)
        {
            var data = new StaticSiteARMResourceData(location)
            {
                Sku = new SkuDescription()
                {
                    Name = "Basic",
                    Tier = "Basic"
                },
                RepositoryUrl = "https://github.com/username/RepoName",
                Branch = "master",
                RepositoryToken = "repoToken123",
                BuildProperties = new StaticSiteBuildProperties()
                {
                    AppLocation = "app",
                    ApiLocation = "api",
                    AppArtifactLocation = "build"
                }
            };
            return data;
        }
        #endregion

        #region Certificate
        public static void AssertCertificate(Certificate certificate1, Certificate certificate2)
        {
            //AssertTrackedResource(certificate1, certificate2);
            Assert.AreEqual(certificate1.Data.CanonicalName, certificate2.Data.CanonicalName);
        }

        public static CertificateData GetBasicCertificateData(Location location)
        {
            var data = new CertificateData(location)
            {
                Location = location,
                HostNames =
                {
                    "ServerCert"
                },
                Password = "SWsSsd__233$Sdsds#%Sd!"
            };
            return data;
        }
        #endregion
    }
}
