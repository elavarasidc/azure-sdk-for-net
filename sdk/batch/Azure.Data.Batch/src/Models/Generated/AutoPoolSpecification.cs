// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Data.Batch.Models
{
    /// <summary> Specifies characteristics for a temporary &apos;auto pool&apos;. The Batch service will create this auto Pool when the Job is submitted. </summary>
    public partial class AutoPoolSpecification
    {
        /// <summary> Initializes a new instance of AutoPoolSpecification. </summary>
        /// <param name="poolLifetimeOption"> The minimum lifetime of created auto Pools, and how multiple Jobs on a schedule are assigned to Pools. </param>
        public AutoPoolSpecification(PoolLifetimeOption poolLifetimeOption)
        {
            PoolLifetimeOption = poolLifetimeOption;
        }

        /// <summary> Initializes a new instance of AutoPoolSpecification. </summary>
        /// <param name="autoPoolIdPrefix"> The Batch service assigns each auto Pool a unique identifier on creation. To distinguish between Pools created for different purposes, you can specify this element to add a prefix to the ID that is assigned. The prefix can be up to 20 characters long. </param>
        /// <param name="poolLifetimeOption"> The minimum lifetime of created auto Pools, and how multiple Jobs on a schedule are assigned to Pools. </param>
        /// <param name="keepAlive"> If false, the Batch service deletes the Pool once its lifetime (as determined by the poolLifetimeOption setting) expires; that is, when the Job or Job Schedule completes. If true, the Batch service does not delete the Pool automatically. It is up to the user to delete auto Pools created with this option. </param>
        /// <param name="pool"> Specification for creating a new Pool. </param>
        internal AutoPoolSpecification(string autoPoolIdPrefix, PoolLifetimeOption poolLifetimeOption, bool? keepAlive, PoolSpecification pool)
        {
            AutoPoolIdPrefix = autoPoolIdPrefix;
            PoolLifetimeOption = poolLifetimeOption;
            KeepAlive = keepAlive;
            Pool = pool;
        }

        /// <summary> The Batch service assigns each auto Pool a unique identifier on creation. To distinguish between Pools created for different purposes, you can specify this element to add a prefix to the ID that is assigned. The prefix can be up to 20 characters long. </summary>
        public string AutoPoolIdPrefix { get; set; }
        /// <summary> The minimum lifetime of created auto Pools, and how multiple Jobs on a schedule are assigned to Pools. </summary>
        public PoolLifetimeOption PoolLifetimeOption { get; set; }
        /// <summary> If false, the Batch service deletes the Pool once its lifetime (as determined by the poolLifetimeOption setting) expires; that is, when the Job or Job Schedule completes. If true, the Batch service does not delete the Pool automatically. It is up to the user to delete auto Pools created with this option. </summary>
        public bool? KeepAlive { get; set; }
        /// <summary> Specification for creating a new Pool. </summary>
        public PoolSpecification Pool { get; set; }
    }
}
