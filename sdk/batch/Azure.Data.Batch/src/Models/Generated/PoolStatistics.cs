// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Data.Batch.Models
{
    /// <summary> Contains utilization and resource usage statistics for the lifetime of a Pool. </summary>
    public partial class PoolStatistics
    {
        /// <summary> Initializes a new instance of PoolStatistics. </summary>
        /// <param name="url"> The URL for the statistics. </param>
        /// <param name="startTime"> The start time of the time range covered by the statistics. </param>
        /// <param name="lastUpdateTime"> The time at which the statistics were last updated. All statistics are limited to the range between startTime and lastUpdateTime. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        internal PoolStatistics(string url, DateTimeOffset startTime, DateTimeOffset lastUpdateTime)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            Url = url;
            StartTime = startTime;
            LastUpdateTime = lastUpdateTime;
        }

        /// <summary> Initializes a new instance of PoolStatistics. </summary>
        /// <param name="url"> The URL for the statistics. </param>
        /// <param name="startTime"> The start time of the time range covered by the statistics. </param>
        /// <param name="lastUpdateTime"> The time at which the statistics were last updated. All statistics are limited to the range between startTime and lastUpdateTime. </param>
        /// <param name="usageStats"> Statistics related to Pool usage information. </param>
        /// <param name="resourceStats"> Statistics related to resource consumption by Compute Nodes in a Pool. </param>
        internal PoolStatistics(string url, DateTimeOffset startTime, DateTimeOffset lastUpdateTime, UsageStatistics usageStats, ResourceStatistics resourceStats)
        {
            Url = url;
            StartTime = startTime;
            LastUpdateTime = lastUpdateTime;
            UsageStats = usageStats;
            ResourceStats = resourceStats;
        }

        /// <summary> The URL for the statistics. </summary>
        public string Url { get; }
        /// <summary> The start time of the time range covered by the statistics. </summary>
        public DateTimeOffset StartTime { get; }
        /// <summary> The time at which the statistics were last updated. All statistics are limited to the range between startTime and lastUpdateTime. </summary>
        public DateTimeOffset LastUpdateTime { get; }
        /// <summary> Statistics related to Pool usage information. </summary>
        public UsageStatistics UsageStats { get; }
        /// <summary> Statistics related to resource consumption by Compute Nodes in a Pool. </summary>
        public ResourceStatistics ResourceStats { get; }
    }
}
