// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    /// <summary> Batch will retry Tasks when a recovery operation is triggered on a Node. Examples of recovery operations include (but are not limited to) when an unhealthy Node is rebooted or a Compute Node disappeared due to host failure. Retries due to recovery operations are independent of and are not counted against the maxTaskRetryCount. Even if the maxTaskRetryCount is 0, an internal retry due to a recovery operation may occur. Because of this, all Tasks should be idempotent. This means Tasks need to tolerate being interrupted and restarted without causing any corruption or duplicate data. The best practice for long running Tasks is to use some form of checkpointing. </summary>
    public partial class TaskAddParameter
    {
        /// <summary> Initializes a new instance of TaskAddParameter. </summary>
        /// <param name="id"> The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two IDs within a Job that differ only by case). </param>
        /// <param name="commandLine"> For multi-instance Tasks, the command line is executed as the primary Task, after the primary Task and all subtasks have finished executing the coordination command line. The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using &quot;cmd /c MyCommand&quot; in Windows or &quot;/bin/sh -c MyCommand&quot; in Linux. If the command line refers to file paths, it should use a relative path (relative to the Task working directory), or use the Batch provided environment variable (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="commandLine"/> is null. </exception>
        public TaskAddParameter(string id, string commandLine)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (commandLine == null)
            {
                throw new ArgumentNullException(nameof(commandLine));
            }

            Id = id;
            CommandLine = commandLine;
            ResourceFiles = new ChangeTrackingList<ResourceFile>();
            OutputFiles = new ChangeTrackingList<OutputFile>();
            EnvironmentSettings = new ChangeTrackingList<EnvironmentSetting>();
            ApplicationPackageReferences = new ChangeTrackingList<ApplicationPackageReference>();
        }

        /// <summary> The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two IDs within a Job that differ only by case). </summary>
        public string Id { get; }
        /// <summary> The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </summary>
        public string DisplayName { get; set; }
        /// <summary> For multi-instance Tasks, the command line is executed as the primary Task, after the primary Task and all subtasks have finished executing the coordination command line. The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using &quot;cmd /c MyCommand&quot; in Windows or &quot;/bin/sh -c MyCommand&quot; in Linux. If the command line refers to file paths, it should use a relative path (relative to the Task working directory), or use the Batch provided environment variable (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables). </summary>
        public string CommandLine { get; }
        /// <summary> If the Pool that will run this Task has containerConfiguration set, this must be set as well. If the Pool that will run this Task doesn&apos;t have containerConfiguration set, this must not be set. When this is specified, all directories recursively below the AZ_BATCH_NODE_ROOT_DIR (the root of Azure Batch directories on the node) are mapped into the container, all Task environment variables are mapped into the container, and the Task command line is executed in the container. Files produced in the container outside of AZ_BATCH_NODE_ROOT_DIR might not be reflected to the host disk, meaning that Batch file APIs will not be able to access those files. </summary>
        public TaskContainerSettings ContainerSettings { get; set; }
        /// <summary> How the Batch service should respond when the Task completes. </summary>
        public ExitConditions ExitConditions { get; set; }
        /// <summary> For multi-instance Tasks, the resource files will only be downloaded to the Compute Node on which the primary Task is executed. There is a maximum size for the list of resource files.  When the max size is exceeded, the request will fail and the response error code will be RequestEntityTooLarge. If this occurs, the collection of ResourceFiles must be reduced in size. This can be achieved using .zip files, Application Packages, or Docker Containers. </summary>
        public IList<ResourceFile> ResourceFiles { get; }
        /// <summary> For multi-instance Tasks, the files will only be uploaded from the Compute Node on which the primary Task is executed. </summary>
        public IList<OutputFile> OutputFiles { get; }
        /// <summary> A list of environment variable settings for the Task. </summary>
        public IList<EnvironmentSetting> EnvironmentSettings { get; }
        /// <summary> A locality hint that can be used by the Batch service to select a Compute Node on which to start a Task. </summary>
        public AffinityInformation AffinityInfo { get; set; }
        /// <summary> If you do not specify constraints, the maxTaskRetryCount is the maxTaskRetryCount specified for the Job, the maxWallClockTime is infinite, and the retentionTime is 7 days. </summary>
        public TaskConstraints Constraints { get; set; }
        /// <summary> The default is 1. A Task can only be scheduled to run on a compute node if the node has enough free scheduling slots available. For multi-instance Tasks, this must be 1. </summary>
        public int? RequiredSlots { get; set; }
        /// <summary> If omitted, the Task runs as a non-administrative user unique to the Task. </summary>
        public UserIdentity UserIdentity { get; set; }
        /// <summary> Multi-instance Tasks are commonly used to support MPI Tasks. In the MPI case, if any of the subtasks fail (for example due to exiting with a non-zero exit code) the entire multi-instance Task fails. The multi-instance Task is then terminated and retried, up to its retry limit. </summary>
        public MultiInstanceSettings MultiInstanceSettings { get; set; }
        /// <summary> This Task will not be scheduled until all Tasks that it depends on have completed successfully. If any of those Tasks fail and exhaust their retry counts, this Task will never be scheduled. If the Job does not have usesTaskDependencies set to true, and this element is present, the request fails with error code TaskDependenciesNotSpecifiedOnJob. </summary>
        public TaskDependencies DependsOn { get; set; }
        /// <summary> Application packages are downloaded and deployed to a shared directory, not the Task working directory. Therefore, if a referenced package is already on the Node, and is up to date, then it is not re-downloaded; the existing copy on the Compute Node is used. If a referenced Package cannot be installed, for example because the package has been deleted or because download failed, the Task fails. </summary>
        public IList<ApplicationPackageReference> ApplicationPackageReferences { get; }
        /// <summary> If this property is set, the Batch service provides the Task with an authentication token which can be used to authenticate Batch service operations without requiring an Account access key. The token is provided via the AZ_BATCH_AUTHENTICATION_TOKEN environment variable. The operations that the Task can carry out using the token depend on the settings. For example, a Task can request Job permissions in order to add other Tasks to the Job, or check the status of the Job or of other Tasks under the Job. </summary>
        public AuthenticationTokenSettings AuthenticationTokenSettings { get; set; }
    }
}
