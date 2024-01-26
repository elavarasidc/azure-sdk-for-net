// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> This class represents the task details for an automation runbook. </summary>
    public partial class AutomationRunbookTaskDetails : SiteRecoveryTaskTypeDetails
    {
        /// <summary> Initializes a new instance of <see cref="AutomationRunbookTaskDetails"/>. </summary>
        internal AutomationRunbookTaskDetails()
        {
            InstanceType = "AutomationRunbookTaskDetails";
        }

        /// <summary> Initializes a new instance of <see cref="AutomationRunbookTaskDetails"/>. </summary>
        /// <param name="instanceType"> The type of task details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="name"> The recovery plan task name. </param>
        /// <param name="cloudServiceName"> The cloud service of the automation runbook account. </param>
        /// <param name="subscriptionId"> The subscription Id of the automation runbook account. </param>
        /// <param name="accountName"> The automation account name of the runbook. </param>
        /// <param name="runbookId"> The runbook Id. </param>
        /// <param name="runbookName"> The runbook name. </param>
        /// <param name="jobId"> The job Id of the runbook execution. </param>
        /// <param name="jobOutput"> The execution output of the runbook. </param>
        /// <param name="isPrimarySideScript"> A value indicating whether it is a primary side script or not. </param>
        internal AutomationRunbookTaskDetails(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string name, string cloudServiceName, string subscriptionId, string accountName, string runbookId, string runbookName, ResourceIdentifier jobId, string jobOutput, bool? isPrimarySideScript) : base(instanceType, serializedAdditionalRawData)
        {
            Name = name;
            CloudServiceName = cloudServiceName;
            SubscriptionId = subscriptionId;
            AccountName = accountName;
            RunbookId = runbookId;
            RunbookName = runbookName;
            JobId = jobId;
            JobOutput = jobOutput;
            IsPrimarySideScript = isPrimarySideScript;
            InstanceType = instanceType ?? "AutomationRunbookTaskDetails";
        }

        /// <summary> The recovery plan task name. </summary>
        public string Name { get; }
        /// <summary> The cloud service of the automation runbook account. </summary>
        public string CloudServiceName { get; }
        /// <summary> The subscription Id of the automation runbook account. </summary>
        public string SubscriptionId { get; }
        /// <summary> The automation account name of the runbook. </summary>
        public string AccountName { get; }
        /// <summary> The runbook Id. </summary>
        public string RunbookId { get; }
        /// <summary> The runbook name. </summary>
        public string RunbookName { get; }
        /// <summary> The job Id of the runbook execution. </summary>
        public ResourceIdentifier JobId { get; }
        /// <summary> The execution output of the runbook. </summary>
        public string JobOutput { get; }
        /// <summary> A value indicating whether it is a primary side script or not. </summary>
        public bool? IsPrimarySideScript { get; }
    }
}
